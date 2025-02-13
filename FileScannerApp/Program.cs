﻿using System.IO;
using System.Linq;

namespace FileScannerApp
{
    internal class Program
    {
        private static readonly FileService _fileService = new();
        static void Main(string[] args)
        {
            var path = @"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\Advanced";
            var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).ToList();

            _fileService.SaveFilesWithFolders(files);
        }
    }
}
