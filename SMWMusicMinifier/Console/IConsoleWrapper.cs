

namespace SMWMusicMinifier
{
    internal interface IConsoleWrapper
    {
        public void SetBackgroundColor(ConsoleColor color);
        public void SetForegroundColor(ConsoleColor color);
        public string? ReadLine();
        public void WriteLine(string message);
    }
}
