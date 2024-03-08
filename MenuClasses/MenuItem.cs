using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioLenguajeDotnet.MenuClasses
{
    internal class MenuItem
    {
        public string name { get; private set; }
        public Action action { get; private set; }
        public Action? back { get; private set; }

        public MenuItem(string name, Action action)
        {
            this.name = name;
            this.action = action;
        }

        public MenuItem(string name, Action action, Action back) : this(name, action)
        {
            this.back = back;
        }
    }
}
