using System;
using System.Windows.Forms;
using Uzay.Library.Concrete;   //Oyun sınıfını kullanabilmek için
using Uzay.Library.Enum;

//Fatma Sena YÜKSEL - 202013171008
//Rukiya Beyza TÜRKEN - 202013171036
//Zeynep BALKAYA - 202013171010


namespace uzayoyunuodev.Desktop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun; 
        // readonly , başka yerden değer atanmasını engeller.
        /*Oyun sınıfına ulaşabilmek için uzayoyunuproje.Library projesini uzayoyunuproje.Desktop ın
        referanslarına ekledik.*/
        public AnaForm()
        {
            /*InitializeComponent(); adlı bir fonksiyon çağırılarak Form1 nesnesine ait olan üye elemanlarla
            (button,label,textbox vs) ilgili ilk işlemler yapılır.*/

            InitializeComponent();
           _oyun= new Oyun(uzaylisavarPanel, savasAlaniPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
            /*KeyDown klavye üzerinde bir tuşa basıldığında hangisine bastığımızı gösterir.
            MessageBox.Show(e.KeyCode.ToString()); ile kontrol edebiliriz.  */
        {

            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UzaylisavariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UzaylisavariHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
        }
        private void Oyun_GecenSureDegisti(object sender , EventArgs e )
        {
            sureLabel.Text = _oyun.GecenSure.ToString("m\\:ss");
            //ss, saniyeyi 2 haneli göstermek için.
        }

        private void AnaForm_Load(object sender, EventArgs e)
        //sender olayı yükselten nesneye bir başvuru sağlar.
        /*e değişkeni o an meydana gelen olayın gözlemlerini içerir.
        Yani buttona tıkladığınızda fare mi kullanıldı yoksa keyboard mı kullanıldı öğreniriz.*/
        {

        }

        private void uzaylisavarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void savasAlaniPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bilgiLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
        
