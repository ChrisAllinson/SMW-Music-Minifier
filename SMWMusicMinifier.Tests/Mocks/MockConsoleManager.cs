

namespace SMWMusicMinifier.Tests
{
    public class MockConsoleManager : IConsoleManager
    {
        #region instance properties

        public string ReadLineHelper = "";
        public string WritePromptHelper = "";

        #endregion
        #region IConsoleManager

        public string ReadLine()
        {
            return ReadLineHelper;
        }

        public void WriteBlankLine()
        {
        }

        public void WriteWelcomeUserLine(string message)
        {
        }

        public void WriteError(string message)
        {
        }

        public void WriteLoading(string message)
        {
        }

        public void WritePrompt(string message)
        {
            WritePromptHelper = message;
        }

        public void WriteSuccess(string message)
        {
        }

        #endregion
    }
}
