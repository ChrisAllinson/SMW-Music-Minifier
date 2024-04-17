

namespace SMWMusicMinifier.Tests
{
    public class MinificationManager_Tests
    {
        #region instance properties

        private readonly MockConsoleManager _mockConsoleManager;
        private readonly MockFileManager _mockFileManager;
        private readonly MinificationManager _sut;

        #endregion
        #region lifecycle methods

        public MinificationManager_Tests()
        {
            _mockConsoleManager = new();
            _mockFileManager = new()
            {
                GetTextFromFileHelper = File.ReadAllText("test-data.txt")
            };
            _sut = new(consoleManager: _mockConsoleManager, fileManager: _mockFileManager);
        }

        #endregion
        #region tests

        [Fact]
        public void Task_TestPerformMinification()
        {
            // given
            string testInputFileName = "test-data.txt";
            string expectedOutputFileName = "test-data.min.txt";
            string expectedOutputText = File.ReadAllText(expectedOutputFileName);

            // when
            _sut.PerformMinification(fileName: testInputFileName);

            // then
            Assert.Equal(expectedOutputFileName, _mockFileManager.WriteTextToFileHelper_FileName);
            Assert.Equal(expectedOutputText, _mockFileManager.WriteTextToFileHelper_Text);
        }

        #endregion
    }
}
