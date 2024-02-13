using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WFAHorseRacingOdev_0
{
    public partial class Form1 : Form
    {
        /*

.


3 => Yarıs sürdügü sürece herhangi bir olasılık hesaplaması yaparak ilglii sart gercekleştiginde atlardan birinin ayagının kırıldıgını farzederek yarıstan cıkarın...Geriye sadece kalan 2 at kosmaya devam etsin...Eger iki atın birden ayagı kırılma sansı denk gelirse 3. atın ayagının kırılmasını engelleyin otomatik olarak o at kazansın diger atlar yarısı kaybetmiş sayılsın...Ayagı kırılan %50 ihtimalle bir sonraki yarısa katılabilsin (her turda bu ihtimali tekrar hesaplayın) eger bu ihtimal tutmazsa bir sonraki yarısta oynamasın...

4=> Kırmızı bir zemin de yaratarak o zeminde kazanamayan atları kırmızı carpı resmine dönüstürün...

5 => Mafya sistemi... Bir at kazandıgında belirli bir sansa göre (%10) yarısı mafya bassın ve bahise el koysun oyuncunun yatırdıgı para da yok olsun...

6=> Mafya sisteminin sansı denk gelirse bir baska sans sistemi daha tasarlayarak ortamı polisin basmasını saglayın...Kullanıcının kacabilmesi icin %50 bir olasılık hesaplamasıyla karar verin...Kullanıcı kacabilirse parasını geri alsın kacamazsa banka hesabına bloke koyulsun sonraki yarısta da cezalı olsun 1 tur oynayamasın

7 => Polis %10 sans ile Rıza Baba olarak gelsin

8 => Oyuna bir hile mekanizması ekleyin...Kullanıcı bu hileyi kullandıgı zaman atı ciddi bir şekilde hızlansın...Lakin kullanıcının yakalanma sansı %80 olsun...Eger yakalanırsa direkt oyun bitsin...

9 => Mafya gelirse %5 ihtimalle icerisindeki gizli polis mafyayı cökertsin...Mafya cokerse o oyuna bir daha mafya bulasmasın...
        */
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int zeminRandom, bahis, bakiye = 5000;
        string beyazSaray = "green", cikolata = "brown", gunes = "white",
            atbahis;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblbakiye.Text=bakiye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//bahis yatırma butonu
        {
            bahis = Convert.ToInt32(txtbahistutar.Text);
            atbahis=txtatbahis.Text;
            bakiye -= Convert.ToInt32(txtbahistutar.Text);
            lblbakiye.Text = bakiye.ToString();



        }

        private void btnBasla_Click(object sender, EventArgs e)
        {                 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pcikolata.Left += rnd.Next(5, 15);
            pgunes.Left += rnd.Next(5, 15);
            pibeyazSaray.Left += rnd.Next(5, 15);
            if(pgunes.Right >= lblFinish.Left)
            { 
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Yarışı Güneş Kazandı \n Tekrar oynamak istermisin ?","Güneş Doğdu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (atbahis == "gunes")
                {
                    if (BackColor == Color.FromName(gunes))
                    {
                        bakiye += bahis + (bahis * 40) / 100;
                        txtbahistutar.Text = 0.ToString();
                    }
                    else
                    {
                        bakiye += bahis + (bahis * 60 / 100);
                        txtbahistutar.Text = 0.ToString();                        
                    }
                }
                lblbakiye.Text = bakiye.ToString();
                if (dr == DialogResult.Yes)
                {
                    pcikolata.Left = pgunes.Left = pibeyazSaray.Left = 0;
                    zeminRandom = rnd.Next(1, 5);

                    if (zeminRandom == 1)
                    {
                        BackColor = Color.Brown;
                    }
                    else if (zeminRandom == 2)
                    {
                        BackColor = Color.Green;
                    }
                    else if(zeminRandom == 3)
                    {
                        BackColor = Color.White;
                    }
                    else
                    {
                        BackColor = Color.Red;
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (BackColor==Color.FromName(beyazSaray))
            {
                pibeyazSaray.Left += rnd.Next(5, 20);
                pgunes.Left += rnd.Next(5, 15);
                pcikolata.Left+= rnd.Next(5, 15);
            }
            else if (BackColor==Color.FromName(cikolata))
            {
                pibeyazSaray.Left += rnd.Next(5, 15);
                pgunes.Left += rnd.Next(5, 15);
                pcikolata.Left += rnd.Next(5, 20);
            }
            else if (BackColor==Color.FromName(gunes))
            {
                pibeyazSaray.Left += rnd.Next(5, 15);
                pgunes.Left += rnd.Next(5, 20);
                pcikolata.Left += rnd.Next(5, 15);
            }
            else if (pcikolata.Right>=lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Yarışı Çikolata Kazandı \n Tekrar oynamak istermisin ?", "Ülker Bayram etti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (atbahis=="cikolata")
                {
                    if (BackColor == Color.FromName(cikolata))
                    {
                        bakiye += bahis + (bahis * 40) / 100;
                      txtbahistutar.Text=0.ToString();
                        lblbakiye.Text = bakiye.ToString();
                    }
                    else
                    {
                        bakiye += bahis + (bahis * 60) / 100;
                        txtbahistutar.Text = 0.ToString();
                        lblbakiye.Text=bakiye.ToString();
                    }
                }
                if(dr == DialogResult.Yes)
                {
                    pcikolata.Left = pgunes.Left = pibeyazSaray.Left = 0;
                    zeminRandom = rnd.Next(1, 5);
                    if (zeminRandom == 1)
                    {
                        BackColor = Color.Brown;
                    }
                    else if (zeminRandom == 2)
                    {
                        BackColor = Color.Green;
                    }
                    else if(zeminRandom == 3)
                    {
                        BackColor = Color.White;
                    }
                    else
                    {
                        BackColor = Color.Red;
                    }
                }
                else 
                {
                    Application.Exit(); 
                }
            }
            else if (pibeyazSaray.Right>=lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Yarışı Beyaz Saray Kazandı \n Tekrar oynamak istermisin ?", "Sabri Abi Keyifli", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (atbahis=="beyaz saray")
                {
                    if (BackColor==Color.FromName(beyazSaray))
                    {
                        bakiye += bahis + (bahis * 40) / 100;
                        txtbahistutar.Text=0.ToString();
                        lblbakiye.Text=bakiye.ToString();
                    }
                    else
                    {
                        bakiye += bahis + (bahis * 60) / 100;
                        txtbahistutar.Text=0.ToString() ;
                        lblbakiye.Text= bakiye.ToString();
                    }
                }
                if (dr == DialogResult.Yes)
                {
                    pcikolata.Left = pgunes.Left = pibeyazSaray.Left = 0;
                    zeminRandom = rnd.Next(1, 5);
                    if (zeminRandom == 1)
                    {                       
                        BackColor = Color.Brown;                        
                    }
                    else if (zeminRandom == 2)
                    {                      
                        BackColor = Color.Green;                     
                    }
                    else if(zeminRandom == 3) 
                    {                     
                        BackColor = Color.White;                       
                    }
                    else
                    {
                        BackColor= Color.Red;
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            
            

            
        }

    }
}
