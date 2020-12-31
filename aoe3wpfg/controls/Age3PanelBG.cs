using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace aoe3wpfg
{
    public class Age3PanelBG : Shape
    {
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
