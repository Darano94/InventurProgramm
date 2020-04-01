namespace InventurProgramm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAllItems = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeriennummer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBezeichnung = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.txtHersteller = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKaufdatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditInventurnummer = new System.Windows.Forms.TextBox();
            this.txtEditKaufdatum = new System.Windows.Forms.TextBox();
            this.txtEditSeriennummer = new System.Windows.Forms.TextBox();
            this.txtEditHersteller = new System.Windows.Forms.TextBox();
            this.txtEditBezeichnung = new System.Windows.Forms.TextBox();
            this.txtEditTyp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dddddddddddddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenAusDateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAllItems
            // 
            this.lvAllItems.HideSelection = false;
            this.lvAllItems.Location = new System.Drawing.Point(11, 301);
            this.lvAllItems.MultiSelect = false;
            this.lvAllItems.Name = "lvAllItems";
            this.lvAllItems.Size = new System.Drawing.Size(668, 312);
            this.lvAllItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAllItems.TabIndex = 13;
            this.lvAllItems.UseCompatibleStateImageBehavior = false;
            this.lvAllItems.SelectedIndexChanged += new System.EventHandler(this.lvAllItems_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeriennummer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtBezeichnung);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTyp);
            this.groupBox1.Controls.Add(this.txtHersteller);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpKaufdatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 268);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerät hinzufügen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtSeriennummer
            // 
            this.txtSeriennummer.Location = new System.Drawing.Point(92, 147);
            this.txtSeriennummer.Name = "txtSeriennummer";
            this.txtSeriennummer.Size = new System.Drawing.Size(196, 20);
            this.txtSeriennummer.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(559, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Füge ein Gerät dem Inventar hinzu!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kaufdatum";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(92, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Location = new System.Drawing.Point(92, 95);
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(196, 20);
            this.txtBezeichnung.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(213, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seriennummer";
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(92, 69);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.Size = new System.Drawing.Size(196, 20);
            this.txtTyp.TabIndex = 0;
            // 
            // txtHersteller
            // 
            this.txtHersteller.Location = new System.Drawing.Point(92, 121);
            this.txtHersteller.Name = "txtHersteller";
            this.txtHersteller.Size = new System.Drawing.Size(196, 20);
            this.txtHersteller.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Typ/Art";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hersteller";
            // 
            // dtpKaufdatum
            // 
            this.dtpKaufdatum.Location = new System.Drawing.Point(92, 173);
            this.dtpKaufdatum.Name = "dtpKaufdatum";
            this.dtpKaufdatum.Size = new System.Drawing.Size(196, 20);
            this.dtpKaufdatum.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bezeichnung";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lvAllItems);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 594);
            this.panel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUnlock);
            this.groupBox2.Controls.Add(this.btnSaveEdit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEditInventurnummer);
            this.groupBox2.Controls.Add(this.txtEditKaufdatum);
            this.groupBox2.Controls.Add(this.txtEditSeriennummer);
            this.groupBox2.Controls.Add(this.txtEditHersteller);
            this.groupBox2.Controls.Add(this.txtEditBezeichnung);
            this.groupBox2.Controls.Add(this.txtEditTyp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(369, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 268);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerät ändern";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(109, 239);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnUnlock.TabIndex = 14;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(210, 239);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 13;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(555, 39);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ändere ein Gerät aus dem Inventar";
            // 
            // txtEditInventurnummer
            // 
            this.txtEditInventurnummer.Location = new System.Drawing.Point(109, 205);
            this.txtEditInventurnummer.Name = "txtEditInventurnummer";
            this.txtEditInventurnummer.ReadOnly = true;
            this.txtEditInventurnummer.Size = new System.Drawing.Size(176, 20);
            this.txtEditInventurnummer.TabIndex = 11;
            // 
            // txtEditKaufdatum
            // 
            this.txtEditKaufdatum.Location = new System.Drawing.Point(109, 176);
            this.txtEditKaufdatum.Name = "txtEditKaufdatum";
            this.txtEditKaufdatum.ReadOnly = true;
            this.txtEditKaufdatum.Size = new System.Drawing.Size(176, 20);
            this.txtEditKaufdatum.TabIndex = 10;
            // 
            // txtEditSeriennummer
            // 
            this.txtEditSeriennummer.Location = new System.Drawing.Point(109, 150);
            this.txtEditSeriennummer.Name = "txtEditSeriennummer";
            this.txtEditSeriennummer.ReadOnly = true;
            this.txtEditSeriennummer.Size = new System.Drawing.Size(176, 20);
            this.txtEditSeriennummer.TabIndex = 9;
            // 
            // txtEditHersteller
            // 
            this.txtEditHersteller.Location = new System.Drawing.Point(109, 121);
            this.txtEditHersteller.Name = "txtEditHersteller";
            this.txtEditHersteller.ReadOnly = true;
            this.txtEditHersteller.Size = new System.Drawing.Size(176, 20);
            this.txtEditHersteller.TabIndex = 8;
            // 
            // txtEditBezeichnung
            // 
            this.txtEditBezeichnung.Location = new System.Drawing.Point(109, 94);
            this.txtEditBezeichnung.Name = "txtEditBezeichnung";
            this.txtEditBezeichnung.ReadOnly = true;
            this.txtEditBezeichnung.Size = new System.Drawing.Size(176, 20);
            this.txtEditBezeichnung.TabIndex = 7;
            // 
            // txtEditTyp
            // 
            this.txtEditTyp.Location = new System.Drawing.Point(109, 68);
            this.txtEditTyp.Name = "txtEditTyp";
            this.txtEditTyp.ReadOnly = true;
            this.txtEditTyp.Size = new System.Drawing.Size(176, 20);
            this.txtEditTyp.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Inventurnummer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Kaufdatum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Seriennummer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hersteller";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bezeichnung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Typ/Art";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dddddddddddddToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 40);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dddddddddddddToolStripMenuItem
            // 
            this.dddddddddddddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.öffnenAusDateiToolStripMenuItem});
            this.dddddddddddddToolStripMenuItem.Name = "dddddddddddddToolStripMenuItem";
            this.dddddddddddddToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.dddddddddddddToolStripMenuItem.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(390, 44);
            this.speichernToolStripMenuItem.Text = "Speichern im akt. Verz.";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(390, 44);
            this.saveAsToolStripMenuItem.Text = "Speichern unter...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(390, 44);
            this.ladenToolStripMenuItem.Text = "Öffnen aus akt. Verz.";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // öffnenAusDateiToolStripMenuItem
            // 
            this.öffnenAusDateiToolStripMenuItem.Name = "öffnenAusDateiToolStripMenuItem";
            this.öffnenAusDateiToolStripMenuItem.Size = new System.Drawing.Size(390, 44);
            this.öffnenAusDateiToolStripMenuItem.Text = "Öffnen aus...";
            this.öffnenAusDateiToolStripMenuItem.Click += new System.EventHandler(this.öffnenAusDateiToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 594);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 665);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 665);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventur Programm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvAllItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSeriennummer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBezeichnung;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.TextBox txtHersteller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpKaufdatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditInventurnummer;
        private System.Windows.Forms.TextBox txtEditKaufdatum;
        private System.Windows.Forms.TextBox txtEditSeriennummer;
        private System.Windows.Forms.TextBox txtEditHersteller;
        private System.Windows.Forms.TextBox txtEditBezeichnung;
        private System.Windows.Forms.TextBox txtEditTyp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dddddddddddddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem öffnenAusDateiToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

