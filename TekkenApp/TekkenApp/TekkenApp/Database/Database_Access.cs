using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TekkenApp.Database
{
    public class Database_Access
    {
        public void FindDB()
        {
            string[] dirs = Directory.GetFiles("Movelist_Alisa.db3");
            string path = dirs[0];

            //File.Copy(path, @"d:\");
        }
    }
}
