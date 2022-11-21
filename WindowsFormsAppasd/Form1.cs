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

namespace WindowsFormsAppasd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btngetir.Click += Btngetir_Click;
            btnkaydet.Click += Btnkaydet_Click;
            btnkapat.Click += Btnkapat_Click;
            btnsil.Click += Btnsil_Click;
        }

        private void Btnkapat_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (tMetin.Text == string.Empty)
            {
                MessageBox.Show("Metin kutusu boş!");
            }
            else
            {
                SaveFileDialog pencere = new SaveFileDialog();
                DialogResult sonuc = pencere.ShowDialog();
                if (pencere.FileName == "")
                {
                    if (sonuc == DialogResult.OK)
                    {
                        FileStream fs = File.Create(pencere.FileName);
                        StreamWriter yazici = new StreamWriter(fs);
                        yazici.Write(tMetin.Text);
                        yazici.Close();
                        fs.Close();
                        SAciklama.Text = "Kayıt Başarılı!";
                    }
                }
                else
                {
                    
                }
            }
        }

        private void Btngetir_Click(object sender, EventArgs e)
        {
            OpenFileDialog pencere = new OpenFileDialog();
            DialogResult sonuc = pencere.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(pencere.FileName);
                StreamReader okuyucu = new StreamReader(fs);

                tMetin.Text = okuyucu.ReadToEnd();
                SAciklama.Text = "Dosya açıldı.";
                okuyucu.Close();
                fs.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click_1(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }
    }
}
