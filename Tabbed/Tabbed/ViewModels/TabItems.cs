using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tabbed.ViewModels
{
    public class myTabA
    {
        public string Name { set; get; }
        public Color Color { set; get; }
        public override string ToString() => Name;
        public myTabA() { }
        public myTabA(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }
}
