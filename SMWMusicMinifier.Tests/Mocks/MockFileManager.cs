

namespace SMWMusicMinifier.Tests
{
    public class MockFileManager : IFileManager
    {
        #region instance properties

        public bool CheckForFileExistanceHelper = true;
        public string GetTextFromFileHelper = "";
        public string WriteTextToFileHelper_Text = "";
        public string WriteTextToFileHelper_FileName = "";

        #endregion
        #region IFileManager

        public bool CheckForFileExistance(string fileName)
        {
            return CheckForFileExistanceHelper;
        }

        public string GetTextFromFile(string fileName)
        {
            return GetTextFromFileHelper;
        }

        public void WriteTextToFile(string text, string fileName)
        {
            WriteTextToFileHelper_Text = text;
            WriteTextToFileHelper_FileName = fileName;
        }

        #endregion
    }
}
