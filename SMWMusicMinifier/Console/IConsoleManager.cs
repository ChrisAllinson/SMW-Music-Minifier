

namespace SMWMusicMinifier
{
    internal interface IConsoleManager
    {
        public void WriteBlankLine();
        public void WriteWelcomeUserLine(string message);
        public void WritePrompt(string message);
        public void WriteLoading(string message);
        public void WriteSuccess(string message);
        public void WriteError(string message);
        public string ReadLine();
    }
}
