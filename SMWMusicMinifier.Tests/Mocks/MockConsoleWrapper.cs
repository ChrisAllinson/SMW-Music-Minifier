

namespace SMWMusicMinifier.Tests
{
    public class MockConsoleWrapper : IConsoleWrapper
    {
        #region instance properties

        public ConsoleColor BackgroundColor = ConsoleColor.White;
        public ConsoleColor ForegroundColor = ConsoleColor.White;
        public string ReadLineHelper = "";
        public string WriteLineHelper = "";

        #endregion
        #region IConsoleWrapper

        public void SetBackgroundColor(ConsoleColor color)
        {
            BackgroundColor = color;
        }

        public void SetForegroundColor(ConsoleColor color)
        {
            ForegroundColor = color;
        }

        public string? ReadLine()
        {
            return ReadLineHelper;
        }

        public void WriteLine(string message)
        {
            WriteLineHelper = message;
        }

        #endregion
    }
}
