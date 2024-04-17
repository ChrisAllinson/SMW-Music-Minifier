

namespace SMWMusicMinifier
{
    internal class FileManager : IFileManager
    {
        #region IFileManager

        public bool CheckForFileExistance(string fileName)
        {
            return File.Exists(fileName);
        }

        public string GetTextFromFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public void WriteTextToFile(string text, string fileName)
        {
            File.WriteAllText(fileName, text);
        }

        #endregion
    }
}
