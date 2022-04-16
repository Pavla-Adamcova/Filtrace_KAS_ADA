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
            ((System.ComponentModel.ISupportInitialize)(this.numObsah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            this.SuspendLayout();
            // 
            // listBDrogerie
            // 
            this.listBDrogerie.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBDrogerie.FormattingEnabled = true;
            this.listBDrogerie.ItemHeight = 28;
            this.listBDrogerie.Location = new System.Drawing.Point(13, 14);
            this.listBDrogerie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBDrogerie.Name = "listBDrogerie";
            this.listBDrogerie.Size = new System.Drawing.Size(404, 396);
            this.listBDrogerie.TabIndex = 0;
            this.listBDrogerie.SelectedIndexChanged += new System.EventHandler(this.listBDrogerie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 14);
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
            this.label2.Location = new System.Drawing.Point(935, 170);
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
            this.label4.Location = new System.Drawing.Point(887, 259);
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
            this.label5.Location = new System.Drawing.Point(981, 308);
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
            this.label6.Location = new System.Drawing.Point(897, 365);
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
            this.dateTP.Location = new System.Drawing.Point(1104, 367);
            this.dateTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(180, 30);
            this.dateTP.TabIndex = 19;
            this.dateTP.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            // 
            // numObsah
            // 
            this.numObsah.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numObsah.Location = new System.Drawing.Point(1104, 418);
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
            this.btEditovat.Location = new System.Drawing.Point(1073, 475);
            this.btEditovat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditovat.Name = "btEditovat";
            this.btEditovat.Size = new System.Drawing.Size(225, 83);
            this.btEditovat.TabIndex = 21;
            this.btEditovat.Text = "Editovat";
            this.btEditovat.UseVisualStyleBackColor = false;
            // 
            // btSmazat
            // 
            this.btSmazat.BackColor = System.Drawing.Color.Salmon;
            this.btSmazat.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSmazat.Location = new System.Drawing.Point(1307, 475);
            this.btSmazat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSmazat.Name = "btSmazat";
            this.btSmazat.Size = new System.Drawing.Size(222, 83);
            this.btSmazat.TabIndex = 22;
            this.btSmazat.Text = "Smazat";
            this.btSmazat.UseVisualStyleBackColor = false;
            // 
            // btVytvorit
            // 
            this.btVytvorit.BackColor = System.Drawing.Color.RosyBrown;
            this.btVytvorit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btVytvorit.Location = new System.Drawing.Point(839, 475);
            this.btVytvorit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btVytvorit.Name = "btVytvorit";
            this.btVytvorit.Size = new System.Drawing.Size(225, 83);
            this.btVytvorit.TabIndex = 23;
            this.btVytvorit.Text = "Vytvořit";
            this.btVytvorit.UseVisualStyleBackColor = false;
            this.btVytvorit.Click += new System.EventHandler(this.btVytvorit_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfo.Location = new System.Drawing.Point(8, 413);
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
            this.label12.Location = new System.Drawing.Point(13, 475);
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
            this.label13.Location = new System.Drawing.Point(13, 505);
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
            this.label14.Location = new System.Drawing.Point(13, 535);
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
            this.label15.Location = new System.Drawing.Point(13, 565);
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
            this.label16.Location = new System.Drawing.Point(13, 595);
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
            this.label17.Location = new System.Drawing.Point(13, 625);
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
            this.lbInfoZnacka.Location = new System.Drawing.Point(185, 476);
            this.lbInfoZnacka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoZnacka.Name = "lbInfoZnacka";
            this.lbInfoZnacka.Size = new System.Drawing.Size(0, 29);
            this.lbInfoZnacka.TabIndex = 35;
            // 
            // lbInfoCena
            // 
            this.lbInfoCena.AutoSize = true;
            this.lbInfoCena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoCena.Location = new System.Drawing.Point(185, 506);
            this.lbInfoCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoCena.Name = "lbInfoCena";
            this.lbInfoCena.Size = new System.Drawing.Size(0, 29);
            this.lbInfoCena.TabIndex = 36;
            // 
            // lbInfoDostupnost
            // 
            this.lbInfoDostupnost.AutoSize = true;
            this.lbInfoDostupnost.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoDostupnost.Location = new System.Drawing.Point(185, 536);
            this.lbInfoDostupnost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoDostupnost.Name = "lbInfoDostupnost";
            this.lbInfoDostupnost.Size = new System.Drawing.Size(0, 29);
            this.lbInfoDostupnost.TabIndex = 37;
            // 
            // lbInfoTyp
            // 
            this.lbInfoTyp.AutoSize = true;
            this.lbInfoTyp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoTyp.Location = new System.Drawing.Point(185, 566);
            this.lbInfoTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoTyp.Name = "lbInfoTyp";
            this.lbInfoTyp.Size = new System.Drawing.Size(0, 29);
            this.lbInfoTyp.TabIndex = 38;
            // 
            // lbInfoTrvanlivost
            // 
            this.lbInfoTrvanlivost.AutoSize = true;
            this.lbInfoTrvanlivost.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoTrvanlivost.Location = new System.Drawing.Point(185, 596);
            this.lbInfoTrvanlivost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoTrvanlivost.Name = "lbInfoTrvanlivost";
            this.lbInfoTrvanlivost.Size = new System.Drawing.Size(0, 29);
            this.lbInfoTrvanlivost.TabIndex = 39;
            // 
            // lbInfoObsah
            // 
            this.lbInfoObsah.AutoSize = true;
            this.lbInfoObsah.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoObsah.Location = new System.Drawing.Point(185, 626);
            this.lbInfoObsah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoObsah.Name = "lbInfoObsah";
            this.lbInfoObsah.Size = new System.Drawing.Size(0, 29);
            this.lbInfoObsah.TabIndex = 40;
            // 
            // lbDruh
            // 
            this.lbDruh.AutoSize = true;
            this.lbDruh.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDruh.Location = new System.Drawing.Point(966, 126);
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
            this.comBDruh.Location = new System.Drawing.Point(1106, 127);
            this.comBDruh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBDruh.Name = "comBDruh";
            this.comBDruh.Size = new System.Drawing.Size(180, 33);
            this.comBDruh.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(13, 443);
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
            this.lbInfoDruh.Location = new System.Drawing.Point(185, 444);
            this.lbInfoDruh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoDruh.Name = "lbInfoDruh";
            this.lbInfoDruh.Size = new System.Drawing.Size(0, 29);
            this.lbInfoDruh.TabIndex = 44;
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCena.Location = new System.Drawing.Point(966, 418);
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
            this.label8.Location = new System.Drawing.Point(961, 210);
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
            this.comBZnacka.Location = new System.Drawing.Point(1106, 167);
            this.comBZnacka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comBZnacka.Name = "comBZnacka";
            this.comBZnacka.Size = new System.Drawing.Size(180, 33);
            this.comBZnacka.TabIndex = 49;
            // 
            // numCena
            // 
            this.numCena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCena.Location = new System.Drawing.Point(1109, 210);
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
            this.rbNedostupny.Location = new System.Drawing.Point(1215, 261);
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
            this.rbDostupny.Location = new System.Drawing.Point(1102, 261);
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
            this.lbmlg.Location = new System.Drawing.Point(1302, 416);
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
            this.chbSucha.Location = new System.Drawing.Point(1102, 314);
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
            this.chbNormalni.Location = new System.Drawing.Point(1201, 314);
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
            this.chbMastna.Location = new System.Drawing.Point(1324, 314);
            this.chbMastna.Name = "chbMastna";
            this.chbMastna.Size = new System.Drawing.Size(103, 33);
            this.chbMastna.TabIndex = 56;
            this.chbMastna.Text = "Mastná";
            this.chbMastna.UseVisualStyleBackColor = true;
            this.chbMastna.CheckedChanged += new System.EventHandler(this.checkBox_Typ_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1554, 691);
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
    }
}

