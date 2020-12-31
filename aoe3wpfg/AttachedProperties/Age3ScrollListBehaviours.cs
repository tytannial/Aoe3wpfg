using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace aoe3wpfg
{
    public class Age3ScrollListBehaviours : DependencyObject
    {
        public static bool GetScrollOnNewItem(DependencyObject obj)
        {
            return (bool)obj.GetValue(ScrollOnNewItemProperty);
        }

        public static void SetScrollOnNewItem(DependencyObject obj, bool value)
        {
            obj.SetValue(ScrollOnNewItemProperty, value);
        }

        public bool ScrollOnNewItem
        {
            get { return (bool)GetValue(ScrollOnNewItemProperty); }
            set { SetValue(ScrollOnNewItemProperty, value); }
        }

        public static readonly DependencyProperty ScrollOnNewItemProperty =
            DependencyProperty.RegisterAttached("ScrollOnNewItem", typeof(bool), typeof(Age3Accessibility), new UIPropertyMetadata(false));
    }
}
