namespace global_değisken_örnekleri
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTopla.Location = new System.Drawing.Point(38, 49);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(111, 66);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "TOPLA";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(47, 157);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(126, 46);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "label1";
            this.lblBakiye.Click += new System.EventHandler(this.lblBakiye_Click);
            // 
            // btnOde
            // 
            this.btnOde.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOde.Location = new System.Drawing.Point(155, 49);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(109, 66);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "ÖDE";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.btnTopla);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnOde;
    }
}

