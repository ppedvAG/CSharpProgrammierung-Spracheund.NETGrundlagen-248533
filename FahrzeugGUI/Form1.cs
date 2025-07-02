using FahrzeugLib;
using Lab9_CountTypes.Fahrzeugpark;

namespace FahrzeugGUI
{
    public partial class Form1 : Form
    {
        private Generator Generator = new Generator();

        //Liste zum Speichern der erstellten Fahrzeuge
        public List<FahrzeugBase> Fahrzeugliste { get; set; }

        //Konstruktor zur Initalisierung des Fensters
        public Form1()
        {
            //Erstellung der im Designer definierten Elemente
            InitializeComponent();
            //Initialisierung der Liste
            this.Fahrzeugliste = new List<FahrzeugBase>();
        }

        #region EventHandler-Methoden

        //Event-Handler für das Click-Event des Menüeintrags 'Beenden'
        private void MeI_Beenden_Click(object sender, EventArgs e)
        {
            //Nachfrage per MessageBox
            string dialogText = "Möchtest du wirklich beenden?\nNicht gespeicherte Änderungen werden verworfen.";
            DialogResult result = MessageBox.Show(dialogText, "Programm schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Testen des in MessageBox geklickten Buttons
            if (result == DialogResult.Yes)
                //Schließen des Fensters
                this.Close();
        }

        //Events-Handler des 'Neu'-Buttons
        private void Btn_Neu_Click(object sender, EventArgs e)
        {
            //Erstellen eines neuen Fahrzeuges und Einfügen in die Liste
            this.Fahrzeugliste.Add(Generator.GenerateFahrzeug());
            //Aktualisierung der ListBox
            this.UpdateGui();
        }

        //Event-Handler des 'Löschen'-Buttons
        private void Btn_Löschen_Click(object sender, EventArgs e)
        {
            //Prüfung, ob ein Eintrag ausgewählt ist
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //Löschen des in der ListBox markierten Items aus der Personenliste
                LöscheFz(Lbx_Fahrzeuge.SelectedItem as FahrzeugBase);

            //Aktualisierung der ListBox
            UpdateGui();
        }

        //EventHandler der ListBox (bei Auswahl-Veränderung)
        private void Lbx_Fahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Prüfun, ob eine Auswahl in ListBox besteht
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //Anzeige der Info()-Methode in Label
                Lbl_Info.Text = (Lbx_Fahrzeuge.SelectedItem as FahrzeugBase).Info();
        }
        #endregion

        #region zusätzliche Methoden

        //Methode zum Löschen von Fahrzeugen
        private void LöscheFz(FahrzeugBase fz)
        {
            Fahrzeugliste.Remove(fz);
        }

        //Methode zur Synchronisation von ListBox.Items und Fahrzeugliste
        private void UpdateGui()
        {
            //Löschend des ListBox-Inhalts
            this.Lbx_Fahrzeuge.Items.Clear();

            //Neubefüllung der ListBox anhand der Liste
            foreach (var item in this.Fahrzeugliste)
            {
                this.Lbx_Fahrzeuge.Items.Add(item);
            }
        }
        #endregion
    }
}
