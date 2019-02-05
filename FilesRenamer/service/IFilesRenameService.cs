using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesRenamer.service
{
    public interface IFilesRenameService
    {
        void RenameFiles(string inputDirPath, string outputDirPath);
    }
}
