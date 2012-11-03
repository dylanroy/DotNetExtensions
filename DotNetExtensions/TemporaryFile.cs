﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DotNetExtensions
{
    public sealed class TemporaryFile : IDisposable
    {
        public TemporaryFile() :
            this(Path.GetTempPath()) { }

        public TemporaryFile(string directory)
        {
            Create(Path.Combine(directory, Path.GetRandomFileName()));
        }

        ~TemporaryFile()
        {
            Delete();
        }

        public void Dispose()
        {
            Delete();
            GC.SuppressFinalize(this);
        }

        public string FilePath { get; private set; }

        private void Create(string path)
        {
            FilePath = path;
            using (File.Create(FilePath)) { };
        }

        private void Delete()
        {
            if (FilePath == null) return;
            File.Delete(FilePath);
            FilePath = null;
        }
    }

}
