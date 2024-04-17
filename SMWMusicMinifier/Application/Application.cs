

namespace SMWMusicMinifier
{
    internal class Application
    {
        #region instance properties

        private readonly IConsoleManager _consoleManager;
        private readonly IFileManager _fileManager;
        private readonly IMinificationManager _minificationManager;

        #endregion
        #region lifecycle methods

        public Application(IConsoleManager consoleManager, IFileManager fileManager, IMinificationManager minificationManager)
        {
            _consoleManager = consoleManager;
            _fileManager = fileManager;
            _minificationManager = minificationManager;

            WelcomeUser();
            StartEngine();
        }

        #endregion
        #region private methods

        private void WelcomeUser()
        {
            _consoleManager.WriteWelcomeUserLine(message: "");
            _consoleManager.WriteWelcomeUserLine(message: "********************************");
            _consoleManager.WriteWelcomeUserLine(message: "*                              *");
            _consoleManager.WriteWelcomeUserLine(message: "*  SMW Music Minifier  v1.0.0  *");
            _consoleManager.WriteWelcomeUserLine(message: "*  Christopher James Allinson  *");
            _consoleManager.WriteWelcomeUserLine(message: "*                              *");
            _consoleManager.WriteWelcomeUserLine(message: "********************************");
            _consoleManager.WriteWelcomeUserLine(message: "");
            _consoleManager.WriteWelcomeUserLine(message: "");
        }

        private void StartEngine()
        {
            string fileName = PromptUserForFileName();
            if (_fileManager.CheckForFileExistance(fileName: fileName))
            {
                HandleFileExists(fileName: fileName);
            }
            else
            {
                HandleFileDoesNotExist();
            }
        }

        private string PromptUserForFileName()
        {
            _consoleManager.WritePrompt(message: "Enter filename:");
            string fileName = _consoleManager.ReadLine();
            return fileName;
        }

        private void HandleFileExists(string fileName)
        {
            _minificationManager.PerformMinification(fileName: fileName);
            _consoleManager.WritePrompt(message: "Press enter to exit the program");
            _consoleManager.ReadLine();
        }

        private void HandleFileDoesNotExist()
        {
            _consoleManager.WriteBlankLine();
            _consoleManager.WriteError(message: "File does not exist");
            _consoleManager.WriteError(message: "Please try again");
            _consoleManager.WriteBlankLine();

            StartEngine();
        }

        #endregion
    }
}
