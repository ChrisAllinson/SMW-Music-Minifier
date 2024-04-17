

using SMWMusicMinifier;

using System.Runtime.CompilerServices;
#pragma warning disable IDE0055
[assembly:InternalsVisibleTo("SMWMusicMinifier.Tests")]


#region instance properties

IConsoleWrapper consoleWrapper = new ConsoleWrapper();
IConsoleManager consoleManager = new ConsoleManager(consoleWrapper: consoleWrapper);
IFileManager fileManager = new FileManager();
IMinificationManager minificationManager = new MinificationManager(consoleManager: consoleManager, fileManager: fileManager);

#endregion
#region lifecycle methods

Application application = new(consoleManager: consoleManager, fileManager: fileManager, minificationManager: minificationManager);

#endregion
