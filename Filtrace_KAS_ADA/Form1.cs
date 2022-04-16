using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Filtrace_KAS_ADA
{
    public partial class Form1 : Form
    {
        //deklarace sql
        SqlConnection sqlconnection;
        SqlCommand sqlCommandDrogerie;
        SqlCommand sqlCommandDruhy;
        SqlCommand sqlCommandZnacky;

        //List
        List<Drogerka> listDrogerka = new List<Drogerka>();

        //
        int Druh;
        int Znacka;
        int Cena;
        bool Dostupnost = false;
        string Typ;
        DateTime Trvanlivost;
        int Obsah;
        //listy
        List<string> ListDrogerie;
        List<string> ListZnacky;
        List<string> ListDruhy;
        //index
        int index = -1;
        
        public Form1()
        {
            InitializeComponent();

            //připojovací řetězec
            string retezecDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bubel\Documents\Pavlínka\PGV\DB-Drogerie.mdf;Integrated Security=True;Connect Timeout=30";

            //připojení
            sqlconnection = new SqlConnection(retezecDB);

            // command
            string commandDrogerie = "SELECT * FROM [Drogerie]";
            string commandDruhy = "SELECT * FROM [Druhy]";
            string commandZnacky = "SELECT * FROM [Znacky]";

            //sqlCommand
            sqlCommandDrogerie = new SqlCommand(commandDrogerie, sqlconnection);
            sqlCommandDruhy = new SqlCommand(commandDruhy, sqlconnection);
            sqlCommandZnacky = new SqlCommand(commandZnacky, sqlconnection);


            // otevření
            sqlconnection.Open();



            //práce s daty
            SqlDataReader zaznamyDrogerie = sqlCommandDrogerie.ExecuteReader();
            CteniTabulky(zaznamyDrogerie, 1);
            zaznamyDrogerie.Close();

            SqlDataReader zaznamyDruhy = sqlCommandDruhy.ExecuteReader();
            CteniTabulky(zaznamyDruhy, 2);
            zaznamyDruhy.Close();

            SqlDataReader zaznamyZnacky = sqlCommandZnacky.ExecuteReader();
            CteniTabulky(zaznamyZnacky, 3);
            zaznamyZnacky.Close();

            Vypis();

            //konec připojení
            sqlconnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comBDruh.SelectedIndex = 1;
            comBZnacka.SelectedIndex = 1;

        }

        private void btVytvorit_Click(object sender, EventArgs e)
        {
            //ošetření
            string cena = Convert.DBNull.ToString();
            if(numCena.Value >= 10 && numCena.Value <= 3000)
            {
                cena = numCena.Value.ToString();
            }

            string dostupnost = Convert.DBNull.ToString();
            dostupnost = Dostupnost.ToString();

            string typ = Convert.DBNull.ToString();
            typ = Typ;

            string obsah = Convert.DBNull.ToString();
            if(numObsah.Value >= 1 && numObsah.Value <= 500)
            {
                obsah = numObsah.Value.ToString();
            }
            int podminka1 = dateTP.Value.Year - DateTime.Now.Year;
            int podmina2 = DateTime.Now.Year - dateTP.Value.Year;
            if ((dateTP.Value.Year - DateTime.Now.Year <= 50) && (dateTP.Value.Year - DateTime.Now.Year > -1))
            {
                //command
                string insertCommand = $@"INSERT INTO [Drogerie] (Druh, Znacka, Cena, Dostupnost, Typ, Trvanlivost, Obsah) VALUES ('{comBDruh.SelectedIndex + 1}', '{comBZnacka.SelectedIndex + 1}', '{cena}', '{dostupnost}', '{typ}', '{dateTP.Value:MM-dd-yyy}', '{obsah}')";

                //otevření databáze
                sqlconnection.Open();

                SqlCommand sqlcommand = new SqlCommand(insertCommand, sqlconnection);

                sqlcommand.ExecuteNonQuery();

                sqlconnection.Close();
            }
            else
            {
                MessageBox.Show("Špatná trvanlivost - prošlé.");
            }
               
        }

        private void listBDrogerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = -1;
            lbInfoDruh.Text = lbInfoCena.Text = lbInfoDostupnost.Text = lbInfoObsah.Text = lbInfoTrvanlivost.Text = lbInfoTyp.Text = lbInfoZnacka.Text = "";
            index = listBDrogerie.SelectedIndex + 1;

            int IDDruhy = 0;
            int IDZnacka = 0;

            string ZnackyString = "";
            string DruhyString = "";

            foreach(Drogerka drogerka in listDrogerka)
            {
                

                
                //For pro Databazi Drogerka
                for (int i = 0; i < ListDrogerie.Count; i++)
                {
                    string dataDrogerka = "";
                    dataDrogerka = ListDrogerie[i].ToString();
                    string[] poleDrogerka = dataDrogerka.Split(';');
                    if(index == Convert.ToInt32(poleDrogerka[0]))
                    {
                        IDDruhy = Convert.ToInt32(poleDrogerka[1]);
                        IDZnacka =  Convert.ToInt32(poleDrogerka[2]);
                        lbInfoCena.Text = poleDrogerka[3] + " Kč";
                        if(Convert.ToBoolean(poleDrogerka[4]) == true)
                        {
                            lbInfoDostupnost.Text = "Dostupné";
                        }
                        else
                        {
                            lbInfoDostupnost.Text = "Nedostupné";
                        }
                        lbInfoTyp.Text = poleDrogerka[5];
                        lbInfoTrvanlivost.Text = poleDrogerka[6];
                        lbInfoObsah.Text = poleDrogerka[7] + " ml/g";
                    }
                    for (int j = 0; j < ListDruhy.Count; j++)
                    {
                        string dataDruhy = "";
                        dataDruhy = ListDruhy[j].ToString();
                        string[] poleDruhy = dataDruhy.Split(';');
                        if (IDDruhy == Convert.ToInt32(poleDruhy[0]))
                        {
                            lbInfoDruh.Text = poleDruhy[1];
                            break;
                        }
                    }
                    for (int k = 0; k < ListZnacky.Count; k++)
                    {
                        string dataZnacky = "";
                        dataZnacky = ListZnacky[k].ToString();
                        string[] poleZnacky = dataZnacky.Split(';');
                        if (IDZnacka == Convert.ToInt32(poleZnacky[0]))
                        {
                            lbInfoZnacka.Text = poleZnacky[1];
                            break;
                        }
                    }
                }
    
            }    

        }

        private void Vypis()
        {
            listBDrogerie.Items.Clear();
            int IDDruhy = 0;
            int IDZnacka = 0;

            string ZnackyString = "";
            string DruhyString = "";

            foreach(Drogerka drogerka in listDrogerka)
            {
                IDDruhy = drogerka.Druh;
                IDZnacka = drogerka.Znacka;

                for (int i = 0; i < ListDruhy.Count; i++)
                {
                    string dataDruhy = "";
                    dataDruhy = ListDruhy[i].ToString();
                    string[] poleDruhy = dataDruhy.Split(';');
                    if (IDDruhy == Convert.ToInt32(poleDruhy[0]))
                    {
                        DruhyString = poleDruhy[1];
                    }
                }
                for (int k = 0; k < ListZnacky.Count; k++)
                {
                    string dataZnacky = "";
                    dataZnacky = ListZnacky[k].ToString();
                    string[] poleZnacky = dataZnacky.Split(';');
                    if (IDZnacka == Convert.ToInt32(poleZnacky[0]))
                    {
                        ZnackyString = poleZnacky[1];
                    }
                }
                listBDrogerie.Items.Add(DruhyString + " - " + ZnackyString);
            }
        }

        private void CteniTabulky(SqlDataReader tabulka, int typ)
        {
            switch (typ)
            {
                case 1:
                    {
                        ListDrogerie = new List<string>();
                        while (tabulka.Read())
                          {
                                string polozka = "";
                                //do stringu
                                polozka = tabulka[0].ToString() + ";" + tabulka[1].ToString() + ";" + tabulka[2].ToString() + ";" + tabulka[3].ToString() + ";" + tabulka[4].ToString() + ";" + tabulka[5].ToString() + ";" + tabulka[6].ToString() + ";" + tabulka[7].ToString();
                                Druh = Convert.ToInt32(tabulka[1]);
                                Znacka = Convert.ToInt32(tabulka[2]);
                                Cena = Convert.ToInt32(tabulka[3]);
                                Dostupnost = Convert.ToBoolean(tabulka[4]);
                                Typ = Convert.ToString(tabulka[5]);
                                Trvanlivost = Convert.ToDateTime(tabulka[6]);
                                Obsah = Convert.ToInt32(tabulka[7]);
                                ListDrogerie.Add(polozka);
                                //do třídy
                               
                                Drogerka drogerkaPolozka = new Drogerka(Druh, Znacka, Cena, Dostupnost, Typ, Trvanlivost, Obsah);
                                listDrogerka.Add(drogerkaPolozka);

                        }
                        break;
                    }
                case 2:
                    {
                        ListDruhy = new List<string>();
                        while (tabulka.Read())
                        {
                            string polozka = "";
                            polozka = tabulka[0].ToString() + ";" + tabulka[1].ToString();
                            ListDruhy.Add(polozka);
                        }
                        break;
                    }
                case 3:
                    {
                        ListZnacky = new List<string>();
                        while (tabulka.Read())
                        {
                            string polozka = "";
                            polozka = tabulka[0].ToString() + ";" + tabulka[1].ToString();
                            ListZnacky.Add(polozka);
                        }
                        break;
                    }
            }


        }
        private void rbDostupnost_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDostupny.Checked == true)
            {
                Dostupnost = true;
            }
            else if(rbNedostupny.Checked == true)
            {
                Dostupnost = false;
            }
        }
        private void checkBox_Typ_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSucha.Checked == true)
            {
                Typ = chbSucha.Text;
                chbNormalni.Checked = chbMastna.Checked = false;
                chbNormalni.Enabled = chbMastna.Enabled = false;
            } else if (chbNormalni.Checked == true)
            {
                Typ = chbNormalni.Text;
                chbSucha.Checked = chbMastna.Checked = false;
                chbSucha.Enabled = chbMastna.Enabled = false;
            }
            else if (chbMastna.Checked == true)
            {
                Typ = chbMastna.Text;
                chbNormalni.Checked = chbSucha.Checked = false;
                chbNormalni.Enabled = chbSucha.Enabled = false;
            }
        }

        private void btSmazat_Click(object sender, EventArgs e)
        {
            ////command
            //string insertCommand = $@"DELETE FROM Drogerie WHERE Id "(Druh, Znacka, Cena, Dostupnost, Typ, Trvanlivost, Obsah) VALUES ('{comBDruh.SelectedIndex + 1}', '{comBZnacka.SelectedIndex + 1}', '{cena}', '{dostupnost}', '{typ}', '{dateTP.Value:MM-dd-yyy}', '{obsah}')";

            ////otevření databáze
            //sqlconnection.Open();

            //SqlCommand sqlcommand = new SqlCommand(insertCommand, sqlconnection);

            //sqlcommand.ExecuteNonQuery();

            //sqlconnection.Close();
            //Vypis();
        }

        private void btFiltrovat_Click(object sender, EventArgs e)
        {
            int filtrDruh = comBDruh.SelectedIndex;
            int filtrZnacka = comBZnacka.SelectedIndex;
            int filtrCena = Convert.ToInt32(numCena.Value);
            bool filtrDostupnost = Dostupnost;
            string filtrTyp = Typ;
            int filtrTrvanlivost = dateTP.Value.Year;

            int Druhy = 0;
            int Znacka = 0;
            string DruhyString = "";
            string ZnackyString = "";
            foreach(Drogerka drogerka in listDrogerka)
            {
                for(int i = 0; i < ListDrogerie.Count; i++)
                {
                    string record = ListDrogerie[i].ToString();
                    string[] poleDrogerie = record.Split(';');
                    DateTime trvalnivostDATETIMERok = Convert.ToDateTime(poleDrogerie[6]);
                    int trvanlivostINTRok = trvalnivostDATETIMERok.Year;
                    if(filtrDruh == Convert.ToInt32(poleDrogerie[1]) || filtrZnacka == Convert.ToInt32(poleDrogerie[2]) || filtrCena > Convert.ToInt32(poleDrogerie[3]) || filtrDostupnost == Convert.ToBoolean(poleDrogerie[4]) || filtrTyp == poleDrogerie[5] || ((trvanlivostINTRok - filtrTrvanlivost) > 0))
                    {
                        listBDrogerie.Items.Clear();
                        int IDDruhy = Convert.ToInt32(poleDrogerie[1]);
                        int IDZnacka = Convert.ToInt32(poleDrogerie[2]);
                        for (int j = 0; j < ListDruhy.Count; j++)
                        {
                            string dataDruhy = "";
                            dataDruhy = ListDruhy[j].ToString();
                            string[] poleDruhy = dataDruhy.Split(';');
                            if (IDDruhy == Convert.ToInt32(poleDruhy[0]))
                            {
                                DruhyString = poleDruhy[1];
                            }
                        }
                        for (int k = 0; k < ListZnacky.Count; k++)
                        {
                            string dataZnacky = "";
                            dataZnacky = ListZnacky[k].ToString();
                            string[] poleZnacky = dataZnacky.Split(';');
                            if (IDZnacka == Convert.ToInt32(poleZnacky[0]))
                            {
                                ZnackyString = poleZnacky[1];
                            }
                        }
                        listBDrogerie.Items.Add(DruhyString + " - " + ZnackyString);
                    }
                }
            }

        }
    }
}
