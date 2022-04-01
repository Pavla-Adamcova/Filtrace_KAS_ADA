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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbZnacka = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.combPlet = new System.Windows.Forms.ComboBox();
            this.combTelo = new System.Windows.Forms.ComboBox();
            this.chbDostupnost_Ano = new System.Windows.Forms.CheckBox();
            this.chbDostupnostNe = new System.Windows.Forms.CheckBox();
            this.rbMastna = new System.Windows.Forms.RadioButton();
            this.rbVsechny = new System.Windows.Forms.RadioButton();
            this.rbSucha = new System.Windows.Forms.RadioButton();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.numObsah = new System.Windows.Forms.NumericUpDown();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btSmazat = new System.Windows.Forms.Button();
            this.btVytvorit = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbInfoPlet = new System.Windows.Forms.Label();
            this.lbInfoTelo = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.numObsah)).BeginInit();
            this.SuspendLayout();
            // 
            // listBDrogerie
            // 
            this.listBDrogerie.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBDrogerie.FormattingEnabled = true;
            this.listBDrogerie.ItemHeight = 20;
            this.listBDrogerie.Location = new System.Drawing.Point(12, 67);
            this.listBDrogerie.Name = "listBDrogerie";
            this.listBDrogerie.Size = new System.Drawing.Size(271, 444);
            this.listBDrogerie.TabIndex = 0;
            this.listBDrogerie.SelectedIndexChanged += new System.EventHandler(this.listBDrogerie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "DROGERIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(707, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Značka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(726, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(678, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dostupnost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(738, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Typ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(683, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trvanlivost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(716, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Obsah:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(707, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pro pleť:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(707, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pro tělo:";
            // 
            // tbZnacka
            // 
            this.tbZnacka.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbZnacka.Location = new System.Drawing.Point(822, 187);
            this.tbZnacka.Name = "tbZnacka";
            this.tbZnacka.Size = new System.Drawing.Size(121, 22);
            this.tbZnacka.TabIndex = 10;
            // 
            // tbCena
            // 
            this.tbCena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCena.Location = new System.Drawing.Point(822, 236);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(120, 22);
            this.tbCena.TabIndex = 11;
            // 
            // combPlet
            // 
            this.combPlet.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combPlet.FormattingEnabled = true;
            this.combPlet.Location = new System.Drawing.Point(822, 70);
            this.combPlet.Name = "combPlet";
            this.combPlet.Size = new System.Drawing.Size(121, 25);
            this.combPlet.TabIndex = 12;
            // 
            // combTelo
            // 
            this.combTelo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combTelo.FormattingEnabled = true;
            this.combTelo.Location = new System.Drawing.Point(822, 113);
            this.combTelo.Name = "combTelo";
            this.combTelo.Size = new System.Drawing.Size(121, 25);
            this.combTelo.TabIndex = 13;
            // 
            // chbDostupnost_Ano
            // 
            this.chbDostupnost_Ano.AutoSize = true;
            this.chbDostupnost_Ano.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbDostupnost_Ano.Location = new System.Drawing.Point(822, 287);
            this.chbDostupnost_Ano.Name = "chbDostupnost_Ano";
            this.chbDostupnost_Ano.Size = new System.Drawing.Size(49, 24);
            this.chbDostupnost_Ano.TabIndex = 14;
            this.chbDostupnost_Ano.Text = "Ano";
            this.chbDostupnost_Ano.UseVisualStyleBackColor = true;
            // 
            // chbDostupnostNe
            // 
            this.chbDostupnostNe.AutoSize = true;
            this.chbDostupnostNe.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbDostupnostNe.Location = new System.Drawing.Point(903, 287);
            this.chbDostupnostNe.Name = "chbDostupnostNe";
            this.chbDostupnostNe.Size = new System.Drawing.Size(43, 24);
            this.chbDostupnostNe.TabIndex = 15;
            this.chbDostupnostNe.Text = "Ne";
            this.chbDostupnostNe.UseVisualStyleBackColor = true;
            // 
            // rbMastna
            // 
            this.rbMastna.AutoSize = true;
            this.rbMastna.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMastna.Location = new System.Drawing.Point(822, 330);
            this.rbMastna.Name = "rbMastna";
            this.rbMastna.Size = new System.Drawing.Size(69, 24);
            this.rbMastna.TabIndex = 16;
            this.rbMastna.TabStop = true;
            this.rbMastna.Text = "Mastná";
            this.rbMastna.UseVisualStyleBackColor = true;
            this.rbMastna.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rbVsechny
            // 
            this.rbVsechny.AutoSize = true;
            this.rbVsechny.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbVsechny.Location = new System.Drawing.Point(897, 330);
            this.rbVsechny.Name = "rbVsechny";
            this.rbVsechny.Size = new System.Drawing.Size(72, 24);
            this.rbVsechny.TabIndex = 17;
            this.rbVsechny.TabStop = true;
            this.rbVsechny.Text = "Všechny";
            this.rbVsechny.UseVisualStyleBackColor = true;
            this.rbVsechny.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rbSucha
            // 
            this.rbSucha.AutoSize = true;
            this.rbSucha.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbSucha.Location = new System.Drawing.Point(984, 330);
            this.rbSucha.Name = "rbSucha";
            this.rbSucha.Size = new System.Drawing.Size(62, 24);
            this.rbSucha.TabIndex = 18;
            this.rbSucha.TabStop = true;
            this.rbSucha.Text = "Suchá";
            this.rbSucha.UseVisualStyleBackColor = true;
            this.rbSucha.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // dateTP
            // 
            this.dateTP.CustomFormat = "dd/MM/yy";
            this.dateTP.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP.Location = new System.Drawing.Point(822, 371);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(121, 22);
            this.dateTP.TabIndex = 19;
            this.dateTP.Value = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            // 
            // numObsah
            // 
            this.numObsah.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numObsah.Location = new System.Drawing.Point(822, 419);
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
            this.numObsah.Size = new System.Drawing.Size(120, 22);
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
            this.btEditovat.Location = new System.Drawing.Point(783, 468);
            this.btEditovat.Name = "btEditovat";
            this.btEditovat.Size = new System.Drawing.Size(150, 54);
            this.btEditovat.TabIndex = 21;
            this.btEditovat.Text = "Editovat";
            this.btEditovat.UseVisualStyleBackColor = false;
            // 
            // btSmazat
            // 
            this.btSmazat.BackColor = System.Drawing.Color.Salmon;
            this.btSmazat.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSmazat.Location = new System.Drawing.Point(939, 468);
            this.btSmazat.Name = "btSmazat";
            this.btSmazat.Size = new System.Drawing.Size(148, 54);
            this.btSmazat.TabIndex = 22;
            this.btSmazat.Text = "Smazat";
            this.btSmazat.UseVisualStyleBackColor = false;
            // 
            // btVytvorit
            // 
            this.btVytvorit.BackColor = System.Drawing.Color.RosyBrown;
            this.btVytvorit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btVytvorit.Location = new System.Drawing.Point(627, 468);
            this.btVytvorit.Name = "btVytvorit";
            this.btVytvorit.Size = new System.Drawing.Size(150, 54);
            this.btVytvorit.TabIndex = 23;
            this.btVytvorit.Text = "Vytvořit";
            this.btVytvorit.UseVisualStyleBackColor = false;
            this.btVytvorit.Click += new System.EventHandler(this.btVytvorit_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfo.Location = new System.Drawing.Point(373, 67);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(171, 21);
            this.lbInfo.TabIndex = 24;
            this.lbInfo.Text = "Informace o produktu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(316, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Pro pleť:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(318, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pro tělo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(320, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Značka:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(339, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 21);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cena:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(291, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 21);
            this.label14.TabIndex = 29;
            this.label14.Text = "Dostupnost:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(351, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 21);
            this.label15.TabIndex = 30;
            this.label15.Text = "Typ:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(294, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 21);
            this.label16.TabIndex = 31;
            this.label16.Text = "Trvanlivost:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(329, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 21);
            this.label17.TabIndex = 32;
            this.label17.Text = "Obsah:";
            // 
            // lbInfoPlet
            // 
            this.lbInfoPlet.AutoSize = true;
            this.lbInfoPlet.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoPlet.Location = new System.Drawing.Point(416, 102);
            this.lbInfoPlet.Name = "lbInfoPlet";
            this.lbInfoPlet.Size = new System.Drawing.Size(0, 20);
            this.lbInfoPlet.TabIndex = 33;
            // 
            // lbInfoTelo
            // 
            this.lbInfoTelo.AutoSize = true;
            this.lbInfoTelo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoTelo.Location = new System.Drawing.Point(416, 123);
            this.lbInfoTelo.Name = "lbInfoTelo";
            this.lbInfoTelo.Size = new System.Drawing.Size(0, 20);
            this.lbInfoTelo.TabIndex = 34;
            // 
            // lbInfoZnacka
            // 
            this.lbInfoZnacka.AutoSize = true;
            this.lbInfoZnacka.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoZnacka.Location = new System.Drawing.Point(416, 172);
            this.lbInfoZnacka.Name = "lbInfoZnacka";
            this.lbInfoZnacka.Size = new System.Drawing.Size(0, 20);
            this.lbInfoZnacka.TabIndex = 35;
            // 
            // lbInfoCena
            // 
            this.lbInfoCena.AutoSize = true;
            this.lbInfoCena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoCena.Location = new System.Drawing.Point(416, 193);
            this.lbInfoCena.Name = "lbInfoCena";
            this.lbInfoCena.Size = new System.Drawing.Size(0, 20);
            this.lbInfoCena.TabIndex = 36;
            // 
            // lbInfoDostupnost
            // 
            this.lbInfoDostupnost.AutoSize = true;
            this.lbInfoDostupnost.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoDostupnost.Location = new System.Drawing.Point(416, 214);
            this.lbInfoDostupnost.Name = "lbInfoDostupnost";
            this.lbInfoDostupnost.Size = new System.Drawing.Size(0, 20);
            this.lbInfoDostupnost.TabIndex = 37;
            // 
            // lbInfoTyp
            // 
            this.lbInfoTyp.AutoSize = true;
            this.lbInfoTyp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoTyp.Location = new System.Drawing.Point(416, 239);
            this.lbInfoTyp.Name = "lbInfoTyp";
            this.lbInfoTyp.Size = new System.Drawing.Size(0, 20);
            this.lbInfoTyp.TabIndex = 38;
            // 
            // lbInfoTrvanlivost
            // 
            this.lbInfoTrvanlivost.AutoSize = true;
            this.lbInfoTrvanlivost.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoTrvanlivost.Location = new System.Drawing.Point(416, 260);
            this.lbInfoTrvanlivost.Name = "lbInfoTrvanlivost";
            this.lbInfoTrvanlivost.Size = new System.Drawing.Size(0, 20);
            this.lbInfoTrvanlivost.TabIndex = 39;
            // 
            // lbInfoObsah
            // 
            this.lbInfoObsah.AutoSize = true;
            this.lbInfoObsah.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoObsah.Location = new System.Drawing.Point(416, 281);
            this.lbInfoObsah.Name = "lbInfoObsah";
            this.lbInfoObsah.Size = new System.Drawing.Size(0, 20);
            this.lbInfoObsah.TabIndex = 40;
            // 
            // lbDruh
            // 
            this.lbDruh.AutoSize = true;
            this.lbDruh.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDruh.Location = new System.Drawing.Point(725, 154);
            this.lbDruh.Name = "lbDruh";
            this.lbDruh.Size = new System.Drawing.Size(52, 21);
            this.lbDruh.TabIndex = 41;
            this.lbDruh.Text = "Druh:";
            // 
            // comBDruh
            // 
            this.comBDruh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBDruh.FormattingEnabled = true;
            this.comBDruh.Location = new System.Drawing.Point(821, 154);
            this.comBDruh.Name = "comBDruh";
            this.comBDruh.Size = new System.Drawing.Size(121, 25);
            this.comBDruh.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(339, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 21);
            this.label18.TabIndex = 43;
            this.label18.Text = "Druh:";
            // 
            // lbInfoDruh
            // 
            this.lbInfoDruh.AutoSize = true;
            this.lbInfoDruh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbInfoDruh.Location = new System.Drawing.Point(417, 155);
            this.lbInfoDruh.Name = "lbInfoDruh";
            this.lbInfoDruh.Size = new System.Drawing.Size(0, 20);
            this.lbInfoDruh.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1131, 549);
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
            this.Controls.Add(this.lbInfoTelo);
            this.Controls.Add(this.lbInfoPlet);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btVytvorit);
            this.Controls.Add(this.btSmazat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.numObsah);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.rbSucha);
            this.Controls.Add(this.rbVsechny);
            this.Controls.Add(this.rbMastna);
            this.Controls.Add(this.chbDostupnostNe);
            this.Controls.Add(this.chbDostupnost_Ano);
            this.Controls.Add(this.combTelo);
            this.Controls.Add(this.combPlet);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbZnacka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBDrogerie);
            this.Name = "Form1";
            this.Text = "Drogerie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numObsah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBDrogerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbZnacka;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.ComboBox combPlet;
        private System.Windows.Forms.ComboBox combTelo;
        private System.Windows.Forms.CheckBox chbDostupnost_Ano;
        private System.Windows.Forms.CheckBox chbDostupnostNe;
        private System.Windows.Forms.RadioButton rbMastna;
        private System.Windows.Forms.RadioButton rbVsechny;
        private System.Windows.Forms.RadioButton rbSucha;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.NumericUpDown numObsah;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.Button btSmazat;
        private System.Windows.Forms.Button btVytvorit;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbInfoPlet;
        private System.Windows.Forms.Label lbInfoTelo;
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
    }
}

