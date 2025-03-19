using GameServer;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;

namespace ServerWithWinForm
{
    internal static class Program
    {
        private static bool isRunning = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormServer());
            isRunning = true;

            Thread mainThread = new Thread(new ThreadStart(MainThread));
            mainThread.Start();

            Server.Start(50, 26950);

        }

        private static void MainThread()
        {
            FormServer.Instance.rtb_Server.Invoke(new Action(() =>
            {
                FormServer.Instance.rtb_Server.AppendText($"Main thread started. Running at {Constants.TICKS_PER_SEC} ticks per second.");
            }));

            DateTime _nextLoop = DateTime.Now;

            while (isRunning)
            {
                while (_nextLoop < DateTime.Now)
                {
                    GameLogic.Update();

                    _nextLoop = _nextLoop.AddMilliseconds(Constants.MS_PER_TICK);

                    if (_nextLoop > DateTime.Now)
                    {
                        Thread.Sleep(_nextLoop - DateTime.Now);
                    }
                }
            }
        }
    }
}