using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace aoe3wpfg
{
    public class PreviewTextBox : TextBox
    {
        public string PreviewText
        {
            get { return (string)GetValue(PreviewTextProperty); }
            set { SetValue(PreviewTextProperty, value); }
        }

        public static readonly DependencyProperty PreviewTextProperty = DependencyProperty.Register(
            "PreviewText", typeof(string), typeof(PreviewTextBox));
    }
}
