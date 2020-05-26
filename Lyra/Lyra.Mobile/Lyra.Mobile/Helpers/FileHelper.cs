using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lyra.Mobile.Helpers
{
    public static class FileHelper
    {
        private static string _path { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string SaveFile(byte[] file, string filename, string path = null)
        {
            filename = Path.Combine(string.IsNullOrEmpty(path) ? _path : path, filename);
            using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                fs.Write(file, 0, file.Length);
                fs.Close();
            }
            return filename;
        }

        public static bool DeleteFile(string filename, string path = null)
        {
            filename = Path.Combine(string.IsNullOrEmpty(path) ? _path : path, filename);
            try
            {
                File.Delete(filename);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
