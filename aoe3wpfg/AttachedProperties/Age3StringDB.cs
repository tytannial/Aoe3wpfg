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

        public string StringId
        {
            get { return (string)GetValue(StringIdProperty); }
            set { SetValue(StringIdProperty, value); }
        }

        public static readonly DependencyProperty StringIdProperty =
            DependencyProperty.RegisterAttached("StringId", typeof(string), typeof(Age3StringDB), new UIPropertyMetadata(string.Empty));
    }
}
