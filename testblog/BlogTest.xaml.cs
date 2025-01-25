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

using WpfBlog.testlogin;

namespace WpfBlog.testblog
{
    /// <summary>
    /// Interaction logic for BlogTest.xaml
    /// </summary>
    public partial class BlogTest : UserControl
    {
        private String imie;
        private String nazwisko;
        private String wiek;
        private String nick;
        public BlogTest(String imie, String nazwisko, String wiek, String nick)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.nick = nick;
            InitializeComponent();

            nickAndwiek.Content = $"{imie},{nazwisko} {wiek}";
        }


        public BlogTest(String imie, String nazwisko, String wiek, String nick, String save)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.nick = nick;

            InitializeComponent();
            this.BlogBox.Text = save;
            nickAndwiek.Content = $"{imie},{nazwisko} {wiek}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BlogBox.Text += $"\n{nick}\n{DateTime.UtcNow}\n{newTextForBlog.Text}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = (Window)Parent;
            window.Content = new testsettings.TestSettings(imie, nazwisko, wiek, nick, BlogBox.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var window = (Window)Parent;
            window.Content  = new UserControl1(BlogBox.Text);
        }
    }
}
