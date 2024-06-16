using System.Collections.Specialized;

namespace AquamarinesYeahImporter
{
    public partial class Form1 : Form
    {
        string loc;
        public Form1()
        {
            InitializeComponent();
            string[] files = Directory.GetFiles(@"YEAH");
            foreach (string file in files)
            {
                comboBox1.Items.Add(file);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            pictureBox1.BackgroundImage = Image.FromFile(comboBox1.SelectedItem.ToString());
            
            Clipboard.SetImage(Image.FromFile(comboBox1.SelectedItem.ToString()));

            /*
            if (comboBox1.SelectedIndex == 0)
            {
                loc = "YEAH//t_5l1g1o.jpg";
                Clipboard.SetImage(Image.FromFile(loc));
               

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                loc = "YEAH//t_7m915a.jpg";
                Clipboard.SetImage(Image.FromFile(loc));
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                loc = "YEAH//t_8a1b1d.jpg";

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                loc = "YEAH//t_cd8x08.png";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                loc = "YEAH//t_9kb018.jpg";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                loc = "YEAH//t_9wbt69.png";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                loc = "YEAH//t_33n3ds.jpg";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                loc = "YEAH//t_869ley.jpg";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                loc = "YEAH//t_a9m2ic.jpg";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                loc = "YEAH//t_ao8q15.jpg";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                loc = "YEAH//t_cnturh.jpg";
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                loc = "YEAH//t_cwfz2c.jpg";
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                loc = "YEAH//t_cyf5lm.jpg";
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                loc = "YEAH//t_d3bxft.png";
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                loc = "YEAH//t_em6d5w.jpg";
            }
            else if (comboBox1.SelectedIndex == 15)
            {
                loc = "YEAH//t_l4udb6.jpg";
            }
            else if (comboBox1.SelectedIndex == 16)
            {
                loc = "YEAH//t_l99u6x.jpg";
            }
            else if (comboBox1.SelectedIndex == 17)
            {
                loc = "YEAH//t_mf324i.jpg";
            }
            else if (comboBox1.SelectedIndex == 18)
            {
                loc = "YEAH//YEAH3D0001.png";
            }
            else if (comboBox1.SelectedIndex == 19)
            {
                loc = "YEAH//t_mvbwgm.jpg";
            }
            else if (comboBox1.SelectedIndex == 20)
            {
                loc = "YEAH//t_rjiyik.jpg";
            }
            else if (comboBox1.SelectedIndex == 21)
            {
                loc = "YEAH//t_s298g2.jpg";
            }
            else if (comboBox1.SelectedIndex == 22)
            {
                loc = "YEAH//t_z83tsz.jpg";
            }
            else if (comboBox1.SelectedIndex == 23)
            {
                loc = "YEAH//t_zbeewh.jpg";
            }
            else if (comboBox1.SelectedIndex == 24)
            {
                loc = "YEAH//GQHZWUHWUAAltZU.png";
            }
            else if (comboBox1.SelectedIndex == 25)
            {
                loc = "YEAH//GQI391tWwAA7Gk7.png";
            }
            else if (comboBox1.SelectedIndex == 26)
            {
                loc = "YEAH//GQIbt0fXMAEgnfs.png";
            }
            else if (comboBox1.SelectedIndex == 27)
            {
                loc = "YEAH//GQIIei0WUAExenp.png";
            }
            else if (comboBox1.SelectedIndex == 28)
            {
                loc = "YEAH//GQIKarsWsAAleyh.png";
            }
            else if (comboBox1.SelectedIndex == 29)
            {
                loc = "YEAH//GQIWeT8X0AESCYQ.png";
            }
            else if (comboBox1.SelectedIndex == 30)
            {
                loc = "YEAH//GQIxEe_WMAA8J44.png";
            }
            pictureBox1.BackgroundImage = Image.FromFile(loc);
            Clipboard.SetImage(Image.FromFile(loc));
            */
            imgcopied();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new StringCollection();
            list.Add(loc);
            Clipboard.SetFileDropList(list);


        }

        private async void imgcopied()
        {
            label1.Visible = true;
            await Task.Delay(1000);
            label1.Visible = false;
        }
    }
}
