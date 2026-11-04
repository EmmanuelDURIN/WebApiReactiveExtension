namespace WebApiReactiveExtension
{
    public class HitCounter
    {
        // TODO  : constructor that should read counter from db
        private int counter;

        public void Increment()
        {
            counter++;
            // TODO : we need to write the counter to db, but not too often
            WriteToDb();
        }

        private void WriteToDb()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }
    }
}
