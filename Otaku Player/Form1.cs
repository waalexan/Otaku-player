using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otaku_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            openChildForm(new Form2());
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
oi
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        WMPLib.IWMPPlaylist playList;

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            ofdAbrir.Title = "Abrir mídia";
            ofdAbrir.Filter = "Arquivo mp4|*.mp4|Arquvio mp3|*.mp3";
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                playList = player.playlistCollection.newPlaylist("Lista");

                foreach (var arquivo in ofdAbrir.FileNames)
                {
                    playList.appendItem(player.newMedia(arquivo));
                    //lstPlayList.Items.Add(Path.GetFileNameWithoutExtension(arquivo));
                    lstPlayList.Items.Add(arquivo);


                    player.currentPlaylist = playList;
                    player.Ctlcontrols.play();
                }
            }            
        }

        private void lstPlayList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void gunaImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!gunaImageCheckBox1.Checked == false)
            {
                player.Ctlcontrols.pause();
            }
            else
            {
                player.Ctlcontrols.play();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label2.Text = player.Ctlcontrols.currentPositionString;
                guna2TrackBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }
            catch { label2.Text = "00:00"; }
        }

        private void gunaButton5_Click_1(object sender, EventArgs e)
        {
            if (lstPlayList.Items.Count > 0)
            {
                sfdSalvar.Title = "Salvar PlayList";
                sfdSalvar.Filter = "Arquivo texto|*.txt";
                if (sfdSalvar.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter arquivo = new StreamWriter(sfdSalvar.FileName, false);
                    for (int i = 0; i < lstPlayList.Items.Count; i++)
                    {
                        arquivo.WriteLine(lstPlayList.Items[i].ToString());
                    }
                    arquivo.Close();
                }

            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            ofdAbrir.Title = "Abrir PlayList";
            ofdAbrir.Filter = "Arquivo texto|*.txt";
            ofdAbrir.Multiselect = false;
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader arquivo = new StreamReader(ofdAbrir.FileName);
                while (arquivo.Peek() != -1)
                {
                    lstPlayList.Items.Add(arquivo.ReadLine());
                }
                arquivo.Close();
            }
        }

        private void lstPlayList_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (lstPlayList.Items.Count > 0)
            {
                player.URL = lstPlayList.SelectedItem.ToString();
                player.Ctlcontrols.play();
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Contentor.Controls.Add(childForm);
            Contentor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void gunaLinePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form1());

            Form2 f = new Form2();
            f.close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastForward();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastReverse();
        }
    }
}
