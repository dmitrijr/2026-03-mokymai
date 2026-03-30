namespace HelloWorld
{
    public class DataSaver
    {
        public string FileName { get; set; }

        private DataSaver()
        {

        }

        private static DataSaver _dataSaver;
        public static DataSaver GetInstance()
        {
            if (_dataSaver == null)
                _dataSaver = new DataSaver();

            return _dataSaver;
        }

        public void Save()
        {
            Console.WriteLine($"Saving to: {FileName}");
        }
    }
}