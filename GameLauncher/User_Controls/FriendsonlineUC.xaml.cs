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
    /// Interaction logic for FriendsonlineUC.xaml
    /// </summary>
    public partial class FriendsonlineUC : UserControl
    {
        public FriendsonlineUC()
        {
            InitializeComponent();
        }
        public string Nick
        {
            get { return (string)GetValue(NickProperty); }
            set { SetValue(NickProperty, value); }
        }
        public static readonly DependencyProperty NickProperty = DependencyProperty.Register("Nick", typeof(string), typeof(FriendsonlineUC));
        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }
        public static readonly DependencyProperty StatusProperty = DependencyProperty.Register("Status", typeof(string), typeof(FriendsonlineUC));
        public string NameGame
        {
            get { return (string)GetValue(NameGameProperty); }
            set { SetValue(NameGameProperty, value); }
        }
        public static readonly DependencyProperty NameGameProperty = DependencyProperty.Register("NameGame", typeof(string), typeof(FriendsonlineUC));
        public ImageSource ProfilePicture
        {
            get { return (ImageSource)GetValue(ProfilePictureProperty); }
            set { SetValue(ProfilePictureProperty, value); }
        }
        public static readonly DependencyProperty ProfilePictureProperty = DependencyProperty.Register("ProfilePicture", typeof(ImageSource), typeof(FriendsonlineUC));
    }
}
