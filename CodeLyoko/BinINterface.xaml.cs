using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace CodeLyoko
{
    public sealed partial class BinINterface : UserControl
    {
        //Shadow
        private Color _shadow;

        public Color CardShadow
        {
            get
            {
                return _shadow;
            }
            set
            {
                _shadow = value;
                shadow.Color = _shadow;
            }
        }

        //Border
        private Color _border;

        public Color CardBorder
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
                AcrylicBrush brush = new AcrylicBrush();
                brush.TintColor = _border;
                border.Background = brush;
                btn_call.Background = brush;

            }
        }

        //BG
        private Color _bg;

        public Color CardBG
        {
            get
            {
                return _bg;
            }
            set
            {
                _bg = value;
                bg.Background = new SolidColorBrush(_bg);
            }
        }

        //TextColor
        private Color _TextColor;

        public Color TextColor
        {
            get
            {
                return _TextColor;
            }
            set
            {
                _TextColor = value;
                
            }
        }


        //Text Name
        private String _lyName = "";

        public String lyName
        {
            get
            {
                return _lyName;
            }
            set
            {
                _lyName = value;
                LyName.Text = _lyName;
            }
        }

        //Set Image
        private String _Image;

        public String CardImage
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;
                card_image.Source = new BitmapImage(new Uri(card_image.BaseUri, _Image));
            }
        }

        public BinINterface()
        {
            this.InitializeComponent();
        }
    }
}
