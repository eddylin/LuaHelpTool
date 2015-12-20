using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using NLua;



namespace LuaHelpTool
{
    class Program
    {
        public static WatcherManager watchManager = new WatcherManager();
        public static Lua state = new Lua();
        static void Main(string[] args)
        {

            state.RegisterFunction("addWatcher", watchManager, watchManager.GetType().GetMethod("AddWatcher"));
            state.DoFile("main.lua");

            Console.ReadLine();
        }
    }
}
