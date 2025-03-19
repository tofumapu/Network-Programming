namespace Lab1_23520231_23520249
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Lab1_BaiTap1());
            //Application.Run(new Lab1_BaiTap2());
            //Application.Run(new Lab1_BaiTap3());
            //Application.Run(new Lab1_BaiTap4());
            //Application.Run(new Lab1_BaiTap5());
            Application.Run(new Lab1_MenuForm());


        }
    }
}