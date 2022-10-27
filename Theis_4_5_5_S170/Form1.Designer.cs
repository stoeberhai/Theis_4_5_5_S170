namespace Theis_4_5_5_S170
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.CmdAnzeigen3 = new System.Windows.Forms.Button();
            this.CmdAnzeigen4 = new System.Windows.Forms.Button();
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(12, 52);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(170, 23);
            this.CmdAnzeigen2.TabIndex = 1;
            this.CmdAnzeigen2.Text = "rot, Striche, 2, 5";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // CmdAnzeigen3
            // 
            this.CmdAnzeigen3.Location = new System.Drawing.Point(12, 95);
            this.CmdAnzeigen3.Name = "CmdAnzeigen3";
            this.CmdAnzeigen3.Size = new System.Drawing.Size(170, 23);
            this.CmdAnzeigen3.TabIndex = 2;
            this.CmdAnzeigen3.Text = "gelb, 7";
            this.CmdAnzeigen3.UseVisualStyleBackColor = true;
            this.CmdAnzeigen3.Click += new System.EventHandler(this.CmdAnzeigen3_Click);
            // 
            // CmdAnzeigen4
            // 
            this.CmdAnzeigen4.Location = new System.Drawing.Point(12, 138);
            this.CmdAnzeigen4.Name = "CmdAnzeigen4";
            this.CmdAnzeigen4.Size = new System.Drawing.Size(170, 23);
            this.CmdAnzeigen4.TabIndex = 3;
            this.CmdAnzeigen4.Text = "blau, Haarlinie";
            this.CmdAnzeigen4.UseVisualStyleBackColor = true;
            this.CmdAnzeigen4.Click += new System.EventHandler(this.CmdAnzeigen4_Click);
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(12, 12);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(170, 23);
            this.CmdAnzeigen1.TabIndex = 4;
            this.CmdAnzeigen1.Text = "rot, 4, 6, Punkte";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(246, 20);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(37, 15);
            this.LblAnzeige.TabIndex = 5;
            this.LblAnzeige.Text = "Wahl:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 227);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Controls.Add(this.CmdAnzeigen4);
            this.Controls.Add(this.CmdAnzeigen3);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Theis 4.5.5, S.170: Benannte Argumente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Button CmdAnzeigen1;
        private Label LblAnzeige;
    }
}