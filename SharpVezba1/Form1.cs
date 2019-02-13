using SharpVezba1.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpVezba1
{
    public partial class Form1 : Form
    {
        BusinessLogika biznisLogika = new BusinessLogika();
        public Form1()
        {
            InitializeComponent();

            BIntString[] predmeti = this.biznisLogika.getPredmetiInfo();
            this.comboBoxPredmeti.ValueMember = "Id";
            this.comboBoxPredmeti.DisplayMember = "Tekst";
            this.comboBoxPredmeti.DataSource = predmeti;
            this.comboBoxPredmeti.SelectedIndex = -1;
            this.comboBoxPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;

            ColumnHeader columnHeader = this.listViewPredmetIspit.Columns.Add("RB");
            columnHeader = this.listViewPredmetIspit.Columns.Add("Predmet");
            columnHeader = this.listViewPredmetIspit.Columns.Add("Godina");
            columnHeader.TextAlign = HorizontalAlignment.Center;
            columnHeader = this.listViewPredmetIspit.Columns.Add("Ispitni rok");
            columnHeader = this.listViewPredmetIspit.Columns.Add("Datum");
            this.listViewPredmetIspit.View = View.Details;
            this.listViewPredmetIspit.MultiSelect = false;
            this.listViewPredmetIspit.FullRowSelect = true;
        }

        private void buttonIspitSelect_Click(object sender, EventArgs e)
        {
            BIspit[] ispiti = this.biznisLogika.getIspitiKoristeSeRelacije();
            this.dataGridViewIspiti.DataSource = ispiti;
            if(this.dataGridViewIspiti.ColumnCount > 0)
            {
                this.dataGridViewIspiti.Columns[0].Visible = false;
            }
        }

        private void popuniListViewPredmetIspit(int idPredmet)
        {
            BIspit[] ispitiIzPredmeta =
                this.biznisLogika.getIspiti(idPredmet);
            this.listViewPredmetIspit.BeginUpdate();
            this.listViewPredmetIspit.Items.Clear();
            for(int i=0;i<ispitiIzPredmeta.Length;i++)
            {
                BIspit ispit = ispitiIzPredmeta[i];
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Tag = ispit;
                listViewItem.Text = (i + 1).ToString();
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = ispit.PredmetNaziv;
                listViewItem.SubItems.Add(subItem);
                subItem = new ListViewItem.ListViewSubItem(listViewItem, ispit.Godina.ToString());
                listViewItem.SubItems.Add(subItem);
                subItem = new ListViewItem.ListViewSubItem(listViewItem, ispit.IspitniRokNaziv);
                listViewItem.SubItems.Add(subItem);
                subItem = new ListViewItem.ListViewSubItem(listViewItem, ispit.IspitDatum.ToString());
                listViewItem.SubItems.Add(subItem);
                this.listViewPredmetIspit.Items.Add(listViewItem);
            }
            this.listViewPredmetIspit.EndUpdate();
        }

        private void comboBoxPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPredmet = this.comboBoxPredmeti.SelectedIndex + 1;
            object obj = this.comboBoxPredmeti.SelectedValue;
            if(obj!=null)
            {
                this.popuniListViewPredmetIspit(idPredmet);
            }
        }

        private void buttonStudentInsert_Click(object sender, EventArgs e)
        {
            this.biznisLogika.dodajStudenta("Vuk", "Vucko", 7, 2016);
        }

        private void listViewPredmetIspit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listViewPredmetIspit.SelectedItems.Count==0)
            {
                return;
            }
            ListViewItem item = this.listViewPredmetIspit.SelectedItems[0];
            BIspit ispit = item.Tag as BIspit;
            if(ispit == null)
            {
                return;
            }
            int idIspit = ispit.IdIspit;
            List<BStudentIspit> lista = this.biznisLogika.getStudentNaIspitu(idIspit);
            this.dataGridViewRazno.DataSource = lista;
        }

        private void buttonStudentSelect_Click(object sender, EventArgs e)
        {
            BStudent[] studenti = this.biznisLogika.getStudent();
            this.dataGridViewRazno.DataSource = studenti;
        }

        private void dataGridViewIspiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        
    }
}
