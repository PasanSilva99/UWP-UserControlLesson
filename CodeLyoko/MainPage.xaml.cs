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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CodeLyoko
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        lyHandler lyHandler = new lyHandler();

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            lyHandler.AddMem(new lyWor { lyName = "Jeramy", Accent = Color.FromArgb((byte)255, (byte)84, (byte)152, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)64, (byte)115, (byte)120), img = "Assets/Jeramy.png" });
            lyHandler.AddMem(new lyWor { lyName = "Aelita", Accent = Color.FromArgb((byte)255, (byte)153, (byte)41, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)77, (byte)20, (byte)79), img = "Assets/Aelita.jpg" });
            lyHandler.AddMem(new lyWor { lyName = "Jeramy", Accent = Color.FromArgb((byte)255, (byte)84, (byte)152, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)64, (byte)115, (byte)120), img = "Assets/Jeramy.png" });
            lyHandler.AddMem(new lyWor { lyName = "Aelita", Accent = Color.FromArgb((byte)255, (byte)153, (byte)41, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)77, (byte)20, (byte)79), img = "Assets/Aelita.jpg" });
            lyHandler.AddMem(new lyWor { lyName = "Jeramy", Accent = Color.FromArgb((byte)255, (byte)84, (byte)152, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)64, (byte)115, (byte)120), img = "Assets/Jeramy.png" });
            lyHandler.AddMem(new lyWor { lyName = "Aelita", Accent = Color.FromArgb((byte)255, (byte)153, (byte)41, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)77, (byte)20, (byte)79), img = "Assets/Aelita.jpg" });
            lyHandler.AddMem(new lyWor { lyName = "Jeramy", Accent = Color.FromArgb((byte)255, (byte)84, (byte)152, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)64, (byte)115, (byte)120), img = "Assets/Jeramy.png" });
            lyHandler.AddMem(new lyWor { lyName = "Aelita", Accent = Color.FromArgb((byte)255, (byte)153, (byte)41, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)77, (byte)20, (byte)79), img = "Assets/Aelita.jpg" });
            lyHandler.AddMem(new lyWor { lyName = "Jeramy", Accent = Color.FromArgb((byte)255, (byte)84, (byte)152, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)64, (byte)115, (byte)120), img = "Assets/Jeramy.png" });
            lyHandler.AddMem(new lyWor { lyName = "Aelita", Accent = Color.FromArgb((byte)255, (byte)153, (byte)41, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)77, (byte)20, (byte)79), img = "Assets/Aelita.jpg" });
            lyHandler.AddMem(new lyWor { lyName = "Jeramy", Accent = Color.FromArgb((byte)255, (byte)84, (byte)152, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)64, (byte)115, (byte)120), img = "Assets/Jeramy.png" });
            lyHandler.AddMem(new lyWor { lyName = "Aelita", Accent = Color.FromArgb((byte)255, (byte)153, (byte)41, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)77, (byte)20, (byte)79), img = "Assets/Aelita.jpg" });
            lyHandler.AddMem(new lyWor { lyName = "Jeramy", Accent = Color.FromArgb((byte)255, (byte)84, (byte)152, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)64, (byte)115, (byte)120), img = "Assets/Jeramy.png" });
            lyHandler.AddMem(new lyWor { lyName = "Aelita", Accent = Color.FromArgb((byte)255, (byte)153, (byte)41, (byte)158), Backgound = Color.FromArgb((byte)255, (byte)77, (byte)20, (byte)79), img = "Assets/Aelita.jpg" });

            foreach (lyWor w in lyHandler.getAll())
            {
                BinINterface iNterface = new BinINterface();
                iNterface.lyName = w.lyName;
                iNterface.CardBG = w.Backgound;
                iNterface.CardBorder = w.Accent;
                iNterface.CardShadow = w.Accent;
                iNterface.TextColor = Color.FromArgb((byte)255, (byte)255, (byte)255, (byte)255);
                iNterface.CardImage = w.img;
                iNterface.Width = 200.0;
                iNterface.Height = 300.0;

                stack_profile.Children.Add(iNterface);
            }

        }
    }

    public class lyHandler
    {
        List<lyWor> lyWors = new List<lyWor>();

        public List<lyWor> getAll()
        {
            if(lyWors.Count > 0)
            {
                return lyWors;
            }

            return null;
        }

        public bool AddMem(lyWor wor)
        {
            try
            {
                lyWors.Add(wor);

                return true;
            }
            catch
            {
                return false;
            }
        }

    }

    public class lyWor
    {
        public String lyName { get; set; } = "";
        public String img { get; set; } = "";
        public Color Accent { get; set; } = Color.FromArgb((byte)255, (byte)255, (byte)255, (byte)255);
        public Color Backgound { get; set; } = Color.FromArgb((byte)255, (byte)195, (byte)195, (byte)195);
    }

}
