using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace aoe3wpfg
{
    public class Age3ResourceTimer : Shape
    {
        public float Completion
        {
            get { return (float)GetValue(CompletionProperty); }
            set { SetValue(CompletionProperty, value); }
        }

        public string TimerState
        {
            get { return (string)GetValue(TimerStateProperty); }
            set { SetValue(TimerStateProperty, value); }
        }

        public string DisplayState
        {
            get { return (string)GetValue(DisplayStateProperty); }
            set { SetValue(DisplayStateProperty, value); }
        }

        public static readonly DependencyProperty CompletionProperty = DependencyProperty.Register(
            "Completion", typeof(float), typeof(Age3ResourceTimer));
        public static readonly DependencyProperty TimerStateProperty = DependencyProperty.Register(
            "TimerState", typeof(string), typeof(Age3ResourceTimer));
        public static readonly DependencyProperty DisplayStateProperty = DependencyProperty.Register(
            "DisplayState", typeof(string), typeof(Age3ResourceTimer));

        protected override Geometry DefiningGeometry
        {
            get
            {
                var data = new RectangleGeometry(new Rect(0, 0, ActualWidth, ActualHeight));
                return data;
            }
        }
    }
}
