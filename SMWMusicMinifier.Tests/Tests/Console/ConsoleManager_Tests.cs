

namespace SMWMusicMinifier.Tests
{
    public class ConsoleManager_Tests
    {
        #region instance properties

        private readonly MockConsoleWrapper _mockConsoleWrapper;
        private ConsoleManager _sut;

        #endregion
        #region lifecycle methods

        public ConsoleManager_Tests()
        {
            _mockConsoleWrapper = new();
            _sut = new ConsoleManager(consoleWrapper: _mockConsoleWrapper);
        }

        #endregion
        #region tests

        [Fact]
        public void Task_InitDefaultStyles()
        {
            // given
            ConsoleColor expectedConsoleBackgroundColor = ConsoleColor.Black;
            ConsoleColor expectedConsoleForegroundColor = ConsoleColor.White;

            // when
            _sut = new ConsoleManager(consoleWrapper: _mockConsoleWrapper);

            // then
            Assert.Equal(expectedConsoleBackgroundColor, _mockConsoleWrapper.BackgroundColor);
            Assert.Equal(expectedConsoleForegroundColor, _mockConsoleWrapper.ForegroundColor);
        }

        [Fact]
        public void Task_WriteBlankLine()
        {
            // given
            ConsoleColor expectedConsoleBackgroundColor = ConsoleColor.Black;
            ConsoleColor expectedConsoleForegroundColor = ConsoleColor.White;

            // when
            _sut.WriteBlankLine();

            // then
            Assert.Equal(expectedConsoleBackgroundColor, _mockConsoleWrapper.BackgroundColor);
            Assert.Equal(expectedConsoleForegroundColor, _mockConsoleWrapper.ForegroundColor);
        }

        [Fact]
        public void Task_WriteWelcomeUserLine()
        {
            // given
            ConsoleColor expectedConsoleBackgroundColor = ConsoleColor.Black;
            ConsoleColor expectedConsoleForegroundColor = ConsoleColor.DarkGray;

            // when
            _sut.WriteWelcomeUserLine(message: "");

            // then
            Assert.Equal(expectedConsoleBackgroundColor, _mockConsoleWrapper.BackgroundColor);
            Assert.Equal(expectedConsoleForegroundColor, _mockConsoleWrapper.ForegroundColor);
        }

        [Fact]
        public void Task_WritePrompt()
        {
            // given
            ConsoleColor expectedConsoleBackgroundColor = ConsoleColor.Black;
            ConsoleColor expectedConsoleForegroundColor = ConsoleColor.White;

            // when
            _sut.WritePrompt(message: "");

            // then
            Assert.Equal(expectedConsoleBackgroundColor, _mockConsoleWrapper.BackgroundColor);
            Assert.Equal(expectedConsoleForegroundColor, _mockConsoleWrapper.ForegroundColor);
        }

        [Fact]
        public void Task_WriteLoading()
        {
            // given
            ConsoleColor expectedConsoleBackgroundColor = ConsoleColor.Black;
            ConsoleColor expectedConsoleForegroundColor = ConsoleColor.DarkYellow;

            // when
            _sut.WriteLoading(message: "");

            // then
            Assert.Equal(expectedConsoleBackgroundColor, _mockConsoleWrapper.BackgroundColor);
            Assert.Equal(expectedConsoleForegroundColor, _mockConsoleWrapper.ForegroundColor);
        }

        [Fact]
        public void Task_WriteSuccess()
        {
            // given
            ConsoleColor expectedConsoleBackgroundColor = ConsoleColor.Black;
            ConsoleColor expectedConsoleForegroundColor = ConsoleColor.Green;

            // when
            _sut.WriteSuccess(message: "");

            // then
            Assert.Equal(expectedConsoleBackgroundColor, _mockConsoleWrapper.BackgroundColor);
            Assert.Equal(expectedConsoleForegroundColor, _mockConsoleWrapper.ForegroundColor);
        }

        [Fact]
        public void Task_WriteError()
        {
            // given
            ConsoleColor expectedConsoleBackgroundColor = ConsoleColor.Black;
            ConsoleColor expectedConsoleForegroundColor = ConsoleColor.Red;

            // when
            _sut.WriteError(message: "");

            // then
            Assert.Equal(expectedConsoleBackgroundColor, _mockConsoleWrapper.BackgroundColor);
            Assert.Equal(expectedConsoleForegroundColor, _mockConsoleWrapper.ForegroundColor);
        }

        #endregion
    }
}
