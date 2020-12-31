using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aoe3wpfg
{
    /// <summary>
    /// Age3PopoverPage.xaml 的交互逻辑
    /// </summary>
    public partial class Age3PopoverPage : UserControl
    {
        public string FrameUri { get; set; }
        public BitmapImage Icon { get; set; }
        public string DescriptionId { get; set; }
        public string NotificationCount { get; set; }

        public Age3PopoverPage()
        {
            InitializeComponent();
        }
    }
}
