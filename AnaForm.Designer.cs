
namespace uzayoyunuodev.Desktop
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
			this.bilgiPanel = new System.Windows.Forms.Panel();
			this.sureLabel = new System.Windows.Forms.Label();
			this.bilgiLabel = new System.Windows.Forms.Label();
			this.savasAlaniPanel = new System.Windows.Forms.Panel();
			this.uzaylisavarPanel = new System.Windows.Forms.Panel();
			this.bilgiPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// bilgiPanel
			// 
			this.bilgiPanel.BackColor = System.Drawing.Color.Black;
			this.bilgiPanel.Controls.Add(this.sureLabel);
			this.bilgiPanel.Controls.Add(this.bilgiLabel);
			this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.bilgiPanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
			this.bilgiPanel.Name = "bilgiPanel";
			this.bilgiPanel.Size = new System.Drawing.Size(734, 100);
			this.bilgiPanel.TabIndex = 0;
			// 
			// sureLabel
			// 
			this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sureLabel.BackColor = System.Drawing.Color.DarkGray;
			this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sureLabel.ForeColor = System.Drawing.Color.White;
			this.sureLabel.Location = new System.Drawing.Point(569, 19);
			this.sureLabel.Name = "sureLabel";
			this.sureLabel.Size = new System.Drawing.Size(162, 47);
			this.sureLabel.TabIndex = 1;
			this.sureLabel.Text = "0:00";
			this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// bilgiLabel
			// 
			this.bilgiLabel.AutoSize = true;
			this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bilgiLabel.ForeColor = System.Drawing.Color.White;
			this.bilgiLabel.Location = new System.Drawing.Point(3, 9);
			this.bilgiLabel.Name = "bilgiLabel";
			this.bilgiLabel.Size = new System.Drawing.Size(681, 87);
			this.bilgiLabel.TabIndex = 0;
			this.bilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basın.\r\nUzaylısavarı hareket ettirmek için SAĞ/" +
    "SOL yön tuşlarına basın.\r\nAteş etmek için BOŞLUK tuşuna basın.\r\n";
			this.bilgiLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.bilgiLabel.Click += new System.EventHandler(this.bilgiLabel_Click);
			// 
			// savasAlaniPanel
			// 
			this.savasAlaniPanel.BackColor = System.Drawing.Color.Black;
			this.savasAlaniPanel.BackgroundImage = global::uzayoyunuodev.Desktop.Properties.Resources.u1;
			this.savasAlaniPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.savasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.savasAlaniPanel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.savasAlaniPanel.Location = new System.Drawing.Point(0, 100);
			this.savasAlaniPanel.Name = "savasAlaniPanel";
			this.savasAlaniPanel.Size = new System.Drawing.Size(734, 287);
			this.savasAlaniPanel.TabIndex = 2;
			this.savasAlaniPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.savasAlaniPanel_Paint);
			// 
			// uzaylisavarPanel
			// 
			this.uzaylisavarPanel.BackColor = System.Drawing.Color.Black;
			this.uzaylisavarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.uzaylisavarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uzaylisavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uzaylisavarPanel.Location = new System.Drawing.Point(0, 387);
			this.uzaylisavarPanel.Name = "uzaylisavarPanel";
			this.uzaylisavarPanel.Size = new System.Drawing.Size(734, 43);
			this.uzaylisavarPanel.TabIndex = 1;
			this.uzaylisavarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.uzaylisavarPanel_Paint);
			// 
			// AnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(734, 430);
			this.Controls.Add(this.savasAlaniPanel);
			this.Controls.Add(this.uzaylisavarPanel);
			this.Controls.Add(this.bilgiPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AnaForm";
			this.Text = "Uzay İstilası Oyunu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AnaForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
			this.bilgiPanel.ResumeLayout(false);
			this.bilgiPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Panel savasAlaniPanel;
		private System.Windows.Forms.Panel uzaylisavarPanel;
	}
}

