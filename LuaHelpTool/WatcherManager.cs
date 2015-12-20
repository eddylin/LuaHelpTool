using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using NLua;

namespace LuaHelpTool
{
    class WatcherManager
    {
        public void AddWatcher(string path)
        {
            Console.WriteLine("AddWather is called!");
            FileSystemWatcher watcher = new FileSystemWatcher(path);
        }
    }
}
