﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesRenamer.service
{
    public interface ILogger
    {
        void Log(string message);
        void Error(string message);
    }
}
