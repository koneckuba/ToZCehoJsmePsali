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
using WpfApp6.Okna;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zamestnanec> Zamestnanci{ get; set; }
        public MainWindow()
        {
            Zamestnanci = new();
            InitializeComponent();
            seznam.ItemsSource = Zamestnanci;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DialogPridat dialog = new(Zamestnanci);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();

        }
        private void Dialog_Closing(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = Zamestnanci;

        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            Zamestnanec? info = seznam?.SelectedItem as Zamestnanec ?? new Zamestnanec(-1, "Nenalezený","Neznámy",DateTime.Now);
            MessageBox.Show($"{info.Id} {info.Jmeno} {info.Prijmeni} {info.DatumNarozeni.ToShortDateString()}");
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

            Zamestnanec? hledany = seznam?.SelectedItem as Zamestnanec;
            if( hledany != null ) 
            {
            DialogEdit edit = new DialogEdit(hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Zamestnanec? hledany = seznam?.SelectedItem as Zamestnanec ?? new Zamestnanec(-1, "Nenalezený", "Neznámy", DateTime.Now);
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledany.Jmeno}? ", "Odebrat", MessageBoxButton.YesNo);
            if ( volba == MessageBoxResult.Yes )
            {
                Zamestnanci.Remove(hledany);
                seznam.ItemsSource = null;
                seznam.ItemsSource = Zamestnanci;
            }

        }
    }
}
