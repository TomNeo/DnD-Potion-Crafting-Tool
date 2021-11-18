using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Potion_Crafting_Tool
{
    static class Program
    {
        public static Tools TOOLS = new Tools();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public enum Ranks
        {
            STARTING=0,
            BASIC=1,
            COMMON=2,
            UNCOMMON=3,
            RARE=4,
            VERY_RARE=5,
            LEGENDARY=6      
        }
    }
}
