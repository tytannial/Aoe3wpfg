using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace aoe3wpfg
{
    public class Age3PopoverControl : ToolTip
    {
        public PopupAnimation PopoverAnimation
        {
            get { return (PopupAnimation)GetValue(PopoverAnimationProperty); }
            set { SetValue(PopoverAnimationProperty, value); }
        }

        public Page PopoverPage
        {
            get { return (Page)GetValue(PopoverPageProperty); }
            set { SetValue(PopoverPageProperty, value); }
        }

        public bool IsPopoverOpen
        {
            get { return (bool)GetValue(IsPopoverOpenProperty); }
            set { SetValue(IsPopoverOpenProperty, value); }
        }

        public static readonly DependencyProperty PopoverAnimationProperty = DependencyProperty.Register(
            "PopoverAnimation", typeof(PopupAnimation), typeof(Age3PopoverControl));

        public static readonly DependencyProperty PopoverPageProperty = DependencyProperty.Register(
            "PopoverPage", typeof(PopupAnimation), typeof(Age3PopoverControl));

        public static readonly DependencyProperty IsPopoverOpenProperty = DependencyProperty.Register(
            "IsPopoverOpen", typeof(bool), typeof(Age3PopoverControl));
    }
}
