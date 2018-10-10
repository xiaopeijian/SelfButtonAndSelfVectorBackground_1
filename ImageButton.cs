using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SelfButtonAndSelfVectorBackground_1
{
    class ImageButton : System.Windows.Controls.Button
    {

        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        public static readonly DependencyProperty DefaultImageProperty =
                                                        DependencyProperty.Register("DefaultImage",
                                                                                    typeof(Canvas),
                                                                                    typeof(ImageButton),
                                                                                    new FrameworkPropertyMetadata());
        public static readonly DependencyProperty HoverImageProperty =
                                                        DependencyProperty.Register("HoverImage",
                                                                                    typeof(Canvas),
                                                                                    typeof(ImageButton),
                                                                                    new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty PressedImageProperty =
                                                        DependencyProperty.Register("PressedImage",
                                                                                    typeof(Canvas),
                                                                                    typeof(ImageButton),
                                                                                    new FrameworkPropertyMetadata(null));
        public static readonly DependencyProperty DisabledImageProperty =
                                                        DependencyProperty.Register("DisabledImage",
                                                                                    typeof(Canvas),
                                                                                    typeof(ImageButton),
                                                                                    new FrameworkPropertyMetadata(null));
        public Canvas DefaultImage
        {
            get { return (Canvas)GetValue(DefaultImageProperty); }
            set { SetValue(DefaultImageProperty, value); }
        }

        public Canvas HoverImage
        {
            get { return (Canvas)FindResource(GetValue(HoverImageProperty)); }
            set { SetValue(HoverImageProperty, value); }
        }

        public Canvas PressedImage
        {
            get { return (Canvas)GetValue(PressedImageProperty); }
            set { SetValue(PressedImageProperty, value); }
        }

        public Canvas DisabledImage
        {
            get { return (Canvas)GetValue(DisabledImageProperty); }
            set { SetValue(DisabledImageProperty, value); }
        }
    }
}
