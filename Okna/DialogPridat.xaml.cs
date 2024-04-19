using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp6.Okna
{
    /// <summary>
    /// Interakční logika pro DialogPridat.xaml
    /// </summary>
    public partial class DialogPridat : Window
    {
        List<Zamestnanec> _zamestnanci;
        
        public DialogPridat(List<Zamestnanec> zamestnanci)
        {
            InitializeComponent();
            _zamestnanci = zamestnanci;
        }

        private int VytvorId() => _zamestnanci.Count + 1;
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string jmeno = jmenoTextBox.Text;
            string prijmeni = prijmeniTextBox.Text;
            DateTime narozeni = DateTime.Parse(datePicker.Text);
            Zamestnanec Novy = new Zamestnanec(VytvorId() ,jmeno, prijmeni, narozeni);
            _zamestnanci.Add(Novy);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
