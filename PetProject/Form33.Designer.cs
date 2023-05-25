namespace PetProject
{
    partial class Form33
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
            this.Pet1 = new System.Windows.Forms.Button();
            this.Pet2 = new System.Windows.Forms.Button();
            this.Pet3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAYVANLAR";
            // 
            // Pet1
            // 
            this.Pet1.Location = new System.Drawing.Point(172, 181);
            this.Pet1.Name = "Pet1";
            this.Pet1.Size = new System.Drawing.Size(120, 46);
            this.Pet1.TabIndex = 13;
            this.Pet1.Text = "Pet1";
            this.Pet1.UseVisualStyleBackColor = true;
            // 
            // Pet2
            // 
            this.Pet2.Location = new System.Drawing.Point(172, 225);
            this.Pet2.Name = "Pet2";
            this.Pet2.Size = new System.Drawing.Size(120, 46);
            this.Pet2.TabIndex = 14;
            this.Pet2.Text = "Pet2";
            this.Pet2.UseVisualStyleBackColor = true;
            // 
            // Pet3
            // 
            this.Pet3.Location = new System.Drawing.Point(172, 269);
            this.Pet3.Name = "Pet3";
            this.Pet3.Size = new System.Drawing.Size(120, 46);
            this.Pet3.TabIndex = 15;
            this.Pet3.Text = "Pet3";
            this.Pet3.UseVisualStyleBackColor = true;
            // 
            // Form33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 473);
            this.Controls.Add(this.Pet3);
            this.Controls.Add(this.Pet2);
            this.Controls.Add(this.Pet1);
            this.Controls.Add(this.label1);
            this.Name = "Form33";
            this.Text = "Pet Tracking App- Hayvanlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form33_FormClosing);
            this.Load += new System.EventHandler(this.Form33_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pet1;
        private System.Windows.Forms.Button Pet2;
        private System.Windows.Forms.Button Pet3;
    }
}