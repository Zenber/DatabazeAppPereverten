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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DatabazeAppPereverten
{

    public partial class Form1 : Form
    {
        public static int counterID = 1;
        //Vytvorim instance ktera pomuze pohybovat datem mezi formy
        public static Form1 instance;
        public System.Windows.Forms.ListView listView;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            listView = AutaList;
            this.Text = "Evidence Aut";
        }

        private void AutaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Generuje nahodna auta a pridava je do ListView
        private void NactiButton_Click(object sender, EventArgs e)
        {
            List<Auto> generovaneAuta = Auto.GenereteAuta();

            foreach (Auto auto in generovaneAuta)
            {
                ListViewItem viewItem = AutaToListViewItem(auto);
                counterID++;
                AutaList.Items.Add(viewItem);
            }
        }
        //
        private void SmazSeznamButton_Click(object sender, EventArgs e)
        {
            AutaList.Items.Clear();
            counterID = 1;
        }
        //Svaze vsechna vybrana auta
        private async void SmazButton_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem eachItem in AutaList.SelectedItems)
            {
                AutaList.Items.Remove(eachItem);
            }
        }
        //Veme si vybrane auto, otevre Modalni okno kde muzeme upravit auto
        private void UpravButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            try
            {
                item = AutaList.SelectedItems[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Auto auto = ListWiewItemToAuta(item);

            EditForm editForm = new EditForm(auto);
            editForm.ShowDialog();
        }
        //
        private void NastartujButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            try
            {
                item = AutaList.SelectedItems[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (item.SubItems[3].Text == "Ano")
            {
                item.SubItems[4].Text = "Ano";
            }
            else
            {
                MessageBox.Show("Neni sptavne");
            }


        }

        private void ZastavButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            try
            {
                item = AutaList.SelectedItems[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (item.SubItems[3].Text == "Ano")
            {
                item.SubItems[4].Text = "Ne";
            }
            else
            {
                MessageBox.Show("Neni sptavne");
            }
        }

        private void OpravButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            try
            {
                item = AutaList.SelectedItems[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            item.SubItems[3].Text = "Ano";
        }

        //Transfer ListViewItem to Auto
        internal Auto ListWiewItemToAuta(ListViewItem item)
        {
            Znacka znacka = data.Znacka.Audi;
            Palivo palivo = data.Palivo.Disel;
            bool jeSpravne = true;
            bool jeNastartovane = false;

            switch (item.SubItems[1].Text)
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
            switch (item.SubItems[2].Text)
            {
                case "Disel":
                    palivo = data.Palivo.Disel;
                    break;
                case "Benzin":
                    palivo = data.Palivo.Benzin;
                    break;

            }
            switch (item.SubItems[3].Text)
            {
                case "Ano":
                    jeSpravne = true;
                    break;
                case "Ne":
                    jeSpravne = false;
                    break;
            }

            switch (item.SubItems[4].Text)
            {
                case "Ano":
                    jeNastartovane = true;
                    break;
                case "Ne":
                    jeNastartovane = false;
                    break;
            }

            return new Auto(palivo, znacka, jeSpravne, jeNastartovane);

        }

        //Transfer Auto to ListViewItem
        internal ListViewItem AutaToListViewItem(Auto auto)
        {

            ListViewItem viewItem = new ListViewItem();

            string znacka = "";
            string palivo = "";
            string jeSpravne = "";
            string jeNastartovane = "";


            switch (auto.znacka)
            {
                case data.Znacka.Audi:
                    znacka = "Audi";
                    break;
                case data.Znacka.BMW:
                    znacka = "BMW";
                    break;
                case data.Znacka.Opel:
                    znacka = "Opel";
                    break;
                case data.Znacka.Reno:
                    znacka = "Reno";
                    break;
                case data.Znacka.Skoda:
                    znacka = "Skoda";
                    break;
            }

            switch (auto.palivo)
            {
                case data.Palivo.Disel:
                    palivo = "Disel";
                    break;
                case data.Palivo.Benzin:
                    palivo = "Benzin";
                    break;
            }

            switch (auto.jeSpravny)
            {
                case true:
                    jeSpravne = "Ano";
                    break;
                case false:
                    jeSpravne = "Ne";
                    break;
            }

            switch (auto.jeNastartovany)
            {
                case true:
                    jeNastartovane = "Ano";
                    break;
                case false:
                    jeNastartovane = "Ne";
                    break;
            }



            viewItem.Text = $"{counterID}";
            viewItem.SubItems.Add(znacka);
            viewItem.SubItems.Add(palivo);
            viewItem.SubItems.Add(jeSpravne);
            viewItem.SubItems.Add(jeNastartovane);



            return viewItem;
        }


    }
}
