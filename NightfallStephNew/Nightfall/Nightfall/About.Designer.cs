namespace Nightfall
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblNames = new System.Windows.Forms.Label();
            this.lblCorrey = new System.Windows.Forms.Label();
            this.lblStephanie = new System.Windows.Forms.Label();
            this.lblJared = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNames.Location = new System.Drawing.Point(227, 46);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(236, 69);
            this.lblNames.TabIndex = 0;
            this.lblNames.Text = "Authors";
            // 
            // lblCorrey
            // 
            this.lblCorrey.AutoSize = true;
            this.lblCorrey.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrey.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCorrey.Location = new System.Drawing.Point(220, 146);
            this.lblCorrey.Name = "lblCorrey";
            this.lblCorrey.Size = new System.Drawing.Size(158, 29);
            this.lblCorrey.TabIndex = 1;
            this.lblCorrey.Text = "Correy Winke";
            // 
            // lblStephanie
            // 
            this.lblStephanie.AutoSize = true;
            this.lblStephanie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStephanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStephanie.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStephanie.Location = new System.Drawing.Point(220, 202);
            this.lblStephanie.Name = "lblStephanie";
            this.lblStephanie.Size = new System.Drawing.Size(201, 29);
            this.lblStephanie.TabIndex = 2;
            this.lblStephanie.Text = "Stephanie Wilson";
            // 
            // lblJared
            // 
            this.lblJared.AutoSize = true;
            this.lblJared.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJared.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJared.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblJared.Location = new System.Drawing.Point(220, 257);
            this.lblJared.Name = "lblJared";
            this.lblJared.Size = new System.Drawing.Size(182, 29);
            this.lblJared.TabIndex = 3;
            this.lblJared.Text = "Jared Schindler";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(239, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nightfall.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(691, 425);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblJared);
            this.Controls.Add(this.lblStephanie);
            this.Controls.Add(this.lblCorrey);
            this.Controls.Add(this.lblNames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblCorrey;
        private System.Windows.Forms.Label lblStephanie;
        private System.Windows.Forms.Label lblJared;
        private System.Windows.Forms.Button btnExit;
    }
}