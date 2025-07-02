using FahrzeugLib;
using Lab9_CountTypes.Fahrzeugpark;
using System.Collections.ObjectModel;
using System.Windows;

namespace FahrzeugWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Generator Generator = new Generator();

        public ObservableCollection<FahrzeugBase> Fahrzeuge { get; } = new ObservableCollection<FahrzeugBase>();

        public MainWindow()
        {
            InitializeComponent();

            // DataContext wird auf die eigene Instanz gesetzt
            DataContext = this;

            foreach (FahrzeugBase f in Generator.GetFahrzeuge(5))
            {
                Fahrzeuge.Add(f);
            }
        }

        private void btnAddFahrzeug_Click(object sender, RoutedEventArgs e)
        {
            Fahrzeuge.Add(Generator.GenerateFahrzeug());
        }

        private void btnDeleteFahrzeug_Click(object sender, RoutedEventArgs e)
        {
            if (lstFahrzeuge.SelectedIndex > -1)
            {
                Fahrzeuge.RemoveAt(lstFahrzeuge.SelectedIndex);
            }
        }

        private void lstFahrzeuge_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstFahrzeuge.SelectedIndex > -1)
            {
                txtPreis.Text = Fahrzeuge[lstFahrzeuge.SelectedIndex].Preis.ToString() + " Euro";
            } 
            else
            {
                txtPreis.Text = "";
            }
        }
    }
}