

namespace SMWMusicMinifier
{
    internal class ConsoleManager : IConsoleManager
    {
        #region enums

        private enum MessageStyle
        {
            Welcome,
            Default,
            Prompt,
            Loading,
            Success,
            Error
        }

        #endregion
        #region instance properties

        private readonly IConsoleWrapper _consoleWrapper;

        #endregion
        #region lifecycle methods

        public ConsoleManager(IConsoleWrapper consoleWrapper)
        {
            _consoleWrapper = consoleWrapper;
            SetDefaultStyles();
        }

        #endregion
        #region IConsoleManager

        public void WriteBlankLine()
        {
            WriteMessage(message: "", style: MessageStyle.Default);
        }

        public void WriteWelcomeUserLine(string message)
        {
            WriteMessage(message: message, style: MessageStyle.Welcome);
        }

        public void WritePrompt(string message)
        {
            WriteMessage(message: message, style: MessageStyle.Prompt);
            SetUserInputTextColor();
        }

        public void WriteLoading(string message)
        {
            WriteMessage(message: message, style: MessageStyle.Loading);
        }

        public void WriteSuccess(string message)
        {
            WriteMessage(message: message, style: MessageStyle.Success);
        }

        public void WriteError(string message)
        {
            WriteMessage(message: message, style: MessageStyle.Error);
        }

        public string ReadLine()
        {
            return _consoleWrapper.ReadLine() ?? "";
        }

        #endregion
        #region private methods

        private void SetDefaultStyles()
        {
            _consoleWrapper.SetBackgroundColor(color: ConsoleColor.Black);
            _consoleWrapper.SetForegroundColor(color: ConsoleColor.White);
        }

        private void WriteMessage(string message, MessageStyle style)
        {
            SetStyle(style: style);
            _consoleWrapper.WriteLine(message);
        }

        private void SetStyle(MessageStyle style)
        {
            ConsoleColor foregroundColor = style switch
            {
                MessageStyle.Welcome => ConsoleColor.DarkGray,
                MessageStyle.Default => ConsoleColor.White,
                MessageStyle.Prompt => ConsoleColor.Cyan,
                MessageStyle.Loading => ConsoleColor.DarkYellow,
                MessageStyle.Success => ConsoleColor.Green,
                MessageStyle.Error => ConsoleColor.Red,
                _ => ConsoleColor.White,
            };
            _consoleWrapper.SetForegroundColor(color: foregroundColor);
        }

        private void SetUserInputTextColor()
        {
            SetStyle(MessageStyle.Default);
        }

        #endregion
    }
}
