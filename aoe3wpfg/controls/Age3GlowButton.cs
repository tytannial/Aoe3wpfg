using System.Windows;
using System.Windows.Controls;

namespace aoe3wpfg
{
    public class Age3GlowButton : Age3Button
    {
        public bool Glow
        {
            get { return (bool)GetValue(GlowProperty); }
            set { SetValue(GlowProperty, value); }
        }

        public static readonly DependencyProperty GlowProperty = DependencyProperty.Register(
            "Glow", typeof(bool), typeof(Age3GlowButton));
    }
}
