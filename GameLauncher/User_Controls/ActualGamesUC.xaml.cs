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

namespace GameLauncher.User_Controls
{
    /// <summary>
    /// Interaction logic for ActualGamesUC.xaml
    /// </summary>
    public partial class ActualGamesUC : UserControl
    {
        public ActualGamesUC()
        {
            InitializeComponent();
        }
        public ImageSource ImageGame
        {
            get { return (ImageSource)GetValue(ImageGameProperty); }
            set { SetValue(ImageGameProperty,value); }
        }
        public static readonly DependencyProperty ImageGameProperty = DependencyProperty.Register("ImageGame", typeof(ImageSource), typeof(ActualGamesUC));
        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
        public static readonly DependencyProperty PriceProperty = DependencyProperty.Register("Price", typeof(string), typeof(ActualGamesUC));
    }
}
