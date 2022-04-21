namespace Adapter
{
    class Program
    {
        static void Main (string[] args)
        {
            ILogSaver logSaver = new CloudLogSaverAdapter();

            Log simplelog = new Log("Hello World");
            Log errorlog = new Log("Hello World !", "Exception message...");

            logSaver.SaveLog(simplelog);
            logSaver.SaveErrorLog(errorlog);

        }
    }
}
