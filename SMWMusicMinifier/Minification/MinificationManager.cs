

namespace SMWMusicMinifier
{
    internal class MinificationManager(IConsoleManager consoleManager, IFileManager fileManager) : IMinificationManager
    {
        #region instance properties

        private readonly IConsoleManager _consoleManager = consoleManager;
        private readonly IFileManager _fileManager = fileManager;

        #endregion
        #region IMinificationManager

        public void PerformMinification(string fileName)
        {
            _consoleManager.WriteBlankLine();
            _consoleManager.WriteLoading(message: "Minification started");

            string text = _fileManager.GetTextFromFile(fileName: fileName);
            text = MinifyTiedNotes(text: text);
            text = ApplyDotNotation(text: text);

            string minifiedFileName = GenerateMinifiedFileName(originalFileName: fileName);

            CreateMinifedFile(minifiedText: text, minifiedFileName: minifiedFileName);

            _consoleManager.WriteSuccess(message: "Minification completed");
            _consoleManager.WriteSuccess(message: "Minified file created named: " + minifiedFileName);
            _consoleManager.WriteBlankLine();
        }

        #endregion
        #region private methods

        private static string MinifyTiedNotes(string text)
        {
            text = text.Replace("64^64", "32");
            text = text.Replace("32^32", "16");
            text = text.Replace("16^16", "8");
            text = text.Replace("8^8", "4");
            text = text.Replace("4^4", "2");
            text = text.Replace("2^2", "1");
            return text;
        }

        private static string ApplyDotNotation(string text)
        {
            text = text.Replace("32^64", "32.");
            text = text.Replace("16^32", "16.");
            text = text.Replace("8^16", "8.");
            text = text.Replace("4^8", "4.");
            text = text.Replace("2^4", "2.");
            text = text.Replace("1^2", "1.");
            return text;
        }

        private static string GenerateMinifiedFileName(string originalFileName)
        {
            string minifiedFileName = originalFileName.Replace(".txt", ".min.txt");
            return minifiedFileName;
        }

        private void CreateMinifedFile(string minifiedText, string minifiedFileName)
        {
            _fileManager.WriteTextToFile(text: minifiedText, fileName: minifiedFileName);
        }

        #endregion
    }
}
