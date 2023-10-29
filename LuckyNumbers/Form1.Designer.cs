namespace LuckyNumbers
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
            this.lbxNumbers = new System.Windows.Forms.ListBox();
            this.grpNumbers = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnTry = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxNumbers
            // 
            this.lbxNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxNumbers.FormattingEnabled = true;
            this.lbxNumbers.ItemHeight = 25;
            this.lbxNumbers.Location = new System.Drawing.Point(22, 82);
            this.lbxNumbers.Name = "lbxNumbers";
            this.lbxNumbers.Size = new System.Drawing.Size(127, 154);
            this.lbxNumbers.TabIndex = 0;
            // 
            // grpNumbers
            // 
            this.grpNumbers.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpNumbers.Controls.Add(this.lbl6);
            this.grpNumbers.Controls.Add(this.lbl5);
            this.grpNumbers.Controls.Add(this.lbl3);
            this.grpNumbers.Controls.Add(this.lbl4);
            this.grpNumbers.Controls.Add(this.lbl2);
            this.grpNumbers.Controls.Add(this.lbl1);
            this.grpNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpNumbers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpNumbers.Location = new System.Drawing.Point(181, 78);
            this.grpNumbers.Name = "grpNumbers";
            this.grpNumbers.Size = new System.Drawing.Size(575, 164);
            this.grpNumbers.TabIndex = 1;
            this.grpNumbers.TabStop = false;
            this.grpNumbers.Text = " Lucky Numbers";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(20, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 63);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "00";
            // 
            // btnTry
            // 
            this.btnTry.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTry.Location = new System.Drawing.Point(32, 9);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(117, 51);
            this.btnTry.TabIndex = 2;
            this.btnTry.Text = "TRY!";
            this.btnTry.UseVisualStyleBackColor = false;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(109, 59);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(89, 63);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "00";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4.Location = new System.Drawing.Point(287, 59);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(89, 63);
            this.lbl4.TabIndex = 2;
            this.lbl4.Text = "00";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(198, 59);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(89, 63);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "00";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5.Location = new System.Drawing.Point(376, 59);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(89, 63);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "00";
            this.lbl5.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl6.Location = new System.Drawing.Point(465, 59);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(89, 63);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 261);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.grpNumbers);
            this.Controls.Add(this.lbxNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNumbers.ResumeLayout(false);
            this.grpNumbers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNumbers;
        private System.Windows.Forms.GroupBox grpNumbers;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Timer timer1;
    }
}

