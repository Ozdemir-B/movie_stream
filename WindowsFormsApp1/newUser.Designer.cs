namespace WindowsFormsApp1
{
    partial class newUser
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
            this.aksiyonMaceraCheck = new System.Windows.Forms.CheckBox();
            this.bilimKurguCheck = new System.Windows.Forms.CheckBox();
            this.romantikCheck = new System.Windows.Forms.CheckBox();
            this.dramaCheck = new System.Windows.Forms.CheckBox();
            this.cocukCheck = new System.Windows.Forms.CheckBox();
            this.belgeselCheck = new System.Windows.Forms.CheckBox();
            this.komediCheck = new System.Windows.Forms.CheckBox();
            this.bilimDogaCheck = new System.Windows.Forms.CheckBox();
            this.korkuCheck = new System.Windows.Forms.CheckBox();
            this.gerilimCheck = new System.Windows.Forms.CheckBox();
            this.realityCheck = new System.Windows.Forms.CheckBox();
            this.animeCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz 3 türü seçiniz.";
            // 
            // aksiyonMaceraCheck
            // 
            this.aksiyonMaceraCheck.AutoSize = true;
            this.aksiyonMaceraCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aksiyonMaceraCheck.Location = new System.Drawing.Point(128, 116);
            this.aksiyonMaceraCheck.Name = "aksiyonMaceraCheck";
            this.aksiyonMaceraCheck.Size = new System.Drawing.Size(117, 17);
            this.aksiyonMaceraCheck.TabIndex = 1;
            this.aksiyonMaceraCheck.Text = "Aksiyon ve Macera";
            this.aksiyonMaceraCheck.UseVisualStyleBackColor = true;
            this.aksiyonMaceraCheck.CheckedChanged += new System.EventHandler(this.aksiyonMaceraCheck_CheckedChanged);
            // 
            // bilimKurguCheck
            // 
            this.bilimKurguCheck.AutoSize = true;
            this.bilimKurguCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilimKurguCheck.Location = new System.Drawing.Point(128, 153);
            this.bilimKurguCheck.Name = "bilimKurguCheck";
            this.bilimKurguCheck.Size = new System.Drawing.Size(182, 17);
            this.bilimKurguCheck.TabIndex = 2;
            this.bilimKurguCheck.Text = "Bilim Kurgu ve Fantastik Yapımlar";
            this.bilimKurguCheck.UseVisualStyleBackColor = true;
            this.bilimKurguCheck.CheckedChanged += new System.EventHandler(this.bilimKurguCheck_CheckedChanged);
            // 
            // romantikCheck
            // 
            this.romantikCheck.AutoSize = true;
            this.romantikCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.romantikCheck.Location = new System.Drawing.Point(128, 194);
            this.romantikCheck.Name = "romantikCheck";
            this.romantikCheck.Size = new System.Drawing.Size(71, 17);
            this.romantikCheck.TabIndex = 3;
            this.romantikCheck.Text = "Romantik";
            this.romantikCheck.UseVisualStyleBackColor = true;
            this.romantikCheck.CheckedChanged += new System.EventHandler(this.romantikCheck_CheckedChanged);
            // 
            // dramaCheck
            // 
            this.dramaCheck.AutoSize = true;
            this.dramaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dramaCheck.Location = new System.Drawing.Point(128, 232);
            this.dramaCheck.Name = "dramaCheck";
            this.dramaCheck.Size = new System.Drawing.Size(57, 17);
            this.dramaCheck.TabIndex = 4;
            this.dramaCheck.Text = "Drama";
            this.dramaCheck.UseVisualStyleBackColor = true;
            this.dramaCheck.CheckedChanged += new System.EventHandler(this.dramaCheck_CheckedChanged);
            // 
            // cocukCheck
            // 
            this.cocukCheck.AutoSize = true;
            this.cocukCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cocukCheck.Location = new System.Drawing.Point(128, 277);
            this.cocukCheck.Name = "cocukCheck";
            this.cocukCheck.Size = new System.Drawing.Size(92, 17);
            this.cocukCheck.TabIndex = 5;
            this.cocukCheck.Text = "Çocuk ve Aile";
            this.cocukCheck.UseVisualStyleBackColor = true;
            this.cocukCheck.CheckedChanged += new System.EventHandler(this.cocukCheck_CheckedChanged);
            // 
            // belgeselCheck
            // 
            this.belgeselCheck.AutoSize = true;
            this.belgeselCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.belgeselCheck.Location = new System.Drawing.Point(128, 313);
            this.belgeselCheck.Name = "belgeselCheck";
            this.belgeselCheck.Size = new System.Drawing.Size(66, 17);
            this.belgeselCheck.TabIndex = 6;
            this.belgeselCheck.Text = "Belgesel";
            this.belgeselCheck.UseVisualStyleBackColor = true;
            this.belgeselCheck.CheckedChanged += new System.EventHandler(this.belgeselCheck_CheckedChanged);
            // 
            // komediCheck
            // 
            this.komediCheck.AutoSize = true;
            this.komediCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.komediCheck.Location = new System.Drawing.Point(332, 116);
            this.komediCheck.Name = "komediCheck";
            this.komediCheck.Size = new System.Drawing.Size(61, 17);
            this.komediCheck.TabIndex = 7;
            this.komediCheck.Text = "Komedi";
            this.komediCheck.UseVisualStyleBackColor = true;
            this.komediCheck.CheckedChanged += new System.EventHandler(this.komediCheck_CheckedChanged);
            // 
            // bilimDogaCheck
            // 
            this.bilimDogaCheck.AutoSize = true;
            this.bilimDogaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilimDogaCheck.Location = new System.Drawing.Point(332, 153);
            this.bilimDogaCheck.Name = "bilimDogaCheck";
            this.bilimDogaCheck.Size = new System.Drawing.Size(91, 17);
            this.bilimDogaCheck.TabIndex = 8;
            this.bilimDogaCheck.Text = "Bilim ve Doğa";
            this.bilimDogaCheck.UseVisualStyleBackColor = true;
            this.bilimDogaCheck.CheckedChanged += new System.EventHandler(this.bilimDogaCheck_CheckedChanged);
            // 
            // korkuCheck
            // 
            this.korkuCheck.AutoSize = true;
            this.korkuCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.korkuCheck.Location = new System.Drawing.Point(332, 194);
            this.korkuCheck.Name = "korkuCheck";
            this.korkuCheck.Size = new System.Drawing.Size(54, 17);
            this.korkuCheck.TabIndex = 9;
            this.korkuCheck.Text = "Korku";
            this.korkuCheck.UseVisualStyleBackColor = true;
            this.korkuCheck.CheckedChanged += new System.EventHandler(this.korkuCheck_CheckedChanged);
            // 
            // gerilimCheck
            // 
            this.gerilimCheck.AutoSize = true;
            this.gerilimCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gerilimCheck.Location = new System.Drawing.Point(332, 232);
            this.gerilimCheck.Name = "gerilimCheck";
            this.gerilimCheck.Size = new System.Drawing.Size(57, 17);
            this.gerilimCheck.TabIndex = 10;
            this.gerilimCheck.Text = "Gerilim";
            this.gerilimCheck.UseVisualStyleBackColor = true;
            this.gerilimCheck.CheckedChanged += new System.EventHandler(this.gerilimCheck_CheckedChanged);
            // 
            // realityCheck
            // 
            this.realityCheck.AutoSize = true;
            this.realityCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.realityCheck.Location = new System.Drawing.Point(332, 277);
            this.realityCheck.Name = "realityCheck";
            this.realityCheck.Size = new System.Drawing.Size(100, 17);
            this.realityCheck.TabIndex = 11;
            this.realityCheck.Text = "Reality Program";
            this.realityCheck.UseVisualStyleBackColor = true;
            this.realityCheck.CheckedChanged += new System.EventHandler(this.realityCheck_CheckedChanged);
            // 
            // animeCheck
            // 
            this.animeCheck.AutoSize = true;
            this.animeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.animeCheck.Location = new System.Drawing.Point(332, 313);
            this.animeCheck.Name = "animeCheck";
            this.animeCheck.Size = new System.Drawing.Size(55, 17);
            this.animeCheck.TabIndex = 12;
            this.animeCheck.Text = "Anime";
            this.animeCheck.UseVisualStyleBackColor = true;
            this.animeCheck.CheckedChanged += new System.EventHandler(this.animeCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.animeCheck);
            this.Controls.Add(this.realityCheck);
            this.Controls.Add(this.gerilimCheck);
            this.Controls.Add(this.korkuCheck);
            this.Controls.Add(this.bilimDogaCheck);
            this.Controls.Add(this.komediCheck);
            this.Controls.Add(this.belgeselCheck);
            this.Controls.Add(this.cocukCheck);
            this.Controls.Add(this.dramaCheck);
            this.Controls.Add(this.romantikCheck);
            this.Controls.Add(this.bilimKurguCheck);
            this.Controls.Add(this.aksiyonMaceraCheck);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newUser";
            this.Text = "newUser";
            this.Load += new System.EventHandler(this.newUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox aksiyonMaceraCheck;
        private System.Windows.Forms.CheckBox bilimKurguCheck;
        private System.Windows.Forms.CheckBox romantikCheck;
        private System.Windows.Forms.CheckBox dramaCheck;
        private System.Windows.Forms.CheckBox cocukCheck;
        private System.Windows.Forms.CheckBox belgeselCheck;
        private System.Windows.Forms.CheckBox komediCheck;
        private System.Windows.Forms.CheckBox bilimDogaCheck;
        private System.Windows.Forms.CheckBox korkuCheck;
        private System.Windows.Forms.CheckBox gerilimCheck;
        private System.Windows.Forms.CheckBox realityCheck;
        private System.Windows.Forms.CheckBox animeCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}