namespace WindowsFormsıntro
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.chbBook = new System.Windows.Forms.CheckBox();
            this.chbMusic = new System.Windows.Forms.CheckBox();
            this.chbCinema = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbNumbers = new System.Windows.Forms.ComboBox();
            this.btnfener = new System.Windows.Forms.Button();
            this.lbxStudent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisplay.ForeColor = System.Drawing.Color.Purple;
            this.btnDisplay.Location = new System.Drawing.Point(12, 25);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(115, 35);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnMessage.Location = new System.Drawing.Point(156, 25);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(124, 42);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // chbBook
            // 
            this.chbBook.AutoSize = true;
            this.chbBook.BackColor = System.Drawing.SystemColors.Menu;
            this.chbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbBook.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chbBook.Location = new System.Drawing.Point(28, 108);
            this.chbBook.Name = "chbBook";
            this.chbBook.Size = new System.Drawing.Size(65, 24);
            this.chbBook.TabIndex = 2;
            this.chbBook.Text = "Book";
            this.chbBook.UseVisualStyleBackColor = false;
            // 
            // chbMusic
            // 
            this.chbMusic.AutoSize = true;
            this.chbMusic.BackColor = System.Drawing.SystemColors.Menu;
            this.chbMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbMusic.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chbMusic.Location = new System.Drawing.Point(28, 154);
            this.chbMusic.Name = "chbMusic";
            this.chbMusic.Size = new System.Drawing.Size(69, 24);
            this.chbMusic.TabIndex = 3;
            this.chbMusic.Text = "Music";
            this.chbMusic.UseVisualStyleBackColor = false;
            // 
            // chbCinema
            // 
            this.chbCinema.AutoSize = true;
            this.chbCinema.BackColor = System.Drawing.SystemColors.Menu;
            this.chbCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbCinema.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chbCinema.Location = new System.Drawing.Point(28, 208);
            this.chbCinema.Name = "chbCinema";
            this.chbCinema.Size = new System.Drawing.Size(82, 24);
            this.chbCinema.TabIndex = 4;
            this.chbCinema.Text = "Cinema";
            this.chbCinema.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblResult.Location = new System.Drawing.Point(20, 269);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(36, 46);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "*";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnMale.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnMale.Location = new System.Drawing.Point(175, 108);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(77, 29);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.ForeColor = System.Drawing.Color.Coral;
            this.rbtnFemale.Location = new System.Drawing.Point(175, 154);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(102, 28);
            this.rbtnFemale.TabIndex = 7;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.ForeColor = System.Drawing.Color.Red;
            this.txtInput.Location = new System.Drawing.Point(318, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(185, 30);
            this.txtInput.TabIndex = 8;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // cmbNumbers
            // 
            this.cmbNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbNumbers.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cmbNumbers.FormattingEnabled = true;
            this.cmbNumbers.Location = new System.Drawing.Point(527, 25);
            this.cmbNumbers.Name = "cmbNumbers";
            this.cmbNumbers.Size = new System.Drawing.Size(121, 33);
            this.cmbNumbers.TabIndex = 9;
            this.cmbNumbers.SelectedIndexChanged += new System.EventHandler(this.cmbNumbers_SelectedIndexChanged);
            // 
            // btnfener
            // 
            this.btnfener.BackColor = System.Drawing.Color.Yellow;
            this.btnfener.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfener.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnfener.Location = new System.Drawing.Point(365, 143);
            this.btnfener.Name = "btnfener";
            this.btnfener.Size = new System.Drawing.Size(298, 89);
            this.btnfener.TabIndex = 10;
            this.btnfener.Text = "Sarı";
            this.btnfener.UseVisualStyleBackColor = false;
            this.btnfener.Click += new System.EventHandler(this.btnfener_Click);
            // 
            // lbxStudent
            // 
            this.lbxStudent.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxStudent.ForeColor = System.Drawing.Color.Olive;
            this.lbxStudent.FormattingEnabled = true;
            this.lbxStudent.ItemHeight = 31;
            this.lbxStudent.Location = new System.Drawing.Point(686, 27);
            this.lbxStudent.Name = "lbxStudent";
            this.lbxStudent.Size = new System.Drawing.Size(147, 190);
            this.lbxStudent.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 332);
            this.Controls.Add(this.lbxStudent);
            this.Controls.Add(this.btnfener);
            this.Controls.Add(this.cmbNumbers);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chbCinema);
            this.Controls.Add(this.chbMusic);
            this.Controls.Add(this.chbBook);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.CheckBox chbBook;
        private System.Windows.Forms.CheckBox chbMusic;
        private System.Windows.Forms.CheckBox chbCinema;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cmbNumbers;
        private System.Windows.Forms.Button btnfener;
        private System.Windows.Forms.ListBox lbxStudent;
    }
}

