using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            string path = Environment.CurrentDirectory + @"\wwwroot\Images\";

            var fileName = NewFileName(file);

            try
            {
                var sourcepath = Path.GetTempFileName();

                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                var result = path + fileName;

                File.Move(sourcepath, result);
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

            return fileName;
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = Add(file);

            Delete(sourcePath);

            return result;
        }

        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        public static string NewFileName(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);

            string fileExtension = ff.Extension;

            var newFileName = Guid.NewGuid().ToString("N") + "_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + fileExtension;

            return newFileName;
        }
    }
}