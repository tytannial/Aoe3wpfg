using System.Windows;

namespace aoe3wpfg
{
    public class Age3StringDB : DependencyObject
    {
        public static string GetStringId(DependencyObject obj)
        {
            return (string)obj.GetValue(StringIdProperty);
        }

        public static void SetStringId(DependencyObject obj, string value)
        {
            obj.SetValue(StringIdProperty, value);
        }

        public static string GetStringFormatId(DependencyObject obj)
        {
            return (string)obj.GetValue(StringFormatIdProperty);
        }

        public static void SetStringFormatId(DependencyObject obj, string value)
        {
            obj.SetValue(StringFormatIdProperty, value);
        }

        public string StringId
        {
            get { return (string)GetValue(StringIdProperty); }
            set { SetValue(StringIdProperty, value); }
        }

        public string StringFormatId
        {
            get { return (string)GetValue(StringFormatIdProperty); }
            set { SetValue(StringFormatIdProperty, value); }
        }

        public static readonly DependencyProperty StringIdProperty =
            DependencyProperty.RegisterAttached("StringId", typeof(string), typeof(Age3StringDB), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty StringFormatIdProperty =
            DependencyProperty.RegisterAttached("StringFormatId", typeof(string), typeof(Age3StringDB), new UIPropertyMetadata(string.Empty));
    }
}
