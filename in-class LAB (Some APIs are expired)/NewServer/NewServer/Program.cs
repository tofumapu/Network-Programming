using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System;
using System.IO;
using Microsoft.VisualBasic;
using System;
using System.Threading;

public class NewServer
{
    public static void Main(string[] args)
    {
        Server server = new Server();
        server.Start(IPAddress.Parse("127.0.0.1"), 26950);

        while (true)
        {
            server.ProcessClientData(); // Xử lý dữ liệu từ các client
            server.CheckPingTimeouts(); // Kiểm tra timeout từ Ping (nếu cần)

            Thread.Sleep(10); // Nghỉ 10ms để giảm tải CPU
        }

    }
}
