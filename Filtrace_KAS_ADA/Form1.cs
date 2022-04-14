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
        bool Dostupnost;
        string Typ;
        DateTime Trvanlivost;
        int Obsah;
        string DruhyString;
        string ZnackyString;
        //listy
        List<string> ListDrogerie;
        List<string> ListZnacky;
        List<string> ListDruhy;
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
        
        }

        private void btVytvorit_Click(object sender, EventArgs e)
        {
            //command
           // string insertCommand = $@"INSERT INTO [Drogerie] (Id, Druh, Znacka, Cena, Dostupnost, Typ, Trvanlivost, Obsah, Plet, Telo) VALUES ('{tb}');

            //otevření databáze
            //sqlconnection.Open();

            //SqlCommand sqlcommand = new SqlCommand(insertCommand, sqlconnection);

            //sqlcommand.ExecuteNonQuery();

            //sqlconnection.Close();
        }

        private void listBDrogerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbInfoCena.Text = lbInfoDostupnost.Text = lbInfoObsah.Text = lbInfoPlet.Text = lbInfoTelo.Text = lbInfoTrvanlivost.Text = lbInfoTyp.Text = lbInfoZnacka.Text = "";
            //int index = listBDrogerie.SelectedIndex;
            ////  string[] pole = listPolozky[index];

            //for (int i = 0; i < listDrogerka.Count; i++)
            //{
            //    //string[] pole = listPolozky[i].ToString();

            //}
            //lbInfoZnacka.Text = listDrogerka[index].ToString();

            //lbInfoDruh.Text = pole[1];
            //lbInfoZnacka.Text = pole[2];
            //lbInfoCena.Text = pole[3];
            //lbInfoDostupnost.Text = pole[4];
            //lbInfoTyp.Text = pole[5];
            //lbInfoTrvanlivost.Text = pole[6];
            //lbInfoObsah.Text = pole[7];
            //lbInfoPlet.Text = pole[8];
            //lbInfoTelo.Text = pole[9];

        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Vypis()
        {
            int IDDruhy = 0;
            int IDZnacka = 0;

            ZnackyString = "";
            DruhyString = "";

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
    }
}
