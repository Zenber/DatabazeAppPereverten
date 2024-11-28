using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabazeAppPereverten.data;

namespace DatabazeAppPereverten
{
    public partial class EditForm : Form
    {
        private Auto auto { get; set; }
        public static EditForm instance;

        public EditForm()
        {
            InitializeComponent();
            instance = this;
        }
        public EditForm(InterfaceAuta iauto)
        {
            InitializeComponent();
            instance = this;
            auto = (Auto)iauto;
            FillEditFormat(auto);
        }
        //Bere na vstup Auto a zadava data do Form
        private void FillEditFormat(Auto auto) {
            switch (auto.znacka)
            {
                case data.Znacka.Audi:
                    ZnackaComboBox.SelectedItem = "Audi";
                    Console.WriteLine("Funguje");
                    Console.WriteLine("Funguje");
                    Console.WriteLine("Funguje");
                    Console.WriteLine("Funguje");
                    Console.WriteLine("Funguje");
                    break;
                case data.Znacka.BMW:
                    ZnackaComboBox.SelectedItem = "BMW";
                    break;
                case data.Znacka.Opel:
                    ZnackaComboBox.SelectedItem = "Opel";
                    break;
                case data.Znacka.Reno:
                    ZnackaComboBox.SelectedItem = "Reno";
                    break;
                case data.Znacka.Skoda:
                    ZnackaComboBox.SelectedItem = "Skoda";
                    break;
            }

            switch (auto.palivo)
            {
                case data.Palivo.Disel:
                    PalivoComboBox.SelectedItem = "Disel";
                    break;
                case data.Palivo.Benzin:
                    PalivoComboBox.SelectedItem = "Benzin";
                    break;
            }

            switch (auto.jeSpravny)
            {
                case true:
                    SpravneAutoAnoComboBox.Checked = true;
                    break;
                case false:
                    SpravneAutoNeComboBox.Checked = true;
                    break;
            }

            switch (auto.jeNastartovany)
            {
                case true:
                    NastartovaneAutoAnoComboBox.Checked = true;
                    break;
                case false:
                    NastartovaneAutoNeComboBox.Checked = true;
                    break;
            }
        }
        // *** Delsi 4 metody overuji jestli CheckBoxy nejsoy zapnuty zaroven
        private void SpravneAnoClick(object sender, EventArgs e)
        {
            SpravneAutoNeComboBox.Checked = !SpravneAutoAnoComboBox.Checked;
        }

        private void SpravneNeClick(object sender, EventArgs e)
        {
            SpravneAutoAnoComboBox.Checked = !SpravneAutoNeComboBox.Checked;
            if (NastartovaneAutoAnoComboBox.Checked) 
                NastartovaneAutoAnoComboBox.Checked = false;
            
        }

        private void NastartovaneAnoClick(object sender, EventArgs e)
        {
            if (SpravneAutoNeComboBox.Checked)
            {
                MessageBox.Show("Auto neni spravne");
                NastartovaneAutoAnoComboBox.Checked = false;
            }
            else {
                NastartovaneAutoNeComboBox.Checked = !NastartovaneAutoAnoComboBox.Checked;
            }
            
        }

        private void NastartovaneNeClick(object sender, EventArgs e)
        {
            NastartovaneAutoAnoComboBox.Checked = !NastartovaneAutoNeComboBox.Checked;
        }
        // ***
        private void ZrusEditovaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UlozAutoButton_Click(object sender, EventArgs e)
        {
            Auto auto = (Auto) FromBoxToAuto();
            //pridava novy prvek
            Form1.instance.listView.Items.Add(Form1.instance.AutaToListViewItem(auto));
            //Odebira stary prvek
            Form1.instance.listView.Items.Remove(Form1.instance.listView.SelectedItems[0]);

            this.Close();
        }

        private InterfaceAuta FromBoxToAuto() {
            Znacka znacka = data.Znacka.Audi;
            Palivo palivo = data.Palivo.Disel;
            bool jeSpravne = true;
            bool jeNastartovane = false;

            switch (ZnackaComboBox.SelectedItem)
            {
                case "Audi":
                    znacka = data.Znacka.Audi;
                    break;
                case "BMW":
                    znacka = data.Znacka.BMW;
                    break;
                case "Opel":
                    znacka = data.Znacka.Opel;
                    break;
                case "Reno":
                    znacka = data.Znacka.Reno;
                    break;
                case "Skoda":
                    znacka = data.Znacka.Skoda;
                    break;
            }
            switch (PalivoComboBox.SelectedItem)
            {
                case "Disel":
                    palivo = data.Palivo.Disel;
                    break;
                case "Benzin":
                    palivo = data.Palivo.Benzin;
                    break;

            }
            if (SpravneAutoAnoComboBox.Checked)
            {
                jeSpravne = SpravneAutoAnoComboBox.Checked;
            }
            else if (SpravneAutoNeComboBox.Checked)
            {
                jeSpravne = SpravneAutoNeComboBox.Checked;
            }
            else
            {
                MessageBox.Show("Nevybrana moznost je-li spravne auto.");
            }

            if (NastartovaneAutoAnoComboBox.Checked)
            {
                jeNastartovane = NastartovaneAutoAnoComboBox.Checked;
            }
            else if (NastartovaneAutoNeComboBox.Checked)
            {
                jeNastartovane = NastartovaneAutoNeComboBox.Checked;
            }
            else
            {
                MessageBox.Show("Nevybrana moznost je-li auto nastartovane.");
            }

            return new Auto(palivo, znacka, jeSpravne, jeNastartovane);
        }
    }
}
