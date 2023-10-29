namespace HorseRaceWithTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFınısh = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxBrown = new System.Windows.Forms.PictureBox();
            this.pbxWhite = new System.Windows.Forms.PictureBox();
            this.pbxBlack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFınısh
            // 
            this.btnFınısh.BackColor = System.Drawing.Color.Red;
            this.btnFınısh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFınısh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFınısh.Location = new System.Drawing.Point(783, 66);
            this.btnFınısh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFınısh.Name = "btnFınısh";
            this.btnFınısh.Size = new System.Drawing.Size(54, 408);
            this.btnFınısh.TabIndex = 5;
            this.btnFınısh.Text = "FINISH";
            this.btnFınısh.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(28, 47);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 41);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Indigo;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(230, 47);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 41);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBreak.Location = new System.Drawing.Point(432, 47);
            this.btnBreak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(136, 41);
            this.btnBreak.TabIndex = 9;
            this.btnBreak.Text = "BREAK";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxBrown
            // 
            this.pbxBrown.AccessibleName = "            throw new NotImplementedException();\r\n";
            this.pbxBrown.Image = global::HorseRaceWithTimer.Properties.Resources.BrownHorse;
            this.pbxBrown.Location = new System.Drawing.Point(12, 367);
            this.pbxBrown.Name = "pbxBrown";
            this.pbxBrown.Size = new System.Drawing.Size(136, 82);
            this.pbxBrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBrown.TabIndex = 10;
            this.pbxBrown.TabStop = false;
            // 
            // pbxWhite
            // 
            this.pbxWhite.AccessibleName = "            throw new NotImplementedException();\r\n";
            this.pbxWhite.Image = global::HorseRaceWithTimer.Properties.Resources.WhiteHorse;
            this.pbxWhite.Location = new System.Drawing.Point(12, 257);
            this.pbxWhite.Name = "pbxWhite";
            this.pbxWhite.Size = new System.Drawing.Size(136, 82);
            this.pbxWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWhite.TabIndex = 7;
            this.pbxWhite.TabStop = false;
            // 
            // pbxBlack
            // 
            this.pbxBlack.AccessibleName = "            throw new NotImplementedException();\r\n";
            this.pbxBlack.Image = ((System.Drawing.Image)(resources.GetObject("pbxBlack.Image")));
            this.pbxBlack.Location = new System.Drawing.Point(12, 147);
            this.pbxBlack.Name = "pbxBlack";
            this.pbxBlack.Size = new System.Drawing.Size(136, 82);
            this.pbxBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBlack.TabIndex = 6;
            this.pbxBlack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 511);
            this.Controls.Add(this.pbxBrown);
            this.Controls.Add(this.pbxWhite);
            this.Controls.Add(this.pbxBlack);
            this.Controls.Add(this.btnFınısh);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxBlack;
        private System.Windows.Forms.Button btnFınısh;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbxWhite;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxBrown;
    }
}

