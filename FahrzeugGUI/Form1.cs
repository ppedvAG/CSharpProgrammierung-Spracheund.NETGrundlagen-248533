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

        //Event-Handler f�r das Click-Event des Men�eintrags 'Beenden'
        private void MeI_Beenden_Click(object sender, EventArgs e)
        {
            //Nachfrage per MessageBox
            string dialogText = "M�chtest du wirklich beenden?\nNicht gespeicherte �nderungen werden verworfen.";
            DialogResult result = MessageBox.Show(dialogText, "Programm schlie�en", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Testen des in MessageBox geklickten Buttons
            if (result == DialogResult.Yes)
                //Schlie�en des Fensters
                this.Close();
        }

        //Events-Handler des 'Neu'-Buttons
        private void Btn_Neu_Click(object sender, EventArgs e)
        {
            //Erstellen eines neuen Fahrzeuges und Einf�gen in die Liste
            this.Fahrzeugliste.Add(Generator.GenerateFahrzeug());
            //Aktualisierung der ListBox
            this.UpdateGui();
        }

        //Event-Handler des 'L�schen'-Buttons
        private void Btn_L�schen_Click(object sender, EventArgs e)
        {
            //Pr�fung, ob ein Eintrag ausgew�hlt ist
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //L�schen des in der ListBox markierten Items aus der Personenliste
                L�scheFz(Lbx_Fahrzeuge.SelectedItem as FahrzeugBase);

            //Aktualisierung der ListBox
            UpdateGui();
        }

        //EventHandler der ListBox (bei Auswahl-Ver�nderung)
        private void Lbx_Fahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pr�fun, ob eine Auswahl in ListBox besteht
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //Anzeige der Info()-Methode in Label
                Lbl_Info.Text = (Lbx_Fahrzeuge.SelectedItem as FahrzeugBase).Info();
        }
        #endregion

        #region zus�tzliche Methoden

        //Methode zum L�schen von Fahrzeugen
        private void L�scheFz(FahrzeugBase fz)
        {
            Fahrzeugliste.Remove(fz);
        }

        //Methode zur Synchronisation von ListBox.Items und Fahrzeugliste
        private void UpdateGui()
        {
            //L�schend des ListBox-Inhalts
            this.Lbx_Fahrzeuge.Items.Clear();

            //Neubef�llung der ListBox anhand der Liste
            foreach (var item in this.Fahrzeugliste)
            {
                this.Lbx_Fahrzeuge.Items.Add(item);
            }
        }
        #endregion
    }
}
