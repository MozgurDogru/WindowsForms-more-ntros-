namespace HorseRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFınısh = new System.Windows.Forms.Button();
            this.pbxBlack = new System.Windows.Forms.PictureBox();
            this.pbxWhite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(36, 29);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFınısh
            // 
            this.btnFınısh.BackColor = System.Drawing.Color.Red;
            this.btnFınısh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFınısh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFınısh.Location = new System.Drawing.Point(851, 29);
            this.btnFınısh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFınısh.Name = "btnFınısh";
            this.btnFınısh.Size = new System.Drawing.Size(54, 356);
            this.btnFınısh.TabIndex = 1;
            this.btnFınısh.Text = "FINISH";
            this.btnFınısh.UseVisualStyleBackColor = false;
            this.btnFınısh.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbxBlack
            // 
            this.pbxBlack.AccessibleName = "            throw new NotImplementedException();\r\n";
            this.pbxBlack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBlack.Image")));
            this.pbxBlack.Location = new System.Drawing.Point(30, 127);
            this.pbxBlack.Name = "pbxBlack";
            this.pbxBlack.Size = new System.Drawing.Size(136, 82);
            this.pbxBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBlack.TabIndex = 2;
            this.pbxBlack.TabStop = false;
            this.pbxBlack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbxWhite
            // 
            this.pbxWhite.AccessibleName = "            throw new NotImplementedException();\r\n";
            this.pbxWhite.Image = global::HorseRace.Properties.Resources.WhiteHorse;
            this.pbxWhite.Location = new System.Drawing.Point(30, 231);
            this.pbxWhite.Name = "pbxWhite";
            this.pbxWhite.Size = new System.Drawing.Size(136, 82);
            this.pbxWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWhite.TabIndex = 3;
            this.pbxWhite.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.pbxWhite);
            this.Controls.Add(this.pbxBlack);
            this.Controls.Add(this.btnFınısh);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWhite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFınısh;
        private System.Windows.Forms.PictureBox pbxBlack;
        private System.Windows.Forms.PictureBox pbxWhite;
    }
}

