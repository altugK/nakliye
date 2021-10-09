using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iboProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi = { 
                    {0,290,845,0,554,0,929,0,1220,1140,0,0,1016,0,0,1400,1540,0,1600,0,1689,0,0,1400,0,0,1521,0,0,1807},
                    {290,0,570,0,267,0,675,0,970,898,0,0,798,0,0,1144,1280,0,1298,0,1446,0,0,1156,0,0,1287,0,0,1500},
                    {845,570,0,0,328,300,450,0,660,710,0,2360,765,0,2425,867,801,0,665,0,938,0,860,647,0,830,805,0,780,1020},
                    {845,570,0,0,328,300,450,0,660,710,0,2360,765,0,2425,667,801,0,665,0,938,0,860,647,0,830,805,0,780,1020},
                    {554,267,328,300,0,0,552,0,888,894,0,2500,835,0,2565,981,1117,0,1234,0,1241,0,1000,977,0,970,1066,0,920,1353},
                    {554,267,328,300,0,0,552,0,888,894,0,2500,835,0,2565,981,1117,0,1234,0,1241,0,1000,977,0,970,1066,0,920,1353},
                    {929,675,450,0,552,0,0,0,305,270,285,0,407,445,0,521,612,813,633,899,855,1043,0,643,1045,0,808,1231,0,968},
                    {929,675,450,0,552,0,0,0,305,270,285,0,407,445,0,521,612,813,633,899,855,1043,0,643,1045,0,808,1231,0,968},
                    {1220,970,660,0,888,0,305,0,0,261,0,0,520,0,0,413,415,0,436,0,645,0,0,661,0,0,838,0,0,763},
                    {1140,898,710,2360,894,2500,270,285,261,0,0,0,258,161,0,629,657,748,678,834,887,978,1590,806,980,1725,963,1166,1580,1100},
                    {1140,898,710,2360,894,2500,270,285,261,0,0,0,258,161,65,629,657,748,678,834,887,978,1590,806,980,1725,963,1166,1580,1100},
                    {1140,898,710,2360,894,2500,270,285,261,0,0,0,258,161,65,629,657,748,678,834,887,978,1590,806,980,1725,963,1166,1580,1100},
                    {1016,798,765,2425,835,2565,407,445,520,258,161,65,0,0,0,840,865,908,909,995,1091,1139,1655,1016,1141,1790,1107,1327,1645,1262},
                    {1016,798,765,2425,835,2565,407,445,520,258,161,65,0,0,0,840,865,908,909,995,1091,1139,1655,1016,1141,1790,1107,1327,1645,1262},
                    {1016,798,765,2425,835,2565,407,445,520,258,161,65,0,0,0,840,865,908,909,995,1091,1139,1655,1016,1141,1790,1107,1327,1645,1262},
                    {1400,1144,667,0,981,0,521,0,413,629,0,0,840,0,0,0,232,0,314,0,344,0,0,229,0,0,366,0,0,430},
                    {1540,1280,801,0,1117,0,612,813,415,657,748,0,865,908,0,232,0,0,122,353,236,381,0,389,503,0,523,689,0,420},
                    {1540,1280,801,0,1117,0,612,813,415,657,748,0,865,908,0,232,0,0,122,353,236,381,0,389,503,0,523,689,0,420},
                    {1600,1298,665,0,1234,0,633,899,436,678,834,0,909,995,0,314,122,353,0,0,311,518,0,472,589,0,615,775,0,480},
                    {1600,1298,665,0,1234,0,633,899,436,678,834,0,909,995,0,314,122,353,0,0,311,518,0,472,589,0,615,775,0,480},
                    {1689,1446,938,860,1241,1000,855,1043,645,887,978,1590,1091,1139,1655,344,236,381,311,518,0,0,0,302,546,160,367,732,80,200},
                    {1689,1446,938,860,1241,1000,855,1043,645,887,978,1590,1091,1139,1655,344,236,381,311,518,0,0,0,302,546,160,367,732,80,200},
                    {1689,1446,938,860,1241,1000,855,1043,645,887,978,1590,1091,1139,1655,344,236,381,311,518,0,0,0,302,546,160,367,732,80,200},
                    {1400,1156,647,830,977,970,643,1045,661,806,980,1725,1016,1141,1790,229,389,503,472,589,302,546,160,0,0,0,163,186,50,390},
                    {1400,1156,647,830,977,970,643,1045,661,806,980,1725,1016,1141,1790,229,389,503,472,589,302,546,160,0,0,0,163,186,50,390},
                    {1400,1156,647,830,977,970,643,1045,661,806,980,1725,1016,1141,1790,229,389,503,472,589,302,546,160,0,0,0,163,186,50,390},
                    {1521,1287,805,750,1066,920,808,1231,838,963,1166,1166,1107,1327,1645,366,523,689,615,775,367,732,80,163,186,50,0,0,0,323},
                    {1521,1287,805,750,1066,920,808,1231,838,963,1166,1166,1107,1327,1645,366,523,689,615,775,367,732,80,163,186,50,0,0,0,323},
                    {1521,1287,805,750,1066,920,808,1231,838,963,1166,1580,1107,1327,1645,366,523,689,615,775,367,732,80,163,186,50,0,0,0,323},
                    {1807,1500,1020,0,1353,0,968,0,763,1100,0,0,1262,0,0,430,420,0,480,0,200,0,0,390,0,0,323,0,0,0}, };

        string[] duraklar = { "Iðdýr", "Erzurum", "Samsun", "Samsun Deniz", "Trabzon", 
                                "Trabzon Deniz", "Kayseri", "Kayseri Tren", "Konya", 
                                "Mersin", "Mersin Tren", "Mersin Deniz", "Iskenderun", 
                                "Iskenderun Tren", "Iskenderun Deniz", "Eskiþehir", "Uþak",
                                "Uþak Tren", "Denizli", "Denizli Tren", "Balýkesir",
                                "Balýkesir Tren", "Balýkesir Deniz", "Izmit", "Izmit Tren", 
                                "Izmýt Deniz", "Istanbul", "Istanbul Tren", "Istanbul Deniz", "Canakkale" };



        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            if (radioButton1.Checked)
            {

                int enbuyuk = 0, enkucuk = 9999, sayi;
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 29; a++)
                {
                    if (dizi[0, a] == 0)
                    {
                        continue;
                    }

                    sayi = dizi[0, a] + dizi[a, 29];
                    listBox1.Items.Add(sayi + " Km      Iðdýr->" + duraklar[a] + "-> Çanakkale");
                    if (enbuyuk < sayi)
                    {
                        enbuyuk = sayi;
                        label4.Text = enbuyuk + " Km " + duraklar[a];
                    }
                    if (sayi < enkucuk)
                    {
                        enkucuk = sayi;
                        label5.Text = enkucuk + " Km " + duraklar[a];
                    }


                }
                label1.Text = listBox1.Items.Count.ToString() + " olasýlýk bulundu.";
                label2.Visible = true;
                label3.Visible = true;
            }
            if (radioButton2.Checked)
            {
                int enbuyuk = 0, enkucuk = 9999, sayi;
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 29; a++)
                {
                    for (int b = 1; b < 29; b++)
                    {

                        if (dizi[0, a] == 0 || dizi[a, b] == 0 || a == b)
                        {
                            continue;
                        }
                        sayi = dizi[0, a] + dizi[a, b] + dizi[b, 29];
                        listBox1.Items.Add(sayi + " Km      Iðdýr->" + duraklar[a] + "->" + duraklar[b] + "-> Çanakkale");
                        if (enbuyuk < sayi)
                        {
                            enbuyuk = sayi;
                            label4.Text = enbuyuk + " Km " + duraklar[a] + "->" + duraklar[b];
                        }
                        if (sayi < enkucuk)
                        {
                            enkucuk = sayi;
                            label5.Text = enkucuk + " Km " + duraklar[a] + "->" + duraklar[b];
                        }
                    }
                }
                label1.Text = listBox1.Items.Count.ToString() + " olasýlýk bulundu.";
                label2.Visible = true;
                label3.Visible = true;
            }
            if (radioButton3.Checked)
            {
                int enbuyuk = 0, enkucuk = 9999, sayi;
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 29; a++)
                {
                    for (int b = 1; b < 29; b++)
                    {
                        for (int c = 1; c < 29; c++)
                        {

                            if (dizi[0, a] == 0 || dizi[a, b] == 0 || dizi[b, c] == 0 || a == b || b == c || a == c)
                            {
                                continue;
                            }
                            sayi = dizi[0, a] + dizi[a, b] + dizi[b, c] + dizi[c, 29];
                            listBox1.Items.Add(sayi + " Km      Iðdýr->" + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "-> Çanakkale");
                            if (enbuyuk < sayi)
                            {
                                enbuyuk = sayi;
                                label4.Text = enbuyuk + " Km " + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c];
                            }
                            if (sayi < enkucuk)
                            {
                                enkucuk = sayi;
                                label5.Text = enkucuk + " Km " + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c];
                            }
                        }
                    }
                }
                label1.Text = listBox1.Items.Count.ToString() + " olasýlýk bulundu.";
                label2.Visible = true;
                label3.Visible = true;
            }
            if (radioButton4.Checked)
            {
                int enbuyuk = 0, enkucuk = 9999, sayi;
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 29; a++)
                {
                    for (int b = 1; b < 29; b++)
                    {
                        for (int c = 1; c < 29; c++)
                        {
                            for (int d = 1; d < 29; d++)
                            {
                                if (dizi[0, a] == 0 || dizi[a, b] == 0 || dizi[b, c] == 0 || dizi[c, d] == 0 || a == b || b == c || c == d || a == c || b == d || a == d)
                                {
                                    continue;
                                }
                                sayi = dizi[0, a] + dizi[a, b] + dizi[b, c] + dizi[c, d] + dizi[d, 29];
                                listBox1.Items.Add(sayi + " Km      Iðdýr->" + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "->" + duraklar[d] + "-> Çanakkale");
                                if (enbuyuk < sayi)
                                {
                                    enbuyuk = sayi;
                                    label4.Text = enbuyuk + " Km " + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "->" + duraklar[d];
                                }
                                if (sayi < enkucuk)
                                {
                                    enkucuk = sayi;
                                    label5.Text = enkucuk + " Km " + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "->" + duraklar[d];
                                }
                            }

                        }
                    }
                }
                label1.Text = listBox1.Items.Count.ToString() + " olasýlýk bulundu.";
                label2.Visible = true;
                label3.Visible = true;
            }

            if (radioButton5.Checked)
            {
                int enbuyuk = 0, enkucuk = 9999, sayi;
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                int a = 1;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Erzurum": a = 1; break;
                    case "Samsun": a = 2; break;
                    case "Trabzon": a = 4; break;
                    case "Kayseri": a = 6; break;
                    case "Konya": a = 8; break;
                    case "Mersin": a = 9; break;
                    case "Eskiþehir": a = 15; break;
                    case "Uþak": a = 16; break;
                    case "Denizli": a = 18; break;
                    case "Balýkesir": a = 20; break;
                    case "Izmit": a = 23; break;
                    case "Istanbul": a = 26; break;
                    default:
                        break;
                }

                for (int b = 1; b < 29; b++)
                {
                    for (int c = 1; c < 29; c++)
                    {
                        for (int d = 1; d < 29; d++)
                        {
                            for (int f = 1; f < 29; f++)
                            {
                                if (dizi[0, a] == 0 || dizi[a, b] == 0 || dizi[b, c] == 0 || dizi[c, d] == 0 || dizi[d, f] == 0 || a == b || b == c || c == d || d == f || a == c || a == d || a == f || b == d || b == f || c == f || listBox1.Items.Count > 180000)
                                {
                                    continue;
                                }
                                sayi = dizi[0, a] + dizi[a, b] + dizi[b, c] + dizi[c, d] + dizi[d, f] + dizi[f, 29];
                                listBox1.Items.Add(sayi + " Km      Iðdýr->" + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "->" + duraklar[d] + "->" + duraklar[f] + "-> Çanakkale");
                                if (enbuyuk < sayi)
                                {
                                    enbuyuk = sayi;
                                    label4.Text = enbuyuk + " Km " + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "->" + duraklar[d] + "->" + duraklar[f];
                                }
                                if (sayi < enkucuk)
                                {
                                    enkucuk = sayi;
                                    label5.Text = enkucuk + " Km " + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "->" + duraklar[d] + "->" + duraklar[f];
                                }
                            }
                        }

                    }
                }

                label1.Text = listBox1.Items.Count.ToString() + " olasýlýk bulundu.";
                label2.Visible = true;
                label3.Visible = true;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            comboBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            comboBox1.SelectedItem = "Erzurum";
            button2.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("trKM.txt");
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();


        }


    }
}
