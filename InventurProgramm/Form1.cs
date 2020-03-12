using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventurProgramm
{
    public partial class Form1 : Form
    {
        private Inventar inv;
        public Form1()
        {
            InitializeComponent();
            this.dtpKaufdatum.Format = DateTimePickerFormat.Custom;
            this.dtpKaufdatum.CustomFormat = "dd/MM/yyyy";
            inv = new Inventar();
            setupListView(lvAllItems);
        }

        private void setupListView(ListView lv)
        {
            //set listview into details mode
            lv.View = View.Details;
            //set up the columns
            lv.Columns.Add("Typ");
            lv.Columns.Add("Bezeichnung");
            lv.Columns.Add("Hersteller");
            lv.Columns.Add("Seriennummer");
            lv.Columns.Add("Kaufdatum");
            lv.Columns.Add("Inventurnummer");
            //hübschere ansicht
            lv.GridLines = true;
            lv.FullRowSelect = true;

            //colum width to fit the text
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            this.txtTyp.Text = "";
            this.txtBezeichnung.Text = "";
            this.txtHersteller.Text = "";
            this.txtSeriennummer.Text = "";
            this.dtpKaufdatum.Value = DateTime.Today;
        }

        private void populateListView(ListView lv, List<Geraet> items)
        {
            //check if list<> is empty
            if (!items.Any())
            {
                return;
            }

            //clear damit die liste wenn neues item kommt sich nicht vervielfacht
            lv.Items.Clear();

            foreach(Geraet g in items)
            {
                ListViewItem item = new ListViewItem(g.getTyp());
                item.SubItems.Add(g.getBezeichnung());
                item.SubItems.Add(g.getHersteller());
                item.SubItems.Add(g.getSeriennummer());
                item.SubItems.Add(g.getKaufdatum().ToString());
                item.SubItems.Add(g.getInventurnummer());
                lv.Items.Add(item);
            }

            //column width to fix the text
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //validation .. kaufdatum wird nicht gecheckt weil kp wie man datetime validiert
            if (string.IsNullOrWhiteSpace(this.txtTyp.Text) || string.IsNullOrWhiteSpace(this.txtBezeichnung.Text) || string.IsNullOrWhiteSpace(this.txtHersteller.Text)
                || string.IsNullOrWhiteSpace(this.txtSeriennummer.Text))
            {
                MessageBox.Show("Es müssen alle Felder ausgefüllt werden", "Ein Fehler ist aufgetreten du Lappen");
                return;
            }

            Geraet geraet = new Geraet();
            geraet.setTyp(this.txtTyp.Text);
            geraet.setBezeichnung(this.txtBezeichnung.Text);
            geraet.setHersteller(this.txtHersteller.Text);
            geraet.setSeriennummer(this.txtSeriennummer.Text);
            geraet.setKaufdatum(this.dtpKaufdatum.Value);
            
            MessageBox.Show("Das Gerät wurde erfolgreich in das Inventar hinzugefügt!", "Gerät wurde hinzugefügt");
            resetForm();
            this.inv.addItem(geraet);
            populateListView(this.lvAllItems, this.inv.getAllItems());
        }

        private void lvAllItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dictionary damit wir "benamte" array indexe haben 
            Dictionary<string, string> selectedProps = new Dictionary<string, string>();

            ListView.SelectedListViewItemCollection selectedRow = this.lvAllItems.SelectedItems;
            foreach(ListViewItem item in selectedRow)
            {
                selectedProps["typ"] = item.SubItems[0].Text;
                selectedProps["bezeichnung"] = item.SubItems[1].Text;
                selectedProps["hersteller"] = item.SubItems[2].Text;
                selectedProps["seriennummer"] = item.SubItems[3].Text;
                selectedProps["kaufdatum"] = item.SubItems[4].Text;
                selectedProps["inventurnummer"] = item.SubItems[5].Text;

            }
            this.txtEditTyp.Text = selectedProps["typ"];
            this.txtEditBezeichnung.Text = selectedProps["bezeichnung"];
            this.txtEditHersteller.Text = selectedProps["hersteller"];
            this.txtEditSeriennummer.Text = selectedProps["seriennummer"];
            this.txtEditKaufdatum.Text = selectedProps["kaufdatum"];
            this.txtEditInventurnummer.Text = selectedProps["inventurnummer"];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            lockEditField();
            Geraet old_Geraet = this.inv.getAllItems().FirstOrDefault(x => x.getInventurnummer() == this.txtEditInventurnummer.Text);

            Geraet new_Geraet = new Geraet();
            new_Geraet.setTyp(this.txtEditTyp.Text);
            new_Geraet.setBezeichnung(this.txtEditBezeichnung.Text);
            new_Geraet.setHersteller(this.txtEditHersteller.Text);
            new_Geraet.setSeriennummer(this.txtEditSeriennummer.Text);
            new_Geraet.setKaufdatum(old_Geraet.getKaufdatum());
            

            this.inv.updateItem(old_Geraet, new_Geraet);

            populateListView(this.lvAllItems, this.inv.getAllItems());

        }

        private void lockEditField()
        {
            this.txtEditTyp.ReadOnly = true;
            this.txtEditBezeichnung.ReadOnly = true;
            this.txtEditHersteller.ReadOnly = true;
            this.txtEditSeriennummer.ReadOnly = true;
        }
        private void unlockEditField()
        {
            this.txtEditTyp.ReadOnly = false;
            this.txtEditBezeichnung.ReadOnly = false;
            this.txtEditHersteller.ReadOnly = false;
            this.txtEditSeriennummer.ReadOnly = false;
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtEditInventurnummer.Text))
            {
                unlockEditField();
            }
            
        }
    }
}
