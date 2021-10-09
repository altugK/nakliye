using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nakliye
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi = { { 0,290,845,919,1220,1140,1400,1540,1600,1689,1400,1521,1807},
                        { 290,0,570,675,970,898,1144,1280,1298,1446,1156,1287,1500},
                        { 845,570,0,450,660,710,8667,801,665,938,647,805,1020},
                        { 919,675,450,0,305,270,521,612,633,855,643,808,968},
                        { 1220,970,660,305,0,261,413,415,436,645,661,838,763},
                        { 1140,898,710,270,261,0,629,657,678,887,806,963,1100},
                        { 1400,1144,8667,521,413,629,0,232,314,344,229,366,430},
                        { 1540,1280,801,612,415,657,232,0,122,236,389,523,420},
                        { 1600,1298,665,633,436,678,314,122,0,311,472,615,480},
                        { 1689,1446,938,855,645,887,344,236,311,0,302,367,200},
                        { 1400,1156,647,643,661,806,229,389,472,302,0,163,390},
                        { 1521,1287,805,808,838,963,366,523,615,367,163,0,323},
                        { 1807,1500,1020,968,763,1100,430,420,480,200,390,323,0} };

        string[] duraklar = {"Iğdır","Erzurum", "Samsun", "Kayseri", "Konya", "Mersin", "Eskişehir", "Uşak", "Denizli", "Balıkesir", "Izmit", "Istanbul","Canakkale" };
        
private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 12; a++)
                {
                    listBox1.Items.Add(dizi[0, a] + dizi[a, 12] + " Km      Iğdır->" + duraklar[a] + "-> Çanakkale");
                }
                label1.Text = listBox1.Items.Count.ToString() + " olasılık bulundu.";

            }
            if (radioButton2.Checked)
            {
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 12; a++)
                {
                    for (int b = 1; b < 10; b++)
                    {
                        if (a==b)
                        {
                            continue;
                        }
                        listBox1.Items.Add(dizi[0, a] + dizi[a, b]+dizi[b,12]+ " Km      Iğdır->" + duraklar[a]+"->"+duraklar[b]+ "-> Çanakkale");
                    }
                }
                label1.Text = listBox1.Items.Count.ToString() + " olasılık bulundu.";

            }
            if (radioButton3.Checked)
            {
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 12; a++)
                {
                    for (int b = 1; b < 12; b++)
                    {
                        for (int c = 1; c < 12; c++)
                        {
                            if (a == b || b == c)
                            {
                                continue;
                            }
                            listBox1.Items.Add(dizi[0, a] + dizi[a, b] + dizi[b, c]+dizi[c,12]+ " Km      Iğdır->" + duraklar[a] + "->" + duraklar[b] +"->"+duraklar[c]+ "-> Çanakkale");
                           
                        }
                    }
                }
                label1.Text = listBox1.Items.Count.ToString() + " olasılık bulundu.";

            }
            if (radioButton4.Checked)
            {
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 12; a++)
                {
                    for (int b = 1; b < 12; b++)
                    {
                        for (int c = 1; c < 12; c++)
                        {
                            for (int d = 1; d < 12; d++)
                            {
                                if (a == b || b == c ||c==d)
                                {
                                    continue;
                                }
                              
                                listBox1.Items.Add(dizi[0, a] + dizi[a, b] + dizi[b, c] +dizi[c,d]+ dizi[d, 12] +" Km      Iğdır->" + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c]+ "->" + duraklar[d] + "-> Çanakkale");
                            }

                        }
                    }
                }
                label1.Text = listBox1.Items.Count.ToString() + " olasılık bulundu.";

            }

            if (radioButton5.Checked)
            {
                listBox1.Items.Clear();
                label1.Text = "Lütfen Bekleyiniz...";
                this.Refresh();
                for (int a = 1; a < 12; a++)
                {
                    for (int b = 1; b < 12; b++)
                    {
                        for (int c = 1; c < 12; c++)
                        {
                            for (int d = 1; d < 12; d++)
                            {
                                for (int f = 0; f < 12; f++)
                                {
                                    if (a == b || b == c || c == d ||d==f)
                                    {
                                        continue;
                                    }
                                    
                                    listBox1.Items.Add(dizi[0, a] + dizi[a, b] + dizi[b, c] + dizi[c, d] + dizi[d, f]+dizi[f,12] + " Km      Iğdır->" + duraklar[a] + "->" + duraklar[b] + "->" + duraklar[c] + "->" + duraklar[d] +"->"+duraklar[f]+ "-> Çanakkale");

                                }
                            }

                        }
                    }
                }
                label1.Text = listBox1.Items.Count.ToString()+" olasılık bulundu.";
            }

        }
    }
}
