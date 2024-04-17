

namespace SMWMusicMinifier
{
    internal class ConsoleWrapper : IConsoleWrapper
    {
        #region IConsoleWrapper

        public void SetBackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void SetForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public string? ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        #endregion
    }
}
