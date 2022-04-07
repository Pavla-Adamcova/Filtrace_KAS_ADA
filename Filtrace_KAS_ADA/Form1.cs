﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Filtrace_KAS_ADA
{
    public partial class Form1 : Form
    {
        //deklarace sql
        SqlConnection sqlconnection;
        SqlCommand sqlCommand;

        //List
        List<Drogerka> listPolozky;

        //
        int Druh;
        int Znacka;
        int Cena;
        bool Dostupnost;
        string Typ;
        DateTime Trvanlivost;
        int Obsah;
        public Form1()
        {
            InitializeComponent();
            //
            listPolozky = new List<Drogerka>();

            //připojovací řetězec
            string retezecDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\PGV\Database\DB-Drogerie.mdf;Integrated Security=True;Connect Timeout=30";

            //připojení
            sqlconnection = new SqlConnection(retezecDB);

            // command
            string command = "SELECT * FROM [Drogerie]";
            sqlCommand = new SqlCommand(command, sqlconnection);

            // otevření
            sqlconnection.Open();

            //práce s daty
            SqlDataReader zaznamy = sqlCommand.ExecuteReader();
            while (zaznamy.Read())
            {

                listBDrogerie.Items.Add(($"{zaznamy[1]} - {zaznamy[2]}"));
                string polozka = "";
                //do stringu
                polozka = zaznamy[0].ToString() + ";" + zaznamy[1].ToString() + ";" + zaznamy[2].ToString() + ";" + zaznamy[3].ToString() + ";" + zaznamy[4].ToString() + ";" + zaznamy[5].ToString() + ";" + zaznamy[6].ToString() + ";" + zaznamy[7].ToString();

                Druh = Convert.ToInt32(zaznamy[1]);
                Znacka = Convert.ToInt32(zaznamy[2]);
                Cena = Convert.ToInt32(zaznamy[3]); 
                Dostupnost = Convert.ToBoolean(zaznamy[4]);
                Typ = Convert.ToString(zaznamy[5]); 
                Trvanlivost = Convert.ToDateTime(zaznamy[6]); 
                Obsah = Convert.ToInt32(zaznamy[7]);


                listPolozky.Add(new Drogerka(Druh, Znacka, Cena, Dostupnost, Typ, Trvanlivost, Obsah));
               
            }

            //kontrola pro výpis
            /*
            string proInfo = "";
            for (int i = 0; i < listPolozky.Count; i++) 
            {
                proInfo += listPolozky[i].ToString() + Environment.NewLine;
            }
            MessageBox.Show(proInfo);
            */


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
            sqlconnection.Open();

            //SqlCommand sqlcommand = new SqlCommand(insertCommand, sqlconnection);

            //sqlcommand.ExecuteNonQuery();

            sqlconnection.Close();
        }

        private void listBDrogerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbInfoCena.Text = lbInfoDostupnost.Text = lbInfoObsah.Text = lbInfoPlet.Text = lbInfoTelo.Text = lbInfoTrvanlivost.Text = lbInfoTyp.Text = lbInfoZnacka.Text = "";
            int index = listBDrogerie.SelectedIndex;
            //  string[] pole = listPolozky[index];

            for (int i = 0; i < listPolozky.Count; i++)
            {
                //string[] pole = listPolozky[i].ToString();

            }
            lbInfoZnacka.Text = listPolozky[index].ToString();

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
    }
}
