

namespace Zooverwaltung
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabPflegerZuordnung = new TabControl();
            tabKontinent = new TabPage();
            btnKontinentLoeschen = new Button();
            btnKontinentSpeichern = new Button();
            lstKontinente = new ListBox();
            txtKontinentBezeichnung = new TextBox();
            label1 = new Label();
            tabGehege = new TabPage();
            btnGehegeLoeschen = new Button();
            btnGehegeSpeichern = new Button();
            lstGehege = new ListBox();
            cboGehegeKontinent = new ComboBox();
            label3 = new Label();
            txtGehegeBez = new TextBox();
            label2 = new Label();
            tabTierart = new TabPage();
            btnTierartLoeschen = new Button();
            btnTierartSpeichern = new Button();
            lstTierarten = new ListBox();
            txtTierartBez = new TextBox();
            label4 = new Label();
            tabTiere = new TabPage();
            button2 = new Button();
            button1 = new Button();
            btnTierLoeschen = new Button();
            btnTierSpeichern = new Button();
            lstTiere = new ListBox();
            cboTierGehege = new ComboBox();
            label9 = new Label();
            cboTierart = new ComboBox();
            label8 = new Label();
            dtpTierGeburt = new DateTimePicker();
            label7 = new Label();
            txtTierGewicht = new TextBox();
            label6 = new Label();
            txtTierName = new TextBox();
            label5 = new Label();
            tabFutter = new TabPage();
            btnFutterLoeschen = new Button();
            btnFutterSpeichern = new Button();
            lstFutter = new ListBox();
            txtFutterKommentar = new TextBox();
            label12 = new Label();
            txtFutterVerpackung = new TextBox();
            label11 = new Label();
            txtFutterBez = new TextBox();
            label10 = new Label();
            tabRationen = new TabPage();
            btnRationLoeschen = new Button();
            btnRationSpeichern = new Button();
            lstRationen = new ListBox();
            dtpRationUhrzeit = new DateTimePicker();
            label16 = new Label();
            txtRationMenge = new TextBox();
            label15 = new Label();
            cboRationFutter = new ComboBox();
            label14 = new Label();
            cboRationTier = new ComboBox();
            label13 = new Label();
            tabUebersicht = new TabPage();
            dgvUebersicht = new DataGridView();
            tabFuetterungen = new TabPage();
            button3 = new Button();
            Fütterungen = new Label();
            dgvFütterungen = new DataGridView();
            cboUebersichtTier = new ComboBox();
            tabPflege = new TabPage();
            rbOhnePfleger = new RadioButton();
            rbOhneHauptpfleger = new RadioButton();
            rbAlleGehege = new RadioButton();
            btnEntfernen = new Button();
            btnZuweisen = new Button();
            chkHauptpfleger = new CheckBox();
            cboZuordnungPfleger = new ComboBox();
            dgvBetreuer = new DataGridView();
            cboZuordnungGehege = new ComboBox();
            label17 = new Label();
            Datum = new DataGridViewTextBoxColumn();
            Zeit = new DataGridViewTextBoxColumn();
            Wer = new DataGridViewTextBoxColumn();
            Was = new DataGridViewTextBoxColumn();
            Wieviel = new DataGridViewTextBoxColumn();
            // Datum
            Datum.Name = "Datum";
            Datum.HeaderText = "Datum";
            Datum.DataPropertyName = "Datum";

            // Zeit
            Zeit.Name = "Uhrzeit";
            Zeit.HeaderText = "Zeit";
            Zeit.DataPropertyName = "Uhrzeit";

            // Wer
            Wer.Name = "TierName";
            Wer.HeaderText = "Wer";
            Wer.DataPropertyName = "TierName";

            // Was
            Was.Name = "FutterName";
            Was.HeaderText = "Was";
            Was.DataPropertyName = "FutterName";

            // Wieviel
            Wieviel.Name = "Menge";
            Wieviel.HeaderText = "Wieviel";
            Wieviel.DataPropertyName = "Menge";

            tabPflegerZuordnung.SuspendLayout();
            tabKontinent.SuspendLayout();
            tabGehege.SuspendLayout();
            tabTierart.SuspendLayout();
            tabTiere.SuspendLayout();
            tabFutter.SuspendLayout();
            tabRationen.SuspendLayout();
            tabUebersicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUebersicht).BeginInit();
            tabFuetterungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFütterungen).BeginInit();
            tabPflege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBetreuer).BeginInit();
            SuspendLayout();
            // 
            // tabPflegerZuordnung
            // 
            tabPflegerZuordnung.Controls.Add(tabKontinent);
            tabPflegerZuordnung.Controls.Add(tabGehege);
            tabPflegerZuordnung.Controls.Add(tabTierart);
            tabPflegerZuordnung.Controls.Add(tabTiere);
            tabPflegerZuordnung.Controls.Add(tabFutter);
            tabPflegerZuordnung.Controls.Add(tabRationen);
            tabPflegerZuordnung.Controls.Add(tabUebersicht);
            tabPflegerZuordnung.Controls.Add(tabFuetterungen);
            tabPflegerZuordnung.Controls.Add(tabPflege);
            tabPflegerZuordnung.Dock = DockStyle.Fill;
            tabPflegerZuordnung.Location = new Point(0, 0);
            tabPflegerZuordnung.Name = "tabPflegerZuordnung";
            tabPflegerZuordnung.SelectedIndex = 0;
            tabPflegerZuordnung.Size = new Size(900, 500);
            tabPflegerZuordnung.TabIndex = 0;
            // 
            // tabKontinent
            // 
            tabKontinent.Controls.Add(btnKontinentLoeschen);
            tabKontinent.Controls.Add(btnKontinentSpeichern);
            tabKontinent.Controls.Add(lstKontinente);
            tabKontinent.Controls.Add(txtKontinentBezeichnung);
            tabKontinent.Controls.Add(label1);
            tabKontinent.Location = new Point(4, 24);
            tabKontinent.Name = "tabKontinent";
            tabKontinent.Padding = new Padding(3);
            tabKontinent.Size = new Size(892, 472);
            tabKontinent.TabIndex = 0;
            tabKontinent.Text = "Kontinente";
            tabKontinent.UseVisualStyleBackColor = true;
            // 
            // btnKontinentLoeschen
            // 
            btnKontinentLoeschen.Location = new Point(187, 74);
            btnKontinentLoeschen.Name = "btnKontinentLoeschen";
            btnKontinentLoeschen.Size = new Size(75, 23);
            btnKontinentLoeschen.TabIndex = 4;
            btnKontinentLoeschen.Text = "Löschen";
            btnKontinentLoeschen.UseVisualStyleBackColor = true;
            btnKontinentLoeschen.Click += btnKontinentLoeschen_Click;
            // 
            // btnKontinentSpeichern
            // 
            btnKontinentSpeichern.Location = new Point(106, 74);
            btnKontinentSpeichern.Name = "btnKontinentSpeichern";
            btnKontinentSpeichern.Size = new Size(75, 23);
            btnKontinentSpeichern.TabIndex = 3;
            btnKontinentSpeichern.Text = "Speichern";
            btnKontinentSpeichern.UseVisualStyleBackColor = true;
            btnKontinentSpeichern.Click += btnKontinentSpeichern_Click;
            // 
            // lstKontinente
            // 
            lstKontinente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstKontinente.FormattingEnabled = true;
            lstKontinente.ItemHeight = 15;
            lstKontinente.Location = new Point(450, 20);
            lstKontinente.Name = "lstKontinente";
            lstKontinente.Size = new Size(420, 424);
            lstKontinente.TabIndex = 2;
            lstKontinente.SelectedIndexChanged += lstKontinente_SelectedIndexChanged;
            // 
            // txtKontinentBezeichnung
            // 
            txtKontinentBezeichnung.Location = new Point(106, 30);
            txtKontinentBezeichnung.Name = "txtKontinentBezeichnung";
            txtKontinentBezeichnung.Size = new Size(250, 23);
            txtKontinentBezeichnung.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Bezeichnung";
            // 
            // tabGehege
            // 
            tabGehege.Controls.Add(btnGehegeLoeschen);
            tabGehege.Controls.Add(btnGehegeSpeichern);
            tabGehege.Controls.Add(lstGehege);
            tabGehege.Controls.Add(cboGehegeKontinent);
            tabGehege.Controls.Add(label3);
            tabGehege.Controls.Add(txtGehegeBez);
            tabGehege.Controls.Add(label2);
            tabGehege.Location = new Point(4, 24);
            tabGehege.Name = "tabGehege";
            tabGehege.Padding = new Padding(3);
            tabGehege.Size = new Size(892, 472);
            tabGehege.TabIndex = 1;
            tabGehege.Text = "Gehege";
            tabGehege.UseVisualStyleBackColor = true;
            // 
            // btnGehegeLoeschen
            // 
            btnGehegeLoeschen.Location = new Point(187, 126);
            btnGehegeLoeschen.Name = "btnGehegeLoeschen";
            btnGehegeLoeschen.Size = new Size(75, 23);
            btnGehegeLoeschen.TabIndex = 6;
            btnGehegeLoeschen.Text = "Löschen";
            btnGehegeLoeschen.UseVisualStyleBackColor = true;
            btnGehegeLoeschen.Click += btnGehegeLoeschen_Click;
            // 
            // btnGehegeSpeichern
            // 
            btnGehegeSpeichern.Location = new Point(106, 126);
            btnGehegeSpeichern.Name = "btnGehegeSpeichern";
            btnGehegeSpeichern.Size = new Size(75, 23);
            btnGehegeSpeichern.TabIndex = 5;
            btnGehegeSpeichern.Text = "Speichern";
            btnGehegeSpeichern.UseVisualStyleBackColor = true;
            btnGehegeSpeichern.Click += btnGehegeSpeichern_Click;
            // 
            // lstGehege
            // 
            lstGehege.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstGehege.FormattingEnabled = true;
            lstGehege.ItemHeight = 15;
            lstGehege.Location = new Point(450, 20);
            lstGehege.Name = "lstGehege";
            lstGehege.Size = new Size(420, 424);
            lstGehege.TabIndex = 4;
            lstGehege.SelectedIndexChanged += lstGehege_SelectedIndexChanged;
            // 
            // cboGehegeKontinent
            // 
            cboGehegeKontinent.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGehegeKontinent.FormattingEnabled = true;
            cboGehegeKontinent.Location = new Point(106, 75);
            cboGehegeKontinent.Name = "cboGehegeKontinent";
            cboGehegeKontinent.Size = new Size(250, 23);
            cboGehegeKontinent.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 78);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Kontinent";
            // 
            // txtGehegeBez
            // 
            txtGehegeBez.Location = new Point(106, 30);
            txtGehegeBez.Name = "txtGehegeBez";
            txtGehegeBez.Size = new Size(250, 23);
            txtGehegeBez.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 33);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "Bezeichnung";
            // 
            // tabTierart
            // 
            tabTierart.Controls.Add(btnTierartLoeschen);
            tabTierart.Controls.Add(btnTierartSpeichern);
            tabTierart.Controls.Add(lstTierarten);
            tabTierart.Controls.Add(txtTierartBez);
            tabTierart.Controls.Add(label4);
            tabTierart.Location = new Point(4, 24);
            tabTierart.Name = "tabTierart";
            tabTierart.Padding = new Padding(3);
            tabTierart.Size = new Size(892, 472);
            tabTierart.TabIndex = 2;
            tabTierart.Text = "Tierarten";
            tabTierart.UseVisualStyleBackColor = true;
            // 
            // btnTierartLoeschen
            // 
            btnTierartLoeschen.Location = new Point(187, 74);
            btnTierartLoeschen.Name = "btnTierartLoeschen";
            btnTierartLoeschen.Size = new Size(75, 23);
            btnTierartLoeschen.TabIndex = 4;
            btnTierartLoeschen.Text = "Löschen";
            btnTierartLoeschen.UseVisualStyleBackColor = true;
            btnTierartLoeschen.Click += btnTierartLoeschen_Click;
            // 
            // btnTierartSpeichern
            // 
            btnTierartSpeichern.Location = new Point(106, 74);
            btnTierartSpeichern.Name = "btnTierartSpeichern";
            btnTierartSpeichern.Size = new Size(75, 23);
            btnTierartSpeichern.TabIndex = 3;
            btnTierartSpeichern.Text = "Speichern";
            btnTierartSpeichern.UseVisualStyleBackColor = true;
            btnTierartSpeichern.Click += btnTierartSpeichern_Click;
            // 
            // lstTierarten
            // 
            lstTierarten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstTierarten.FormattingEnabled = true;
            lstTierarten.ItemHeight = 15;
            lstTierarten.Location = new Point(450, 20);
            lstTierarten.Name = "lstTierarten";
            lstTierarten.Size = new Size(420, 424);
            lstTierarten.TabIndex = 2;
            lstTierarten.SelectedIndexChanged += lstTierarten_SelectedIndexChanged;
            // 
            // txtTierartBez
            // 
            txtTierartBez.Location = new Point(106, 30);
            txtTierartBez.Name = "txtTierartBez";
            txtTierartBez.Size = new Size(250, 23);
            txtTierartBez.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 33);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 0;
            label4.Text = "Bezeichnung";
            // 
            // tabTiere
            // 
            tabTiere.Controls.Add(button2);
            tabTiere.Controls.Add(button1);
            tabTiere.Controls.Add(btnTierLoeschen);
            tabTiere.Controls.Add(btnTierSpeichern);
            tabTiere.Controls.Add(lstTiere);
            tabTiere.Controls.Add(cboTierGehege);
            tabTiere.Controls.Add(label9);
            tabTiere.Controls.Add(cboTierart);
            tabTiere.Controls.Add(label8);
            tabTiere.Controls.Add(dtpTierGeburt);
            tabTiere.Controls.Add(label7);
            tabTiere.Controls.Add(txtTierGewicht);
            tabTiere.Controls.Add(label6);
            tabTiere.Controls.Add(txtTierName);
            tabTiere.Controls.Add(label5);
            tabTiere.Location = new Point(4, 24);
            tabTiere.Name = "tabTiere";
            tabTiere.Padding = new Padding(3);
            tabTiere.Size = new Size(892, 472);
            tabTiere.TabIndex = 3;
            tabTiere.Text = "Tiere";
            tabTiere.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(234, 305);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 14;
            button2.Text = "XML Import";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(114, 305);
            button1.Name = "button1";
            button1.Size = new Size(119, 26);
            button1.TabIndex = 13;
            button1.Text = "XML Export";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnTierLoeschen
            // 
            btnTierLoeschen.Location = new Point(187, 220);
            btnTierLoeschen.Name = "btnTierLoeschen";
            btnTierLoeschen.Size = new Size(75, 23);
            btnTierLoeschen.TabIndex = 12;
            btnTierLoeschen.Text = "Löschen";
            btnTierLoeschen.UseVisualStyleBackColor = true;
            btnTierLoeschen.Click += btnTierLoeschen_Click;
            // 
            // btnTierSpeichern
            // 
            btnTierSpeichern.Location = new Point(106, 220);
            btnTierSpeichern.Name = "btnTierSpeichern";
            btnTierSpeichern.Size = new Size(75, 23);
            btnTierSpeichern.TabIndex = 11;
            btnTierSpeichern.Text = "Speichern";
            btnTierSpeichern.UseVisualStyleBackColor = true;
            btnTierSpeichern.Click += btnTierSpeichern_Click;
            // 
            // lstTiere
            // 
            lstTiere.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstTiere.FormattingEnabled = true;
            lstTiere.ItemHeight = 15;
            lstTiere.Location = new Point(450, 20);
            lstTiere.Name = "lstTiere";
            lstTiere.Size = new Size(420, 424);
            lstTiere.TabIndex = 10;
            lstTiere.SelectedIndexChanged += lstTiere_SelectedIndexChanged;
            // 
            // cboTierGehege
            // 
            cboTierGehege.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTierGehege.FormattingEnabled = true;
            cboTierGehege.Location = new Point(106, 180);
            cboTierGehege.Name = "cboTierGehege";
            cboTierGehege.Size = new Size(250, 23);
            cboTierGehege.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 183);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 8;
            label9.Text = "Gehege";
            // 
            // cboTierart
            // 
            cboTierart.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTierart.FormattingEnabled = true;
            cboTierart.Location = new Point(106, 151);
            cboTierart.Name = "cboTierart";
            cboTierart.Size = new Size(250, 23);
            cboTierart.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 154);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 6;
            label8.Text = "Tierart";
            // 
            // dtpTierGeburt
            // 
            dtpTierGeburt.Format = DateTimePickerFormat.Short;
            dtpTierGeburt.Location = new Point(106, 122);
            dtpTierGeburt.Name = "dtpTierGeburt";
            dtpTierGeburt.Size = new Size(250, 23);
            dtpTierGeburt.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 128);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 4;
            label7.Text = "Geburtsdatum";
            // 
            // txtTierGewicht
            // 
            txtTierGewicht.Location = new Point(106, 79);
            txtTierGewicht.Name = "txtTierGewicht";
            txtTierGewicht.Size = new Size(250, 23);
            txtTierGewicht.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 82);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 2;
            label6.Text = "Gewicht";
            // 
            // txtTierName
            // 
            txtTierName.Location = new Point(106, 34);
            txtTierName.Name = "txtTierName";
            txtTierName.Size = new Size(250, 23);
            txtTierName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 37);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Name";
            // 
            // tabFutter
            // 
            tabFutter.Controls.Add(btnFutterLoeschen);
            tabFutter.Controls.Add(btnFutterSpeichern);
            tabFutter.Controls.Add(lstFutter);
            tabFutter.Controls.Add(txtFutterKommentar);
            tabFutter.Controls.Add(label12);
            tabFutter.Controls.Add(txtFutterVerpackung);
            tabFutter.Controls.Add(label11);
            tabFutter.Controls.Add(txtFutterBez);
            tabFutter.Controls.Add(label10);
            tabFutter.Location = new Point(4, 24);
            tabFutter.Name = "tabFutter";
            tabFutter.Padding = new Padding(3);
            tabFutter.Size = new Size(892, 472);
            tabFutter.TabIndex = 4;
            tabFutter.Text = "Futter";
            tabFutter.UseVisualStyleBackColor = true;
            // 
            // btnFutterLoeschen
            // 
            btnFutterLoeschen.Location = new Point(187, 210);
            btnFutterLoeschen.Name = "btnFutterLoeschen";
            btnFutterLoeschen.Size = new Size(75, 23);
            btnFutterLoeschen.TabIndex = 8;
            btnFutterLoeschen.Text = "Löschen";
            btnFutterLoeschen.UseVisualStyleBackColor = true;
            btnFutterLoeschen.Click += btnFutterLoeschen_Click;
            // 
            // btnFutterSpeichern
            // 
            btnFutterSpeichern.Location = new Point(106, 210);
            btnFutterSpeichern.Name = "btnFutterSpeichern";
            btnFutterSpeichern.Size = new Size(75, 23);
            btnFutterSpeichern.TabIndex = 7;
            btnFutterSpeichern.Text = "Speichern";
            btnFutterSpeichern.UseVisualStyleBackColor = true;
            btnFutterSpeichern.Click += btnFutterSpeichern_Click;
            // 
            // lstFutter
            // 
            lstFutter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstFutter.FormattingEnabled = true;
            lstFutter.ItemHeight = 15;
            lstFutter.Location = new Point(450, 20);
            lstFutter.Name = "lstFutter";
            lstFutter.Size = new Size(420, 424);
            lstFutter.TabIndex = 6;
            lstFutter.SelectedIndexChanged += lstFutter_SelectedIndexChanged;
            // 
            // txtFutterKommentar
            // 
            txtFutterKommentar.Location = new Point(106, 107);
            txtFutterKommentar.Multiline = true;
            txtFutterKommentar.Name = "txtFutterKommentar";
            txtFutterKommentar.Size = new Size(300, 86);
            txtFutterKommentar.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 110);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 4;
            label12.Text = "Kommentar";
            // 
            // txtFutterVerpackung
            // 
            txtFutterVerpackung.Location = new Point(106, 65);
            txtFutterVerpackung.Name = "txtFutterVerpackung";
            txtFutterVerpackung.Size = new Size(300, 23);
            txtFutterVerpackung.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 68);
            label11.Name = "label11";
            label11.Size = new Size(88, 15);
            label11.TabIndex = 2;
            label11.Text = "Verpackungsgr.";
            // 
            // txtFutterBez
            // 
            txtFutterBez.Location = new Point(106, 26);
            txtFutterBez.Name = "txtFutterBez";
            txtFutterBez.Size = new Size(300, 23);
            txtFutterBez.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 29);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 0;
            label10.Text = "Bezeichnung";
            // 
            // tabRationen
            // 
            tabRationen.Controls.Add(btnRationLoeschen);
            tabRationen.Controls.Add(btnRationSpeichern);
            tabRationen.Controls.Add(lstRationen);
            tabRationen.Controls.Add(dtpRationUhrzeit);
            tabRationen.Controls.Add(label16);
            tabRationen.Controls.Add(txtRationMenge);
            tabRationen.Controls.Add(label15);
            tabRationen.Controls.Add(cboRationFutter);
            tabRationen.Controls.Add(label14);
            tabRationen.Controls.Add(cboRationTier);
            tabRationen.Controls.Add(label13);
            tabRationen.Location = new Point(4, 24);
            tabRationen.Name = "tabRationen";
            tabRationen.Padding = new Padding(3);
            tabRationen.Size = new Size(892, 472);
            tabRationen.TabIndex = 5;
            tabRationen.Text = "Futterrationen";
            tabRationen.UseVisualStyleBackColor = true;
            // 
            // btnRationLoeschen
            // 
            btnRationLoeschen.Location = new Point(187, 210);
            btnRationLoeschen.Name = "btnRationLoeschen";
            btnRationLoeschen.Size = new Size(75, 23);
            btnRationLoeschen.TabIndex = 10;
            btnRationLoeschen.Text = "Löschen";
            btnRationLoeschen.UseVisualStyleBackColor = true;
            btnRationLoeschen.Click += btnRationLoeschen_Click;
            // 
            // btnRationSpeichern
            // 
            btnRationSpeichern.Location = new Point(106, 210);
            btnRationSpeichern.Name = "btnRationSpeichern";
            btnRationSpeichern.Size = new Size(75, 23);
            btnRationSpeichern.TabIndex = 9;
            btnRationSpeichern.Text = "Speichern";
            btnRationSpeichern.UseVisualStyleBackColor = true;
            btnRationSpeichern.Click += btnRationSpeichern_Click;
            // 
            // lstRationen
            // 
            lstRationen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstRationen.FormattingEnabled = true;
            lstRationen.ItemHeight = 15;
            lstRationen.Location = new Point(450, 20);
            lstRationen.Name = "lstRationen";
            lstRationen.Size = new Size(420, 424);
            lstRationen.TabIndex = 8;
            // 
            // dtpRationUhrzeit
            // 
            dtpRationUhrzeit.Format = DateTimePickerFormat.Time;
            dtpRationUhrzeit.Location = new Point(106, 162);
            dtpRationUhrzeit.Name = "dtpRationUhrzeit";
            dtpRationUhrzeit.ShowUpDown = true;
            dtpRationUhrzeit.Size = new Size(200, 23);
            dtpRationUhrzeit.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 168);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 6;
            label16.Text = "Uhrzeit";
            // 
            // txtRationMenge
            // 
            txtRationMenge.Location = new Point(106, 121);
            txtRationMenge.Name = "txtRationMenge";
            txtRationMenge.Size = new Size(200, 23);
            txtRationMenge.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 124);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 4;
            label15.Text = "Menge";
            // 
            // cboRationFutter
            // 
            cboRationFutter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRationFutter.FormattingEnabled = true;
            cboRationFutter.Location = new Point(106, 79);
            cboRationFutter.Name = "cboRationFutter";
            cboRationFutter.Size = new Size(250, 23);
            cboRationFutter.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 82);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 2;
            label14.Text = "Futter";
            // 
            // cboRationTier
            // 
            cboRationTier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRationTier.FormattingEnabled = true;
            cboRationTier.Location = new Point(106, 37);
            cboRationTier.Name = "cboRationTier";
            cboRationTier.Size = new Size(250, 23);
            cboRationTier.TabIndex = 1;
            cboRationTier.SelectedIndexChanged += cboRationTier_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 40);
            label13.Name = "label13";
            label13.Size = new Size(27, 15);
            label13.TabIndex = 0;
            label13.Text = "Tier";
            // 
            // tabUebersicht
            // 
            tabUebersicht.Controls.Add(dgvUebersicht);
            tabUebersicht.Location = new Point(4, 24);
            tabUebersicht.Name = "tabUebersicht";
            tabUebersicht.Padding = new Padding(3);
            tabUebersicht.Size = new Size(892, 472);
            tabUebersicht.TabIndex = 6;
            tabUebersicht.Text = "Übersicht";
            tabUebersicht.UseVisualStyleBackColor = true;
            // 
            // dgvUebersicht
            // 
            dgvUebersicht.AllowUserToAddRows = false;
            dgvUebersicht.AllowUserToDeleteRows = false;
            dgvUebersicht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUebersicht.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUebersicht.Dock = DockStyle.Fill;
            dgvUebersicht.Location = new Point(3, 3);
            dgvUebersicht.Name = "dgvUebersicht";
            dgvUebersicht.ReadOnly = true;
            dgvUebersicht.Size = new Size(886, 466);
            dgvUebersicht.TabIndex = 0;
            // 
            // tabFuetterungen
            // 
            tabFuetterungen.Controls.Add(button3);
            tabFuetterungen.Controls.Add(Fütterungen);
            tabFuetterungen.Controls.Add(dgvFütterungen);
            tabFuetterungen.Controls.Add(cboUebersichtTier);
            tabFuetterungen.Location = new Point(4, 24);
            tabFuetterungen.Name = "tabFuetterungen";
            tabFuetterungen.Padding = new Padding(3);
            tabFuetterungen.Size = new Size(892, 472);
            tabFuetterungen.TabIndex = 7;
            tabFuetterungen.Text = "Fütterungen";
            tabFuetterungen.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(214, 422);
            button3.Name = "button3";
            button3.Size = new Size(144, 23);
            button3.TabIndex = 3;
            button3.Text = "nach Excel esportieren";
            button3.UseVisualStyleBackColor = true;
            // 
            // Fütterungen
            // 
            Fütterungen.AutoSize = true;
            Fütterungen.Location = new Point(24, 13);
            Fütterungen.Name = "Fütterungen";
            Fütterungen.Size = new Size(72, 15);
            Fütterungen.TabIndex = 2;
            Fütterungen.Text = "Fütterungen";
            Fütterungen.Click += Fütterungen_Click;
            // 
            // dgvFütterungen
            // 
            dgvFütterungen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFütterungen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFütterungen.Columns.AddRange(new DataGridViewColumn[] { Datum, Zeit, Wer, Was, Wieviel });
            dgvFütterungen.Location = new Point(24, 44);
            dgvFütterungen.Name = "dgvFütterungen";
            dgvFütterungen.Size = new Size(850, 359);
            dgvFütterungen.TabIndex = 1;
            //dgvFütterungen.CellContentClick += dgvFütterungen_CellContentClick;
            // 
            // cboUebersichtTier
            // 
            cboUebersichtTier.FormattingEnabled = true;
            cboUebersichtTier.Location = new Point(24, 423);
            cboUebersichtTier.Name = "cboUebersichtTier";
            cboUebersichtTier.Size = new Size(121, 23);
            cboUebersichtTier.TabIndex = 0;
            // 
            // tabPflege
            // 
            tabPflege.Controls.Add(rbOhnePfleger);
            tabPflege.Controls.Add(rbOhneHauptpfleger);
            tabPflege.Controls.Add(rbAlleGehege);
            tabPflege.Controls.Add(btnEntfernen);
            tabPflege.Controls.Add(btnZuweisen);
            tabPflege.Controls.Add(chkHauptpfleger);
            tabPflege.Controls.Add(cboZuordnungPfleger);
            tabPflege.Controls.Add(dgvBetreuer);
            tabPflege.Controls.Add(cboZuordnungGehege);
            tabPflege.Controls.Add(label17);
            tabPflege.Location = new Point(4, 24);
            tabPflege.Name = "tabPflege";
            tabPflege.Padding = new Padding(3);
            tabPflege.Size = new Size(892, 472);
            tabPflege.TabIndex = 8;
            tabPflege.Text = "Pflege";
            tabPflege.UseVisualStyleBackColor = true;
            // 
            // rbOhnePfleger
            // 
            rbOhnePfleger.AutoSize = true;
            rbOhnePfleger.Location = new Point(223, 309);
            rbOhnePfleger.Name = "rbOhnePfleger";
            rbOhnePfleger.Size = new Size(135, 19);
            rbOhnePfleger.TabIndex = 9;
            rbOhnePfleger.TabStop = true;
            rbOhnePfleger.Text = "Gehege ohne Pfleger";
            rbOhnePfleger.UseVisualStyleBackColor = true;
            rbOhnePfleger.CheckedChanged += rbAlleGehege_CheckedChanged;
            // 
            // rbOhneHauptpfleger
            // 
            rbOhneHauptpfleger.AutoSize = true;
            rbOhneHauptpfleger.Location = new Point(223, 285);
            rbOhneHauptpfleger.Name = "rbOhneHauptpfleger";
            rbOhneHauptpfleger.Size = new Size(168, 19);
            rbOhneHauptpfleger.TabIndex = 8;
            rbOhneHauptpfleger.TabStop = true;
            rbOhneHauptpfleger.Text = "Gehege ohne Hauptpfleger";
            rbOhneHauptpfleger.UseVisualStyleBackColor = true;
            rbOhneHauptpfleger.CheckedChanged += rbAlleGehege_CheckedChanged;
            // 
            // rbAlleGehege
            // 
            rbAlleGehege.AutoSize = true;
            rbAlleGehege.Location = new Point(223, 261);
            rbAlleGehege.Name = "rbAlleGehege";
            rbAlleGehege.Size = new Size(86, 19);
            rbAlleGehege.TabIndex = 7;
            rbAlleGehege.TabStop = true;
            rbAlleGehege.Text = "alle Gehege";
            rbAlleGehege.UseVisualStyleBackColor = true;
            rbAlleGehege.CheckedChanged += rbAlleGehege_CheckedChanged;
            // 
            // btnEntfernen
            // 
            btnEntfernen.Location = new Point(334, 341);
            btnEntfernen.Name = "btnEntfernen";
            btnEntfernen.Size = new Size(75, 23);
            btnEntfernen.TabIndex = 6;
            btnEntfernen.Text = "Entfernen";
            btnEntfernen.UseVisualStyleBackColor = true;
            btnEntfernen.Click += btnEntfernen_Click;
            // 
            // btnZuweisen
            // 
            btnZuweisen.Location = new Point(226, 338);
            btnZuweisen.Name = "btnZuweisen";
            btnZuweisen.Size = new Size(75, 23);
            btnZuweisen.TabIndex = 5;
            btnZuweisen.Text = "Zuweisen";
            btnZuweisen.UseVisualStyleBackColor = true;
            btnZuweisen.Click += btnZuweisen_Click;
            // 
            // chkHauptpfleger
            // 
            chkHauptpfleger.AutoSize = true;
            chkHauptpfleger.Location = new Point(63, 340);
            chkHauptpfleger.Name = "chkHauptpfleger";
            chkHauptpfleger.Size = new Size(96, 19);
            chkHauptpfleger.TabIndex = 4;
            chkHauptpfleger.Text = "Hauptpfleger";
            chkHauptpfleger.UseVisualStyleBackColor = true;
            // 
            // cboZuordnungPfleger
            // 
            cboZuordnungPfleger.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZuordnungPfleger.FormattingEnabled = true;
            cboZuordnungPfleger.Location = new Point(59, 279);
            cboZuordnungPfleger.Name = "cboZuordnungPfleger";
            cboZuordnungPfleger.Size = new Size(121, 23);
            cboZuordnungPfleger.TabIndex = 3;
            // 
            // dgvBetreuer
            // 
            dgvBetreuer.AllowUserToAddRows = false;
            dgvBetreuer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBetreuer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBetreuer.Location = new Point(44, 75);
            dgvBetreuer.Name = "dgvBetreuer";
            dgvBetreuer.ReadOnly = true;
            dgvBetreuer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBetreuer.Size = new Size(240, 150);
            dgvBetreuer.TabIndex = 2;
            // 
            // cboZuordnungGehege
            // 
            cboZuordnungGehege.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZuordnungGehege.FormattingEnabled = true;
            cboZuordnungGehege.Location = new Point(174, 9);
            cboZuordnungGehege.Name = "cboZuordnungGehege";
            cboZuordnungGehege.Size = new Size(121, 23);
            cboZuordnungGehege.TabIndex = 1;
            cboZuordnungGehege.SelectedIndexChanged += cboZuordnungGehege_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(53, 10);
            label17.Name = "label17";
            label17.Size = new Size(106, 15);
            label17.TabIndex = 0;
            label17.Text = "Gehege auswählen";
            // 
            // Datum
            // 
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            // 
            // Zeit
            // 
            Zeit.HeaderText = "Zeit";
            Zeit.Name = "Zeit";
            // 
            // Wer
            // 
            Wer.HeaderText = "Wer";
            Wer.Name = "Wer";
            // 
            // Was
            // 
            Was.HeaderText = "Was";
            Was.Name = "Was";
            // 
            // Wieviel
            // 
            Wieviel.HeaderText = "Wieviel";
            Wieviel.Name = "Wieviel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(tabPflegerZuordnung);
            Name = "Form1";
            Text = "Zooverwaltung (erweitert mit Futter)";
            Load += Form1_Load;
            tabPflegerZuordnung.ResumeLayout(false);
            tabKontinent.ResumeLayout(false);
            tabKontinent.PerformLayout();
            tabGehege.ResumeLayout(false);
            tabGehege.PerformLayout();
            tabTierart.ResumeLayout(false);
            tabTierart.PerformLayout();
            tabTiere.ResumeLayout(false);
            tabTiere.PerformLayout();
            tabFutter.ResumeLayout(false);
            tabFutter.PerformLayout();
            tabRationen.ResumeLayout(false);
            tabRationen.PerformLayout();
            tabUebersicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUebersicht).EndInit();
            tabFuetterungen.ResumeLayout(false);
            tabFuetterungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFütterungen).EndInit();
            tabPflege.ResumeLayout(false);
            tabPflege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBetreuer).EndInit();
            ResumeLayout(false);

        }

        private void lstKontinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: später implementieren

        }

        #endregion

        private System.Windows.Forms.TabControl tabPflegerZuordnung;
        private System.Windows.Forms.TabPage tabKontinent;
        private System.Windows.Forms.Button btnKontinentLoeschen;
        private System.Windows.Forms.Button btnKontinentSpeichern;
        private System.Windows.Forms.ListBox lstKontinente;
        private System.Windows.Forms.TextBox txtKontinentBezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabGehege;
        private System.Windows.Forms.Button btnGehegeLoeschen;
        private System.Windows.Forms.Button btnGehegeSpeichern;
        private System.Windows.Forms.ListBox lstGehege;
        private System.Windows.Forms.ComboBox cboGehegeKontinent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGehegeBez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabTierart;
        private System.Windows.Forms.Button btnTierartLoeschen;
        private System.Windows.Forms.Button btnTierartSpeichern;
        private System.Windows.Forms.ListBox lstTierarten;
        private System.Windows.Forms.TextBox txtTierartBez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabTiere;
        private System.Windows.Forms.Button btnTierLoeschen;
        private System.Windows.Forms.Button btnTierSpeichern;
        private System.Windows.Forms.ListBox lstTiere;
        private System.Windows.Forms.ComboBox cboTierGehege;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTierart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTierGeburt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTierGewicht;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTierName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabFutter;
        private System.Windows.Forms.Button btnFutterLoeschen;
        private System.Windows.Forms.Button btnFutterSpeichern;
        private System.Windows.Forms.ListBox lstFutter;
        private System.Windows.Forms.TextBox txtFutterKommentar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFutterVerpackung;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFutterBez;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabRationen;
        private System.Windows.Forms.Button btnRationLoeschen;
        private System.Windows.Forms.Button btnRationSpeichern;
        private System.Windows.Forms.ListBox lstRationen;
        private System.Windows.Forms.DateTimePicker dtpRationUhrzeit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRationMenge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboRationFutter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboRationTier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabUebersicht;
        private System.Windows.Forms.DataGridView dgvUebersicht;
        private TabPage tabFuetterungen;
        private ComboBox cboUebersichtTier;
        private Label Fütterungen;
        private DataGridView dgvFütterungen;
        private Button button1;
        private Button button2;
        private TabPage tabPflege;
        private DataGridView dgvBetreuer;
        private ComboBox cboZuordnungGehege;
        private Label label17;
        private CheckBox chkHauptpfleger;
        private ComboBox cboZuordnungPfleger;
        private Button btnEntfernen;
        private Button btnZuweisen;
        private RadioButton rbOhnePfleger;
        private RadioButton rbOhneHauptpfleger;
        private RadioButton rbAlleGehege;
        private Button button3;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Zeit;
        private DataGridViewTextBoxColumn Wer;
        private DataGridViewTextBoxColumn Was;
        private DataGridViewTextBoxColumn Wieviel;
    }
}
