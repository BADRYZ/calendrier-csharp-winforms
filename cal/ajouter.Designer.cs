namespace cal
{
    partial class ajouter
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
            this.datefield = new System.Windows.Forms.TextBox();
            this.labdate = new System.Windows.Forms.Label();
            this.labserv = new System.Windows.Forms.Label();
            this.labshift = new System.Windows.Forms.Label();
            this.btncommit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxShifts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // datefield
            // 
            this.datefield.Location = new System.Drawing.Point(245, 83);
            this.datefield.Name = "datefield";
            this.datefield.Size = new System.Drawing.Size(270, 29);
            this.datefield.TabIndex = 0;
            this.datefield.TextChanged += new System.EventHandler(this.datefield_TextChanged);
            // 
            // labdate
            // 
            this.labdate.AutoSize = true;
            this.labdate.Location = new System.Drawing.Point(156, 83);
            this.labdate.Name = "labdate";
            this.labdate.Size = new System.Drawing.Size(50, 25);
            this.labdate.TabIndex = 2;
            this.labdate.Text = "date";
            // 
            // labserv
            // 
            this.labserv.AutoSize = true;
            this.labserv.Location = new System.Drawing.Point(156, 166);
            this.labserv.Name = "labserv";
            this.labserv.Size = new System.Drawing.Size(77, 25);
            this.labserv.TabIndex = 3;
            this.labserv.Text = "serveur";
            // 
            // labshift
            // 
            this.labshift.AutoSize = true;
            this.labshift.Location = new System.Drawing.Point(156, 260);
            this.labshift.Name = "labshift";
            this.labshift.Size = new System.Drawing.Size(47, 25);
            this.labshift.TabIndex = 5;
            this.labshift.Text = "shift";
            // 
            // btncommit
            // 
            this.btncommit.Location = new System.Drawing.Point(546, 324);
            this.btncommit.Name = "btncommit";
            this.btncommit.Size = new System.Drawing.Size(137, 46);
            this.btncommit.TabIndex = 6;
            this.btncommit.Text = "commit";
            this.btncommit.UseVisualStyleBackColor = true;
            this.btncommit.Click += new System.EventHandler(this.btncommit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 32);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxShifts
            // 
            this.comboBoxShifts.FormattingEnabled = true;
            this.comboBoxShifts.Location = new System.Drawing.Point(245, 257);
            this.comboBoxShifts.Name = "comboBoxShifts";
            this.comboBoxShifts.Size = new System.Drawing.Size(270, 32);
            this.comboBoxShifts.TabIndex = 8;
            // 
            // ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 382);
            this.Controls.Add(this.comboBoxShifts);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btncommit);
            this.Controls.Add(this.labshift);
            this.Controls.Add(this.labserv);
            this.Controls.Add(this.labdate);
            this.Controls.Add(this.datefield);
            this.Name = "ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajouter";
            this.Load += new System.EventHandler(this.ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox datefield;
        private System.Windows.Forms.Label labdate;
        private System.Windows.Forms.Label labserv;
        private System.Windows.Forms.Label labshift;
        private System.Windows.Forms.Button btncommit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxShifts;
    }
}