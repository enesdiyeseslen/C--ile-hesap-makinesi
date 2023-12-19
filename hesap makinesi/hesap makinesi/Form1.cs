using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecekMi;
        int _ilkSayi;


        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text=="0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";

            }
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);

        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            if (_islem == '+')
            {
                sonuc = _ilkSayi + ikinciSayi;
            }
            else if (_islem == '-')
            {
                sonuc = _ilkSayi - ikinciSayi;
            }
            else if (_islem == '*')
            {
                sonuc = _ilkSayi * ikinciSayi;
            }

            else if (_islem == '/')
            {
                sonuc = _ilkSayi / ikinciSayi;
            }
            else
            {
                sonuc = 0;
            }

            ekranLabel.Text = Convert.ToString(sonuc);

        }

        private void eskiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpiButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
