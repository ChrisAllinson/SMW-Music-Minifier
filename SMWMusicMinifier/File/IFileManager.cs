

namespace SMWMusicMinifier
{
    internal interface IFileManager
    {
        public bool CheckForFileExistance(string fileName);
        public string GetTextFromFile(string fileName);
        public void WriteTextToFile(string text, string fileName);
    }
}
