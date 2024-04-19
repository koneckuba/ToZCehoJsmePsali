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
using System.Windows.Shapes;

namespace WpfApp6.Okna
{
    /// <summary>
    /// Interakční logika pro DialogEdit.xaml
    /// </summary>
    public partial class DialogEdit : Window
    {
        public Zamestnanec Z { get; set; }
        public DialogEdit(Zamestnanec z)
        {
            InitializeComponent();
            Z = z;
            DataContext = Z;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Z.Jmeno = jmenoTextBox.Text;
            Z.Prijmeni = prijmeniTextBox.Text;
            Z.DatumNarozeni = DateTime.Parse(datePicker.Text);
            this.Close();

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
