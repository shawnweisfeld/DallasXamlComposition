using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DallasXAML.Composition.Controls
{
    public class ImageButton : Button
    {
        public static DependencyProperty ImageProperty = DependencyProperty.Register(
            "Image", typeof(FrameworkElement), typeof(ImageButton));

        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        public FrameworkElement Image
        {
            get { return (FrameworkElement)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
    }
}
