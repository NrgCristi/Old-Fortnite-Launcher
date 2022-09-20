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
using System.IO;

namespace Old_Fortnite_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string FNPath = PathTextBox.Text;
            string FNExePath = System.IO.Path.Combine(this.PathTextBox.Text, "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe");
            string FNExeName = "FortniteClient-Win64-Shipping.exe";
            string LaunchArgs = "-AUTH_LOGIN=, -AUTH_PASSWORD=, -AUTH_TYPE=exchangecode" + "-noeac -fromfl=be -fltoken=h1h4370717422124b232eFac -epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal";
            System.Diagnostics.Process.Start(FNExeName, LaunchArgs);
        }
    }
}
