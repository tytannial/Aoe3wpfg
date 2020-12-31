using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace aoe3wpfg
{
    public class Age3Precache : DependencyObject
    {
        public List<string> Paths { get; set; } = new List<string>();
    }
}
