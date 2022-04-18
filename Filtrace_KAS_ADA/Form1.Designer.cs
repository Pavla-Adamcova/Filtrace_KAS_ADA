namespace Filtrace_KAS_ADA
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBDrogerie = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.numObsah = new System.Windows.Forms.NumericUpDown();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btSmazat = new System.Windows.Forms.Button();
            this.btVytvorit = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbInfoZnacka = new System.Windows.Forms.Label();
            this.lbInfoCena = new System.Windows.Forms.Label();
            this.lbInfoDostupnost = new System.Windows.Forms.Label();
            this.lbInfoTyp = new System.Windows.Forms.Label();
            this.lbInfoTrvanlivost = new System.Windows.Forms.Label();
            this.lbInfoObsah = new System.Windows.Forms.Label();
            this.lbDruh = new System.Windows.Forms.Label();
            this.comBDruh = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbInfoDruh = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comBZnacka = new System.Windows.Forms.ComboBox();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.rbNedostupny = new System.Windows.Forms.RadioButton();
            this.rbDostupny = new System.Windows.Forms.RadioButton();
            this.lbmlg = new System.Windows.Forms.Label();
            this.chbSucha = new System.Windows.Forms.CheckBox();
            this.chbNormalni = new System.Windows.Forms.CheckBox();
            this.chbMastna = new System.Windows.Forms.CheckBox();
            this.btFiltrovat = new System.Windows.Forms.Button();
            this.comBFiltrZnacka = new System.Windows.Forms.ComboBox();
            this.comBFiltrDruh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFiltr = new System.Windows.Forms.Label();
            this.numFiltrCenaOd = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numFiltrCenaDo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbFiltrNedostupny = new System.Windows.Forms.RadioButton();
            this.rbFiltrDostupny = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.chbFiltrMastna = new System.Windows.Forms.CheckBox();
            this.chBFiltrNormalni = new System.Windows.Forms.CheckBox();
            this.chbFiltrSucha = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numObsah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltrCenaOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltrCenaDo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBDrogerie
            // 
            this.listBDrogerie.BackColor = System.Drawing.SystemColors.Menu;
            this.listBDrogerie.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBDrogerie.FormattingEnabled = true;
            this.listBDrogerie.ItemHeight = 28;
            this.listBDrogerie.Location = new System.Drawing.Point(18, 14);
            this.listBDrogerie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBDrogerie.Name = "listBDrogerie";
            this.listBDrogerie.Size = new System.Drawing.Size(404, 368);
            this.listBDrogerie.TabIndex = 0;
            this.listBDrogerie.SelectedIndexChanged += new System.EventHandler(this.listBDrogerie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "DROGERIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(452, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Značka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(452, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dostupnost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(452, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Typ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(452, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trvanlivost:";
            // 
            // dateTP
            // 
            this.dateTP.CustomFormat = "dd/MM/yy";
            this.dateTP.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP.Location = new System.Drawing.Point(619, 284);
            this.dateTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(180, 30);
            this.dateTP.TabIndex = 19;
            this.dateTP.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            // 
            // numObsah
            // 
            this.numObsah.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numObsah.Location = new System.Drawing.Point(619, 329);
            this.numObsah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numObsah.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numObsah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numObsah.Name = "numObsah";
            this.numObsah.Size = new System.Drawing.Size(180, 30);
            this.numObsah.TabIndex = 20;
            this.numObsah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btEditovat
            // 
            this.btEditovat.BackColor = System.Drawing.Color.PeachPuff;
            this.btEditovat.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEditovat.Location = new System.Drawing.Point(626, 383);
            this.btEditovat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditovat.Name = "btEditovat";
            this.btEditovat.Size = new System.Drawing.Size(155, 83);
            this.btEditovat.TabIndex = 21;
            this.btEditovat.Text = "Editovat";
            this.btEditovat.UseVisualStyleBackColor = false;
            // 
            // btSmazat
            // 
            this.btSmazat.BackColor = System.Drawing.Color.Salmon;
            this.btSmazat.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSmazat.Location = new System.Drawing.Point(780, 383);
            this.btSmazat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSmazat.Name = "btSmazat";
            this.btSmazat.Size = new System.Drawing.Size(147, 83);
            this.btSmazat.TabIndex = 22;
            this.btSmazat.Text = "Smazat";
            this.btSmazat.UseVisualStyleBackColor = false;
            this.btSmazat.Click += new System.EventHandler(this.btSmazat_Click);
            // 
            // btVytvorit
            // 
            this.btVytvorit.BackColor = System.Drawing.Color.RosyBrown;
            this.btVytvorit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btVytvorit.Location = new System.Drawing.Point(457, 383);
            this.btVytvorit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btVytvorit.Name = "btVytvorit";
            this.btVytvorit.Size = new System.Drawing.Size(168, 83);
            this.btVytvorit.TabIndex = 23;
            this.btVytvorit.Text = "Vytvořit";
            this.btVytvorit.UseVisualStyleBackColor = false;
            this.btVytvorit.Click += new System.EventHandler(this.btVytvorit_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfo.Location = new System.Drawing.Point(13, 383);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(257, 30);
            this.lbInfo.TabIndex = 24;
            this.lbInfo.Text = "Informace o produktu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(13, 445);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 30);
            this.label12.TabIndex = 27;
            this.label12.Text = "Značka:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(13, 475);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 30);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cena:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(13, 505);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 30);
            this.label14.TabIndex = 29;
            this.label14.Text = "Dostupnost:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(13, 535);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 30);
            this.label15.TabIndex = 30;
            this.label15.Text = "Typ:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(13, 565);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 30);
            this.label16.TabIndex = 31;
            this.label16.Text = "Trvanlivost:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(13, 595);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 30);
            this.label17.TabIndex = 32;
            this.label17.Text = "Obsah:";
            // 
            // lbInfoZnacka
            // 
            this.lbInfoZnacka.AutoSize = true;
            this.lbInfoZnacka.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoZnacka.Location = new System.Drawing.Point(185, 446);
            this.lbInfoZnacka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoZnacka.Name = "lbInfoZnacka";
            this.lbInfoZnacka.Size = new System.Drawing.Size(0, 29);
            this.lbInfoZnacka.TabIndex = 35;
            // 
            // lbInfoCena
            // 
            this.lbInfoCena.AutoSize = true;
            this.lbInfoCena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoCena.Location = new System.Drawing.Point(185, 476);
            this.lbInfoCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoCena.Name = "lbInfoCena";
            this.lbInfoCena.Size = new System.Drawing.Size(0, 29);
            this.lbInfoCena.TabIndex = 36;
            // 
            // lbInfoDostupnost
            // 
            this.lbInfoDostupnost.AutoSize = true;
            this.lbInfoDostupnost.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoDostupnost.Location = new System.Drawing.Point(185, 506);
            this.lbInfoDostupnost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoDostupnost.Name = "lbInfoDostupnost";
            this.lbInfoDostupnost.Size = new System.Drawing.Size(0, 29);
            this.lbInfoDostupnost.TabIndex = 37;
            // 
            // lbInfoTyp
            // 
            this.lbInfoTyp.AutoSize = true;
            this.lbInfoTyp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoTyp.Location = new System.Drawing.Point(185, 536);
            this.lbInfoTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoTyp.Name = "lbInfoTyp";
            this.lbInfoTyp.Size = new System.Drawing.Size(0, 29);
            this.lbInfoTyp.TabIndex = 38;
            // 
            // lbInfoTrvanlivost
            // 
            this.lbInfoTrvanlivost.AutoSize = true;
            this.lbInfoTrvanlivost.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoTrvanlivost.Location = new System.Drawing.Point(185, 566);
            this.lbInfoTrvanlivost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoTrvanlivost.Name = "lbInfoTrvanlivost";
            this.lbInfoTrvanlivost.Size = new System.Drawing.Size(0, 29);
            this.lbInfoTrvanlivost.TabIndex = 39;
            // 
            // lbInfoObsah
            // 
            this.lbInfoObsah.AutoSize = true;
            this.lbInfoObsah.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoObsah.Location = new System.Drawing.Point(185, 596);
            this.lbInfoObsah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoObsah.Name = "lbInfoObsah";
            this.lbInfoObsah.Size = new System.Drawing.Size(0, 29);
            this.lbInfoObsah.TabIndex = 40;
            // 
            // lbDruh
            // 
            this.lbDruh.AutoSize = true;
            this.lbDruh.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDruh.Location = new System.Drawing.Point(452, 79);
            this.lbDruh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDruh.Name = "lbDruh";
            this.lbDruh.Size = new System.Drawing.Size(74, 30);
            this.lbDruh.TabIndex = 41;
            this.lbDruh.Text = "Druh:";
            // 
            // comBDruh
            // 
            this.comBDruh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBDruh.FormattingEnabled = true;
            this.comBDruh.Items.AddRange(new object[] {
            "MakeUp",
            "Rtěnka",
            "Tužka na obočí",
            "Paletka",
            "Šampón",
            "Lak na nehty",
            "Pěna na holení",
            "Mýdlo"});
            this.comBDruh.Location = new System.Drawing.Point(623, 76);
            this.comBDruh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBDruh.Name = "comBDruh";
            this.comBDruh.Size = new System.Drawing.Size(180, 33);
            this.comBDruh.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(13, 413);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 30);
            this.label18.TabIndex = 43;
            this.label18.Text = "Druh:";
            // 
            // lbInfoDruh
            // 
            this.lbInfoDruh.AutoSize = true;
            this.lbInfoDruh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoDruh.Location = new System.Drawing.Point(185, 414);
            this.lbInfoDruh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoDruh.Name = "lbInfoDruh";
            this.lbInfoDruh.Size = new System.Drawing.Size(0, 29);
            this.lbInfoDruh.TabIndex = 44;
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCena.Location = new System.Drawing.Point(452, 327);
            this.lbCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(90, 30);
            this.lbCena.TabIndex = 45;
            this.lbCena.Text = "Obsah:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(452, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cena:";
            // 
            // comBZnacka
            // 
            this.comBZnacka.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBZnacka.FormattingEnabled = true;
            this.comBZnacka.Items.AddRange(new object[] {
            "L\'Oreál",
            "MAC",
            "NYX",
            "Maybelline",
            "Revolution",
            "Dove",
            "Gillette",
            "Rimmel"});
            this.comBZnacka.Location = new System.Drawing.Point(623, 116);
            this.comBZnacka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBZnacka.Name = "comBZnacka";
            this.comBZnacka.Size = new System.Drawing.Size(180, 33);
            this.comBZnacka.TabIndex = 49;
            // 
            // numCena
            // 
            this.numCena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCena.Location = new System.Drawing.Point(626, 159);
            this.numCena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCena.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numCena.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(180, 30);
            this.numCena.TabIndex = 50;
            this.numCena.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // rbNedostupny
            // 
            this.rbNedostupny.AutoSize = true;
            this.rbNedostupny.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbNedostupny.Location = new System.Drawing.Point(733, 197);
            this.rbNedostupny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNedostupny.Name = "rbNedostupny";
            this.rbNedostupny.Size = new System.Drawing.Size(139, 33);
            this.rbNedostupny.TabIndex = 52;
            this.rbNedostupny.Text = "Nedostupný";
            this.rbNedostupny.UseVisualStyleBackColor = true;
            this.rbNedostupny.CheckedChanged += new System.EventHandler(this.rbDostupnost_CheckedChanged);
            // 
            // rbDostupny
            // 
            this.rbDostupny.AutoSize = true;
            this.rbDostupny.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDostupny.Location = new System.Drawing.Point(619, 199);
            this.rbDostupny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDostupny.Name = "rbDostupny";
            this.rbDostupny.Size = new System.Drawing.Size(118, 33);
            this.rbDostupny.TabIndex = 51;
            this.rbDostupny.Text = "Dostupný";
            this.rbDostupny.UseVisualStyleBackColor = true;
            this.rbDostupny.CheckedChanged += new System.EventHandler(this.rbDostupnost_CheckedChanged);
            // 
            // lbmlg
            // 
            this.lbmlg.AutoSize = true;
            this.lbmlg.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbmlg.Location = new System.Drawing.Point(807, 329);
            this.lbmlg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmlg.Name = "lbmlg";
            this.lbmlg.Size = new System.Drawing.Size(67, 30);
            this.lbmlg.TabIndex = 53;
            this.lbmlg.Text = "ml/g";
            // 
            // chbSucha
            // 
            this.chbSucha.AutoSize = true;
            this.chbSucha.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.chbSucha.Location = new System.Drawing.Point(621, 243);
            this.chbSucha.Name = "chbSucha";
            this.chbSucha.Size = new System.Drawing.Size(93, 33);
            this.chbSucha.TabIndex = 54;
            this.chbSucha.Text = "Suchá";
            this.chbSucha.UseVisualStyleBackColor = true;
            this.chbSucha.CheckedChanged += new System.EventHandler(this.checkBox_Typ_CheckedChanged);
            // 
            // chbNormalni
            // 
            this.chbNormalni.AutoSize = true;
            this.chbNormalni.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.chbNormalni.Location = new System.Drawing.Point(718, 243);
            this.chbNormalni.Name = "chbNormalni";
            this.chbNormalni.Size = new System.Drawing.Size(117, 33);
            this.chbNormalni.TabIndex = 55;
            this.chbNormalni.Text = "Normální";
            this.chbNormalni.UseVisualStyleBackColor = true;
            this.chbNormalni.CheckedChanged += new System.EventHandler(this.checkBox_Typ_CheckedChanged);
            // 
            // chbMastna
            // 
            this.chbMastna.AutoSize = true;
            this.chbMastna.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.chbMastna.Location = new System.Drawing.Point(841, 243);
            this.chbMastna.Name = "chbMastna";
            this.chbMastna.Size = new System.Drawing.Size(103, 33);
            this.chbMastna.TabIndex = 56;
            this.chbMastna.Text = "Mastná";
            this.chbMastna.UseVisualStyleBackColor = true;
            this.chbMastna.CheckedChanged += new System.EventHandler(this.checkBox_Typ_CheckedChanged);
            // 
            // btFiltrovat
            // 
            this.btFiltrovat.BackColor = System.Drawing.Color.PeachPuff;
            this.btFiltrovat.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btFiltrovat.Location = new System.Drawing.Point(1145, 383);
            this.btFiltrovat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFiltrovat.Name = "btFiltrovat";
            this.btFiltrovat.Size = new System.Drawing.Size(225, 83);
            this.btFiltrovat.TabIndex = 57;
            this.btFiltrovat.Text = "Filtrovat";
            this.btFiltrovat.UseVisualStyleBackColor = false;
            this.btFiltrovat.Click += new System.EventHandler(this.btFiltrovat_Click);
            // 
            // comBFiltrZnacka
            // 
            this.comBFiltrZnacka.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBFiltrZnacka.FormattingEnabled = true;
            this.comBFiltrZnacka.Items.AddRange(new object[] {
            "L\'Oreál",
            "MAC",
            "NYX",
            "Maybelline",
            "Revolution",
            "Dove",
            "Gillette",
            "Rimmel"});
            this.comBFiltrZnacka.Location = new System.Drawing.Point(1179, 112);
            this.comBFiltrZnacka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBFiltrZnacka.Name = "comBFiltrZnacka";
            this.comBFiltrZnacka.Size = new System.Drawing.Size(180, 33);
            this.comBFiltrZnacka.TabIndex = 61;
            // 
            // comBFiltrDruh
            // 
            this.comBFiltrDruh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBFiltrDruh.FormattingEnabled = true;
            this.comBFiltrDruh.Items.AddRange(new object[] {
            "MakeUp",
            "Rtěnka",
            "Tužka na obočí",
            "Paletka",
            "Šampón",
            "Lak na nehty",
            "Pěna na holení",
            "Mýdlo"});
            this.comBFiltrDruh.Location = new System.Drawing.Point(1179, 72);
            this.comBFiltrDruh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBFiltrDruh.Name = "comBFiltrDruh";
            this.comBFiltrDruh.Size = new System.Drawing.Size(180, 33);
            this.comBFiltrDruh.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1008, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 59;
            this.label3.Text = "Druh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1008, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 58;
            this.label7.Text = "Značka:";
            // 
            // lbFiltr
            // 
            this.lbFiltr.AutoSize = true;
            this.lbFiltr.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltr.Location = new System.Drawing.Point(1215, 14);
            this.lbFiltr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiltr.Name = "lbFiltr";
            this.lbFiltr.Size = new System.Drawing.Size(109, 51);
            this.lbFiltr.TabIndex = 62;
            this.lbFiltr.Text = "FILTR";
            // 
            // numFiltrCenaOd
            // 
            this.numFiltrCenaOd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numFiltrCenaOd.Location = new System.Drawing.Point(1179, 155);
            this.numFiltrCenaOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numFiltrCenaOd.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numFiltrCenaOd.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFiltrCenaOd.Name = "numFiltrCenaOd";
            this.numFiltrCenaOd.Size = new System.Drawing.Size(95, 30);
            this.numFiltrCenaOd.TabIndex = 64;
            this.numFiltrCenaOd.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1005, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 30);
            this.label9.TabIndex = 63;
            this.label9.Text = "Cena:";
            // 
            // numFiltrCenaDo
            // 
            this.numFiltrCenaDo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numFiltrCenaDo.Location = new System.Drawing.Point(1327, 155);
            this.numFiltrCenaDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numFiltrCenaDo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numFiltrCenaDo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFiltrCenaDo.Name = "numFiltrCenaDo";
            this.numFiltrCenaDo.Size = new System.Drawing.Size(95, 30);
            this.numFiltrCenaDo.TabIndex = 65;
            this.numFiltrCenaDo.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(1128, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 30);
            this.label10.TabIndex = 66;
            this.label10.Text = "od";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(1281, 153);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 30);
            this.label11.TabIndex = 67;
            this.label11.Text = "do";
            // 
            // rbFiltrNedostupny
            // 
            this.rbFiltrNedostupny.AutoSize = true;
            this.rbFiltrNedostupny.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbFiltrNedostupny.Location = new System.Drawing.Point(1293, 195);
            this.rbFiltrNedostupny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFiltrNedostupny.Name = "rbFiltrNedostupny";
            this.rbFiltrNedostupny.Size = new System.Drawing.Size(139, 33);
            this.rbFiltrNedostupny.TabIndex = 70;
            this.rbFiltrNedostupny.Text = "Nedostupný";
            this.rbFiltrNedostupny.UseVisualStyleBackColor = true;
            // 
            // rbFiltrDostupny
            // 
            this.rbFiltrDostupny.AutoSize = true;
            this.rbFiltrDostupny.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbFiltrDostupny.Location = new System.Drawing.Point(1179, 197);
            this.rbFiltrDostupny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFiltrDostupny.Name = "rbFiltrDostupny";
            this.rbFiltrDostupny.Size = new System.Drawing.Size(118, 33);
            this.rbFiltrDostupny.TabIndex = 69;
            this.rbFiltrDostupny.Text = "Dostupný";
            this.rbFiltrDostupny.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(1005, 195);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 30);
            this.label19.TabIndex = 68;
            this.label19.Text = "Dostupnost:";
            // 
            // chbFiltrMastna
            // 
            this.chbFiltrMastna.AutoSize = true;
            this.chbFiltrMastna.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.chbFiltrMastna.Location = new System.Drawing.Point(1395, 236);
            this.chbFiltrMastna.Name = "chbFiltrMastna";
            this.chbFiltrMastna.Size = new System.Drawing.Size(103, 33);
            this.chbFiltrMastna.TabIndex = 74;
            this.chbFiltrMastna.Text = "Mastná";
            this.chbFiltrMastna.UseVisualStyleBackColor = true;
            // 
            // chBFiltrNormalni
            // 
            this.chBFiltrNormalni.AutoSize = true;
            this.chBFiltrNormalni.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.chBFiltrNormalni.Location = new System.Drawing.Point(1272, 236);
            this.chBFiltrNormalni.Name = "chBFiltrNormalni";
            this.chBFiltrNormalni.Size = new System.Drawing.Size(117, 33);
            this.chBFiltrNormalni.TabIndex = 73;
            this.chBFiltrNormalni.Text = "Normální";
            this.chBFiltrNormalni.UseVisualStyleBackColor = true;
            // 
            // chbFiltrSucha
            // 
            this.chbFiltrSucha.AutoSize = true;
            this.chbFiltrSucha.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.chbFiltrSucha.Location = new System.Drawing.Point(1175, 236);
            this.chbFiltrSucha.Name = "chbFiltrSucha";
            this.chbFiltrSucha.Size = new System.Drawing.Size(93, 33);
            this.chbFiltrSucha.TabIndex = 72;
            this.chbFiltrSucha.Text = "Suchá";
            this.chbFiltrSucha.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(1006, 236);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 30);
            this.label20.TabIndex = 71;
            this.label20.Text = "Typ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1554, 637);
            this.Controls.Add(this.chbFiltrMastna);
            this.Controls.Add(this.chBFiltrNormalni);
            this.Controls.Add(this.chbFiltrSucha);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.rbFiltrNedostupny);
            this.Controls.Add(this.rbFiltrDostupny);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numFiltrCenaDo);
            this.Controls.Add(this.numFiltrCenaOd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbFiltr);
            this.Controls.Add(this.comBFiltrZnacka);
            this.Controls.Add(this.comBFiltrDruh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btFiltrovat);
            this.Controls.Add(this.chbMastna);
            this.Controls.Add(this.chbNormalni);
            this.Controls.Add(this.chbSucha);
            this.Controls.Add(this.lbmlg);
            this.Controls.Add(this.rbNedostupny);
            this.Controls.Add(this.rbDostupny);
            this.Controls.Add(this.numCena);
            this.Controls.Add(this.comBZnacka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbInfoDruh);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comBDruh);
            this.Controls.Add(this.lbDruh);
            this.Controls.Add(this.lbInfoObsah);
            this.Controls.Add(this.lbInfoTrvanlivost);
            this.Controls.Add(this.lbInfoTyp);
            this.Controls.Add(this.lbInfoDostupnost);
            this.Controls.Add(this.lbInfoCena);
            this.Controls.Add(this.lbInfoZnacka);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btVytvorit);
            this.Controls.Add(this.btSmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.numObsah);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBDrogerie);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Drogerie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numObsah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltrCenaOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltrCenaDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBDrogerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.NumericUpDown numObsah;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.Button btSmazat;
        private System.Windows.Forms.Button btVytvorit;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbInfoZnacka;
        private System.Windows.Forms.Label lbInfoCena;
        private System.Windows.Forms.Label lbInfoDostupnost;
        private System.Windows.Forms.Label lbInfoTyp;
        private System.Windows.Forms.Label lbInfoTrvanlivost;
        private System.Windows.Forms.Label lbInfoObsah;
        private System.Windows.Forms.Label lbDruh;
        private System.Windows.Forms.ComboBox comBDruh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbInfoDruh;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comBZnacka;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.RadioButton rbNedostupny;
        private System.Windows.Forms.RadioButton rbDostupny;
        private System.Windows.Forms.Label lbmlg;
        private System.Windows.Forms.CheckBox chbSucha;
        private System.Windows.Forms.CheckBox chbNormalni;
        private System.Windows.Forms.CheckBox chbMastna;
        private System.Windows.Forms.Button btFiltrovat;
        private System.Windows.Forms.ComboBox comBFiltrZnacka;
        private System.Windows.Forms.ComboBox comBFiltrDruh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFiltr;
        private System.Windows.Forms.NumericUpDown numFiltrCenaOd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numFiltrCenaDo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbFiltrNedostupny;
        private System.Windows.Forms.RadioButton rbFiltrDostupny;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chbFiltrMastna;
        private System.Windows.Forms.CheckBox chBFiltrNormalni;
        private System.Windows.Forms.CheckBox chbFiltrSucha;
        private System.Windows.Forms.Label label20;
    }
}

