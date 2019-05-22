using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Kyrsova.main.kyrsova.liteDB;
using Kyrsova.main.kyrsova.webServer;
using LiteDB;
using Nancy.Hosting.Self;

namespace Kyrsova
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(() =>
            {
                WebServer.Start();
            });
            
            DbEngine.AddMusicToDb(new MusicInfo("Test", "BigTest", true));
            DbEngine.ShowAllMusicInfo();
            
            while (true)
            {
            }
        }
    }
}