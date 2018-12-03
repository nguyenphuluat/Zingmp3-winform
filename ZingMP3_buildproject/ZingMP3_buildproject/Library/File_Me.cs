using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZingMP3_buildproject.Library
{
    class File_Me
    {
        public static string CoppyFile(string file_mp3_temp, string file_mp3)
        {
            //---------------Coppy file------------------
            string[] temp = file_mp3_temp.Split('\\');
            string fileName = "";
            string sourcePath = file_mp3_temp;
            temp = file_mp3.Split('\\');
            string directoryPath = "";
            for (int i = 0; i < temp.Length - 1; i++)
            {
                directoryPath += temp[i] + "\\";
            }
            directoryPath = directoryPath.Substring(0, directoryPath.Length - 1);


            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(directoryPath))
            {
                System.IO.Directory.CreateDirectory(directoryPath);
            }

            // To copy a file to another location and 
            //overwrite the destination file if it already exists.
            if (System.IO.File.Exists(sourcePath))
            {
                if (!System.IO.File.Exists(file_mp3))
                {
                    System.IO.File.Copy(sourceFile, file_mp3, true);
                }
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
                file_mp3 = "";
            }
            return file_mp3;
        }
    }
}
