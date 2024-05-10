using System;
using System.Drawing;
using System.Windows.Forms;

//Fatma Sena YÜKSEL - 202013171008
//Rukiya Beyza TÜRKEN - 202013171036
//Zeynep BALKAYA - 202013171010


namespace uzayoyunuodev.Desktop
{
    public partial class AnaEkran : Form
    {
        private Button buttonb;
        private Point previousButtonLocation; // Önceki buton konumunu saklamak için değişken
        private Size previousFormSize;
		private Size PreviousClientSize;

		public AnaEkran()
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.Resize += new EventHandler(AnaEkran_Resize); // Yeniden boyutlandırma olayını dinle
        }

        private void InitializeCustomComponents()
        {
            // Buton özelliklerini ayarla
            buttonb = new Button();
            button1.Text = "BAŞLA";
            button1.Click += new EventHandler(button1_Click);
            this.Controls.Add(button1); // Butonu forma ekle

            previousButtonLocation = button1.Location;
        }

        private void AnaEkran_Resize(object sender, EventArgs e)
        {
            // Form boyutu değiştiğinde yapılacaklar buraya gelecek

            // Örneğin, butonu veya diğer kontrol öğelerini yeniden konumlandırabilirsiniz:
            if (button1 != null)
            {
                // Önceki konumu kullanarak butonun yeni konumunu hesapla
                float widthRatio = (float)this.ClientSize.Width / (float)this.PreviousClientSize.Width;
                float heightRatio = (float)this.ClientSize.Height / (float)this.PreviousClientSize.Height;
                button1.Location = new Point((int)(previousButtonLocation.X * widthRatio), (int)(previousButtonLocation.Y * heightRatio));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaForm frm = new AnaForm();
            frm.ShowDialog();
            frm.Close();
        }

       
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacaklar buraya gelecek
            PreviousClientSize = this.ClientSize;
        }
    }
}

