using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.MenuClasses
{
    internal class MenuRun
    {
        private Menu root;

        public MenuRun(Menu root)
        {
            this.root = root;
        }

        public void Run()
        {
            root.Run();
        }
    }
}
