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
using Model;

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private List<Contact> contacts = new List<Contact>()
        {
            new Contact("Charlier","Isabelle","isabelle.charlier@henallux.be"),
            new Contact("Scholtes","Samuel","samuel.scholtes@henallux.be")
        };
        public MainWindow()
        {
            InitializeComponent();
            DataContext = contacts;
        }
    }
}
