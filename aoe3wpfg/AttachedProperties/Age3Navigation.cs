using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace aoe3wpfg
{
    public class Age3Navigation : DependencyObject
    {
        public static string GetWindowGroupID(DependencyObject obj)
        {
            return (string)obj.GetValue(WindowGroupIDProperty);
        }

        public static void SetWindowGroupID(DependencyObject obj, string value)
        {
            obj.SetValue(WindowGroupIDProperty, value);
        }

        public string WindowGroupID
        {
            get { return (string)GetValue(WindowGroupIDProperty); }
            set { SetValue(WindowGroupIDProperty, value); }
        }

        public static readonly DependencyProperty WindowGroupIDProperty =
            DependencyProperty.RegisterAttached("WindowGroupID", typeof(string), typeof(Age3Accessibility), new UIPropertyMetadata(string.Empty));
    }
}
