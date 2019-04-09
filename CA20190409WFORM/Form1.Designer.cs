namespace CA20190409WFORM
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbnev = new System.Windows.Forms.TextBox();
            this.tbtipp = new System.Windows.Forms.TextBox();
            this.btnhozzaad = new System.Windows.Forms.Button();
            this.lbldb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(200, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(200, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Játékos tippjei:";
            // 
            // tbnev
            // 
            this.tbnev.Location = new System.Drawing.Point(383, 116);
            this.tbnev.Name = "tbnev";
            this.tbnev.Size = new System.Drawing.Size(194, 20);
            this.tbnev.TabIndex = 3;
            // 
            // tbtipp
            // 
            this.tbtipp.Location = new System.Drawing.Point(383, 178);
            this.tbtipp.Name = "tbtipp";
            this.tbtipp.Size = new System.Drawing.Size(194, 20);
            this.tbtipp.TabIndex = 4;
            this.tbtipp.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnhozzaad
            // 
            this.btnhozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnhozzaad.Location = new System.Drawing.Point(205, 231);
            this.btnhozzaad.Name = "btnhozzaad";
            this.btnhozzaad.Size = new System.Drawing.Size(372, 38);
            this.btnhozzaad.TabIndex = 5;
            this.btnhozzaad.Text = "Játékos hozzáadása";
            this.btnhozzaad.UseVisualStyleBackColor = true;
            this.btnhozzaad.Click += new System.EventHandler(this.btnhozzaad_Click);
            // 
            // lbldb
            // 
            this.lbldb.AutoSize = true;
            this.lbldb.Location = new System.Drawing.Point(583, 184);
            this.lbldb.Name = "lbldb";
            this.lbldb.Size = new System.Drawing.Size(19, 13);
            this.lbldb.TabIndex = 6;
            this.lbldb.Text = "db";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldb);
            this.Controls.Add(this.btnhozzaad);
            this.Controls.Add(this.tbtipp);
            this.Controls.Add(this.tbnev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EgyszamjatekGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnev;
        private System.Windows.Forms.TextBox tbtipp;
        private System.Windows.Forms.Button btnhozzaad;
        private System.Windows.Forms.Label lbldb;
    }
}

