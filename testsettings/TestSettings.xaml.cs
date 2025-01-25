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

namespace WpfBlog.testsettings
{
    /// <summary>
    /// Interaction logic for TestSettings.xaml
    /// </summary>
    public partial class TestSettings : UserControl
    {
        String save;
        public TestSettings(String imie, String nazwisko, String wiek, String nick, String save)
        {
            InitializeComponent();
            this.imie.Text = imie;
            this.nazwisko.Text = nazwisko;
            this.wiek.Text = wiek;
            this.pseudonim.Text = nick;
            this.save = save;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = (Window)Parent;
            window.Content = new BlogTest(imie.Text, nazwisko.Text, wiek.Text, pseudonim.Text, save);
        }
    }
}
