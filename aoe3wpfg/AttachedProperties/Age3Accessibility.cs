using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace aoe3wpfg
{
    public class Age3Accessibility : DependencyObject
    {
        public static bool GetAccessibilityControlSkip(DependencyObject obj)
        {
            return (bool)obj.GetValue(AccessibilityControlSkipProperty);
        }

        public static void SetAccessibilityControlSkip(DependencyObject obj, bool value)
        {
            obj.SetValue(AccessibilityControlSkipProperty, value);
        }

        public static string GetMode(DependencyObject obj)
        {
            return (string)obj.GetValue(ModeProperty);
        }

        public static void SetMode(DependencyObject obj, string value)
        {
            obj.SetValue(ModeProperty, value);
        }

        public static string GetTextID(DependencyObject obj)
        {
            return (string)obj.GetValue(TextIDProperty);
        }

        public static void SetTextID(DependencyObject obj, string value)
        {
            obj.SetValue(TextIDProperty, value);
        }

        public static string GetText(DependencyObject obj)
        {
            return (string)obj.GetValue(TextProperty);
        }

        public static void SetText(DependencyObject obj, string value)
        {
            obj.SetValue(TextProperty, value);
        }

        public static bool GetNarrateActualValue(DependencyObject obj)
        {
            return (bool)obj.GetValue(NarrateActualValueProperty);
        }

        public static void SetNarrateActualValue(DependencyObject obj, bool value)
        {
            obj.SetValue(NarrateActualValueProperty, value);
        }

        public bool AccessibilityControlSkip
        {
            get { return (bool)GetValue(AccessibilityControlSkipProperty); }
            set { SetValue(AccessibilityControlSkipProperty, value); }
        }

        public string Mode
        {
            get { return (string)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public string TextID
        {
            get { return (string)GetValue(TextIDProperty); }
            set { SetValue(TextIDProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public bool NarrateActualValue
        {
            get { return (bool)GetValue(NarrateActualValueProperty); }
            set { SetValue(NarrateActualValueProperty, value); }
        }

        public static readonly DependencyProperty AccessibilityControlSkipProperty =
            DependencyProperty.RegisterAttached("AccessibilityControlSkip", typeof(bool), typeof(Age3Accessibility), new UIPropertyMetadata(false));

        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.RegisterAttached("Mode", typeof(string), typeof(Age3Accessibility), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty TextIDProperty =
            DependencyProperty.RegisterAttached("TextID", typeof(string), typeof(Age3Accessibility), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string), typeof(Age3Accessibility), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty NarrateActualValueProperty =
            DependencyProperty.RegisterAttached("NarrateActualValue", typeof(bool), typeof(Age3Accessibility), new UIPropertyMetadata(false));
    }
}
