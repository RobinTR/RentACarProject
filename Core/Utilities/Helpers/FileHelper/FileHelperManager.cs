﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }

                string extension = Path.GetExtension(file.FileName);
                string guid = Guid.NewGuid().ToString();
                string filePath = guid + extension;

                using (FileStream fileStream = File.Create(root + filePath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return filePath;
                }
            }

            return null;
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Upload(file, root);
        }

        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
