using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesRenamer.service
{
    public class FilesRenameService : IFilesRenameService
    {
        private readonly ILogger _logger;
        private string _outputDirPath;

        public FilesRenameService(ILogger logger)
        {
            this._logger = logger;
        }

        public void RenameFiles(string inputDirPath, string outputDirPath)
        {
            var codesDirList = Directory.GetDirectories(inputDirPath);
            _logger.Log("Total code directories found = " + codesDirList.Length);
            this._outputDirPath = outputDirPath;
            ProcessCodeDirectories(codesDirList);
        }

        private void ProcessCodeDirectories(string[] codesDirList)
        {
            foreach (var codeDirectory in codesDirList)
            {
                ProcessCodeDirectory(codeDirectory);
            }
        }

        private void ProcessCodeDirectory(string codeDirectory)
        {
            _logger.Log("Processing code directory: " + codeDirectory);
            var colorsDirectorioes = Directory.GetDirectories(codeDirectory);
            _logger.Log($"Total colors directories = {colorsDirectorioes.Length}");
            
            foreach (var colorDirectory in colorsDirectorioes)
            {
                ProcessColorDirectory(colorDirectory);
            }
        }

        private void ProcessColorDirectory(string colorDirectory)
        {
            _logger.Log($"Processing directory {colorDirectory}");
            var files = Directory.GetFiles(colorDirectory);
            _logger.Log($"Total files = " + files.Length);

            var filteredFiles = files.Where(x => !x.ToLower().EndsWith("thumbs.db")).ToList();

            ProcessFiles(filteredFiles);
        }

        private void ProcessFiles(List<string> files)
        {
            var insideFilesCount = 0;
            var outsideFilesCount = 0;

            files.Sort(new FileNameByOrderComparer());

            for (var i = 0; i < files.Count(); i++)
            {
                var srcFilePath = files.ElementAt(i);
                var tokens = srcFilePath.Split('\\');

                // Old data
                var oldFileName = tokens[tokens.Length - 1];
                var oldColor = tokens[tokens.Length - 2];
                var code = tokens[tokens.Length - 3];
                var fileExtension = Path.GetExtension(srcFilePath);

                // New data
                var newColorCodes = MapColorToColorCodes(oldColor);

                var isInside = oldFileName.ToLower().Contains("inside");
                var isOutside = oldFileName.ToLower().Contains("outside");
                var insideOutsideDir = "";
                int fileNumber;

                if (isInside)
                {
                    insideFilesCount++;
                    fileNumber = insideFilesCount;
                    insideOutsideDir = "inside";
                }
                else if (isOutside)
                {
                    outsideFilesCount++;
                    fileNumber = outsideFilesCount;
                    insideOutsideDir = "outside";
                }
                else
                {
                    _logger.Error($"File {srcFilePath} is neither inside nor inside");
                    continue;
                }

                if (newColorCodes.Count == 0 && oldColor.ToLower() != "default")
                {
                    _logger.Error($"No mapping found for Color directory {oldColor}");
                }

                foreach (var newColorCode in newColorCodes)
                {
                    var newDirectory = $"{_outputDirPath}\\{code}\\{newColorCode}\\{insideOutsideDir}";
                    var newFileName = $"{code}{newColorCode}{fileNumber}{fileExtension}";
                    var destFilePath = $"{newDirectory}\\{newFileName}";

                    if (!Directory.Exists(newDirectory))
                    {
                        Directory.CreateDirectory(newDirectory);
                    }

                    File.Copy(srcFilePath, destFilePath, true);
                    _logger.Log($"Copied file from {srcFilePath} to {destFilePath}");
                }
            }
        }

        private List<string> MapColorToColorCodes(string colorName)
        {
            var colorCodesStr = ConfigurationManager.AppSettings[colorName];
            var colorCodesList = new List<string>();

            if (!string.IsNullOrWhiteSpace(colorCodesStr))
            {
                colorCodesList = colorCodesStr.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            }

            return colorCodesList;
        }

        private class FileNameByOrderComparer : IComparer<string>
        {
            public int Compare(string f1, string f2)
            {
                int f1Order = GetFileOrder(f1);
                int f2Order = GetFileOrder(f2);

                return f1Order.CompareTo(f2Order);
            }

            private int GetFileOrder(string filePath)
            {
                var tokens = filePath.Split('\\');
                var filename = tokens[tokens.Length - 1];

                string[] tokens2 = filename.Split(new char[] { '_', '.' });
                if (tokens2.Length > 2)
                {
                    int order = int.Parse(tokens2[1]);
                    return order;
                }
                return 0;
            }
        }
    }
}
