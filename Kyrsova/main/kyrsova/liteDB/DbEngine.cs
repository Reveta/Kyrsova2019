using System;
using System.Collections.Generic;
using LiteDB;

namespace Kyrsova.main.kyrsova.liteDB
{
    public class DbEngine
    {
        static string connectionString = "Filename=test.litedb4; Mode=Exclusive;";
        static LiteDatabase liteDatabase = new LiteDatabase(connectionString);

        public static void ShowAllMusicInfo()
        {
            IEnumerable<MusicInfo> findAll = GetMusicTable().FindAll();
            foreach (MusicInfo obj in findAll) {
                Console.WriteLine(obj);
            }
        }

        public static LiteCollection<MusicInfo> GetMusicTable()
        {
            return liteDatabase.GetCollection<MusicInfo>("musicInfo");
        }

        public static void AddMusicToDb(MusicInfo musicInfo)
        {
            GetMusicTable().Insert(musicInfo);
        }

        public static LiteDatabase GetDb()
        {
            return liteDatabase;
        }
    }
}