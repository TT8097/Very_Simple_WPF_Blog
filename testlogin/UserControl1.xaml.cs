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
using WpfBlog.testblog;

namespace WpfBlog.testlogin
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        string save = "";
        public UserControl1()
        {
            InitializeComponent();
            
        }
        public UserControl1(string save)
        {
            InitializeComponent();
            this.save = save;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = (Window)Parent;
            window.Content = new BlogTest(imie.Text, nazwisko.Text, wiek.Text, pseudonim.Text, save);
        }
    }
}
