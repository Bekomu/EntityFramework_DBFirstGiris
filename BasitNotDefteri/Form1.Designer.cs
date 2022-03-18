namespace BasitNotDefteri
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.pnlNot = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.pnlNot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notlar";
            // 
            // lstNotlar
            // 
            this.lstNotlar.DisplayMember = "Baslik";
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 20;
            this.lstNotlar.Location = new System.Drawing.Point(25, 66);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(186, 424);
            this.lstNotlar.TabIndex = 1;
            this.lstNotlar.ValueMember = "Id";
            this.lstNotlar.SelectedValueChanged += new System.EventHandler(this.lstNotlar_SelectedValueChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(470, 475);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 33);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtNot
            // 
            this.txtNot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNot.Location = new System.Drawing.Point(0, 43);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(574, 424);
            this.txtNot.TabIndex = 3;
            this.txtNot.Text = "İçerik";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaslik.Location = new System.Drawing.Point(0, 0);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(574, 26);
            this.txtBaslik.TabIndex = 4;
            this.txtBaslik.Text = "Başlık";
            // 
            // pnlNot
            // 
            this.pnlNot.Controls.Add(this.button1);
            this.pnlNot.Controls.Add(this.txtBaslik);
            this.pnlNot.Controls.Add(this.txtNot);
            this.pnlNot.Controls.Add(this.btnEkle);
            this.pnlNot.Location = new System.Drawing.Point(227, 23);
            this.pnlNot.Name = "pnlNot";
            this.pnlNot.Size = new System.Drawing.Size(574, 507);
            this.pnlNot.TabIndex = 5;
            this.pnlNot.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(389, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.Location = new System.Drawing.Point(25, 497);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(186, 33);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni Not Ekle";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 554);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.pnlNot);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(840, 593);
            this.MinimumSize = new System.Drawing.Size(840, 548);
            this.Name = "Form1";
            this.Text = "Basit Not Defteri";
            this.pnlNot.ResumeLayout(false);
            this.pnlNot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Panel pnlNot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnYeni;
    }
}

