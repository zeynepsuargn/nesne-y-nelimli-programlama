namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.yasTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.mesaiTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unvan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mesaı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(490, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 106);
            this.button1.TabIndex = 5;
            this.button1.Text = "Personel Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adTxt
            // 
            this.adTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adTxt.Location = new System.Drawing.Point(277, 60);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(100, 22);
            this.adTxt.TabIndex = 6;
            // 
            // yasTxt
            // 
            this.yasTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yasTxt.Location = new System.Drawing.Point(277, 128);
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(100, 22);
            this.yasTxt.TabIndex = 7;
            // 
            // adresTxt
            // 
            this.adresTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adresTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.adresTxt.Location = new System.Drawing.Point(277, 199);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(100, 22);
            this.adresTxt.TabIndex = 8;
            // 
            // mesaiTxt
            // 
            this.mesaiTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mesaiTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.mesaiTxt.Location = new System.Drawing.Point(277, 365);
            this.mesaiTxt.Name = "mesaiTxt";
            this.mesaiTxt.Size = new System.Drawing.Size(100, 22);
            this.mesaiTxt.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İşçi",
            "Mühendis"});
            this.comboBox1.Location = new System.Drawing.Point(277, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mesaiTxt);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.yasTxt);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox yasTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox mesaiTxt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

