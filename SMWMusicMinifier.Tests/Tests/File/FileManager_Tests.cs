

namespace SMWMusicMinifier.Tests
{
    public class FileManager_Tests
    {
        #region instance properties

        private readonly FileManager _sut;

        #endregion
        #region lifecycle methods

        public FileManager_Tests()
        {
            _sut = new FileManager();
        }

        #endregion
        #region tests

        [Fact]
        public void Task_CheckForFileExistance_Success()
        {
            // given
            string testInputFileName = "test-data.txt";

            // when
            bool doesFileExist = _sut.CheckForFileExistance(testInputFileName);

            // then
            Assert.True(doesFileExist);
        }

        [Fact]
        public void Task_CheckForFileExistance_Fail()
        {
            // given
            string testInputFileName = "does-not-exist.txt";

            // when
            bool doesFileExist = _sut.CheckForFileExistance(testInputFileName);

            // then
            Assert.False(doesFileExist);
        }

        [Fact]
        public void Task_GetTextFromFile()
        {
            // given
            string testInputFileName = "test-data.txt";
            string expectedOutputData = File.ReadAllText(testInputFileName);

            // when
            string textFromFile = _sut.GetTextFromFile(testInputFileName);

            // then
            Assert.Equal(expectedOutputData, textFromFile);
        }

        [Fact]
        public void Task_WriteTextToFile()
        {
            // given
            string testInputData = File.ReadAllText("test-data.txt");
            string testInputFileName = "result-data.txt";

            // when
            _sut.WriteTextToFile(text: testInputData, fileName: testInputFileName);

            // then
            string expectedOutputData = File.ReadAllText(testInputFileName);
            Assert.Equal(testInputData, expectedOutputData);
        }

        #endregion
    }
}
