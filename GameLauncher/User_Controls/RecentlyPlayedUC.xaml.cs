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
    /// Interaction logic for RecentlyPlayedUC.xaml
    /// </summary>
    public partial class RecentlyPlayedUC : UserControl
    {
        public RecentlyPlayedUC()
        {
            InitializeComponent();
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(RecentlyPlayedUC));
        public string Progress
        {
            get { return (string)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }
        public static readonly DependencyProperty ProgressProperty = DependencyProperty.Register("Progress", typeof(string), typeof(RecentlyPlayedUC));
        public string ProgressB
        {
            get { return (string)GetValue(ProgressBProperty); }
            set { SetValue(ProgressBProperty, value); }
        }
        public static readonly DependencyProperty ProgressBProperty = DependencyProperty.Register("ProgressB", typeof(string), typeof(RecentlyPlayedUC));
        public ImageSource ImageGame
        {
            get { return (ImageSource)GetValue(ImageGameProperty); }
            set { SetValue(ImageGameProperty, value); }
        }
        public static readonly DependencyProperty ImageGameProperty = DependencyProperty.Register("ImageGame", typeof(ImageSource), typeof(RecentlyPlayedUC));

    }
}
