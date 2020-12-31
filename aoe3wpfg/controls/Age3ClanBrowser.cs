using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace aoe3wpfg
{
    public class Age3ClanBrowser
    {
        public static ICommand SendApplication { get; set; }
        public static ICommand CancelApplication { get; set; }
        public static ICommand AcceptInvite { get; set; }
        public static ICommand RejectInvite { get; set; }

    }
}
