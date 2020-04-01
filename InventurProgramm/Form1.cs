using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if(this.lvAllItems.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = this.lvAllItems.SelectedItems[0];
                this.txtEditTyp.Text = selectedItem.SubItems[0].Text;
                this.txtEditBezeichnung.Text = selectedItem.SubItems[1].Text;
                this.txtEditHersteller.Text = selectedItem.SubItems[2].Text;
                this.txtEditSeriennummer.Text = selectedItem.SubItems[3].Text;
                this.txtEditKaufdatum.Text = selectedItem.SubItems[4].Text;
                this.txtEditInventurnummer.Text = selectedItem.SubItems[5].Text;
            }
            /*  
             *  DER NACHFOLGENDE CODE FÜHRT NUR ZU PROBLEMEN UND KOMISCHEN CRASHS XD
             *  
             *  
             *  
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
            */
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

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentPath = System.IO.Directory.GetCurrentDirectory();
            saveInventarToFile(this.inv, currentPath+"\\Inventar.txt");            
        }

        private void saveInventarToFile(Inventar inv, string path)
        {
            List<Geraet> allItems = inv.getAllItems(); 
            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);


            if (allItems.Count > 0)
            {
                foreach (Geraet g in allItems)
                {
                    System.IO.File.AppendAllText(path, g.ToString() + "\r\n");
                }
                string info = "Die Geräte wurden unter: \"" + path + " gespeichert!";
                MessageBox.Show(info, "Erfolgreich gespeichert!");

            }
            else
            {
                MessageBox.Show("Kannst nicht speichern wenn du keine items hast lol", "Nope");
            }
        }

        private void ladeInventarAusDatei(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("Es konnte im Verzeichnis keine Datei gefunden werden. Stelle sicher, dass die File.txt im selben Ordner liegt wie dieses Programm oder speicher erst eine Liste ab", "Fehler beim Laden!");
                return;
            }
            string[] lines = System.IO.File.ReadAllLines(path);
            this.inv = new Inventar();

            foreach (string line in lines)
            {
                string[] props = line.Split(';');
                Geraet g = new Geraet();
                g.setTyp(props[0]);
                g.setBezeichnung(props[1]);
                g.setHersteller(props[2]);
                g.setInventurnummer(props[3]);
                g.setSeriennummer(props[4]);
                DateTime dt = Convert.ToDateTime(props[5]);
                g.setKaufdatum(dt);
                this.inv.addItem(g);
            }
            populateListView(this.lvAllItems, this.inv.getAllItems());

        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentPath = System.IO.Directory.GetCurrentDirectory();
            ladeInventarAusDatei(currentPath + "\\Inventar.txt");
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            this.saveFileDialog1.Title = "Wähle einen Speicherort aus";
            this.saveFileDialog1.Filter = "Text Dateien |*.txt";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullPath = this.saveFileDialog1.FileName;
                saveInventarToFile(this.inv, fullPath);
            }

        }

        private void öffnenAusDateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            this.openFileDialog1.Title = "Wähle eine Datei aus";
            this.openFileDialog1.Filter = "Text Dateien |*.txt";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullPath = this.openFileDialog1.FileName;
                ladeInventarAusDatei(fullPath);
            }
        }
    }
}
