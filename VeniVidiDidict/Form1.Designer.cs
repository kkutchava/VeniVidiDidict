
namespace VeniVidiDidict
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
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.InfoButton1 = new System.Windows.Forms.Button();
            this.InfoButton2 = new System.Windows.Forms.Button();
            this.CastleButton1_1 = new System.Windows.Forms.Button();
            this.CastleButton1_3 = new System.Windows.Forms.Button();
            this.CastleButton2_1 = new System.Windows.Forms.Button();
            this.CastleButton2_2 = new System.Windows.Forms.Button();
            this.CastleButton1_2 = new System.Windows.Forms.Button();
            this.appInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPicture
            // 
            this.MainPicture.Image = global::VeniVidiDidict.Properties.Resources.map;
            this.MainPicture.Location = new System.Drawing.Point(1, 0);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(799, 451);
            this.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPicture.TabIndex = 0;
            this.MainPicture.TabStop = false;
            // 
            // fightButton
            // 
            this.fightButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fightButton.ForeColor = System.Drawing.Color.Gold;
            this.fightButton.Location = new System.Drawing.Point(331, 424);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(126, 27);
            this.fightButton.TabIndex = 1;
            this.fightButton.Text = "Fight!";
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Click += new System.EventHandler(this.Fight);
            // 
            // InfoButton1
            // 
            this.InfoButton1.BackColor = System.Drawing.Color.Olive;
            this.InfoButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.InfoButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.InfoButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.InfoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton1.Location = new System.Drawing.Point(73, 265);
            this.InfoButton1.Name = "InfoButton1";
            this.InfoButton1.Size = new System.Drawing.Size(39, 20);
            this.InfoButton1.TabIndex = 2;
            this.InfoButton1.UseVisualStyleBackColor = false;
            this.InfoButton1.Click += new System.EventHandler(this.Info);
            // 
            // InfoButton2
            // 
            this.InfoButton2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.InfoButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.InfoButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.InfoButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.InfoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton2.Location = new System.Drawing.Point(670, 326);
            this.InfoButton2.Name = "InfoButton2";
            this.InfoButton2.Size = new System.Drawing.Size(39, 20);
            this.InfoButton2.TabIndex = 3;
            this.InfoButton2.UseVisualStyleBackColor = false;
            this.InfoButton2.Click += new System.EventHandler(this.Info);
            // 
            // CastleButton1_1
            // 
            this.CastleButton1_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CastleButton1_1.Location = new System.Drawing.Point(222, 265);
            this.CastleButton1_1.Name = "CastleButton1_1";
            this.CastleButton1_1.Size = new System.Drawing.Size(73, 10);
            this.CastleButton1_1.TabIndex = 4;
            this.CastleButton1_1.UseVisualStyleBackColor = false;
            this.CastleButton1_1.Click += new System.EventHandler(this.Castle_Click);
            // 
            // CastleButton1_3
            // 
            this.CastleButton1_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CastleButton1_3.Location = new System.Drawing.Point(183, 129);
            this.CastleButton1_3.Name = "CastleButton1_3";
            this.CastleButton1_3.Size = new System.Drawing.Size(41, 10);
            this.CastleButton1_3.TabIndex = 5;
            this.CastleButton1_3.UseVisualStyleBackColor = false;
            this.CastleButton1_3.Click += new System.EventHandler(this.Castle_Click);
            // 
            // CastleButton2_1
            // 
            this.CastleButton2_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CastleButton2_1.Location = new System.Drawing.Point(486, 138);
            this.CastleButton2_1.Name = "CastleButton2_1";
            this.CastleButton2_1.Size = new System.Drawing.Size(73, 10);
            this.CastleButton2_1.TabIndex = 6;
            this.CastleButton2_1.UseVisualStyleBackColor = false;
            this.CastleButton2_1.Click += new System.EventHandler(this.Castle_Click);
            // 
            // CastleButton2_2
            // 
            this.CastleButton2_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CastleButton2_2.Location = new System.Drawing.Point(591, 244);
            this.CastleButton2_2.Name = "CastleButton2_2";
            this.CastleButton2_2.Size = new System.Drawing.Size(73, 10);
            this.CastleButton2_2.TabIndex = 7;
            this.CastleButton2_2.UseVisualStyleBackColor = false;
            this.CastleButton2_2.Click += new System.EventHandler(this.Castle_Click);
            // 
            // CastleButton1_2
            // 
            this.CastleButton1_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CastleButton1_2.Location = new System.Drawing.Point(115, 336);
            this.CastleButton1_2.Name = "CastleButton1_2";
            this.CastleButton1_2.Size = new System.Drawing.Size(65, 10);
            this.CastleButton1_2.TabIndex = 8;
            this.CastleButton1_2.UseVisualStyleBackColor = false;
            this.CastleButton1_2.Click += new System.EventHandler(this.Castle_Click);
            // 
            // appInfo
            // 
            this.appInfo.BackColor = System.Drawing.Color.Maroon;
            this.appInfo.Location = new System.Drawing.Point(1, 28);
            this.appInfo.Name = "appInfo";
            this.appInfo.Size = new System.Drawing.Size(149, 10);
            this.appInfo.TabIndex = 9;
            this.appInfo.UseVisualStyleBackColor = false;
            this.appInfo.Click += new System.EventHandler(this.Info);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appInfo);
            this.Controls.Add(this.CastleButton1_2);
            this.Controls.Add(this.CastleButton2_2);
            this.Controls.Add(this.CastleButton2_1);
            this.Controls.Add(this.CastleButton1_3);
            this.Controls.Add(this.CastleButton1_1);
            this.Controls.Add(this.InfoButton2);
            this.Controls.Add(this.InfoButton1);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.MainPicture);
            this.Name = "Form1";
            this.Text = "Veni Vidi Didict";
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button InfoButton1;
        private System.Windows.Forms.Button InfoButton2;
        private System.Windows.Forms.Button CastleButton1_1;
        private System.Windows.Forms.Button CastleButton1_3;
        private System.Windows.Forms.Button CastleButton2_1;
        private System.Windows.Forms.Button CastleButton2_2;
        private System.Windows.Forms.Button CastleButton1_2;
        private System.Windows.Forms.Button appInfo;
    }
}

