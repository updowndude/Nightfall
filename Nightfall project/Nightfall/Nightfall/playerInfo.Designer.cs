namespace Nightfall
{
    partial class frmplayerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmplayerInfo));
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblAllyOne = new System.Windows.Forms.Label();
            this.lblAllyTwo = new System.Windows.Forms.Label();
            this.txtAllyone = new System.Windows.Forms.TextBox();
            this.txtAllyTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radFemale.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radFemale.Location = new System.Drawing.Point(287, 105);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(75, 21);
            this.radFemale.TabIndex = 24;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = false;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radMale.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radMale.Location = new System.Drawing.Point(160, 105);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(59, 21);
            this.radMale.TabIndex = 23;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.Location = new System.Drawing.Point(149, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(408, 22);
            this.txtName.TabIndex = 22;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGender.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGender.Location = new System.Drawing.Point(59, 109);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Location = new System.Drawing.Point(32, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 17);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Main character";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(482, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(249, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGo.Location = new System.Drawing.Point(59, 366);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 17;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblAllyOne
            // 
            this.lblAllyOne.AutoSize = true;
            this.lblAllyOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAllyOne.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAllyOne.Location = new System.Drawing.Point(59, 171);
            this.lblAllyOne.Name = "lblAllyOne";
            this.lblAllyOne.Size = new System.Drawing.Size(58, 17);
            this.lblAllyOne.TabIndex = 25;
            this.lblAllyOne.Text = "Ally one";
            // 
            // lblAllyTwo
            // 
            this.lblAllyTwo.AutoSize = true;
            this.lblAllyTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAllyTwo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAllyTwo.Location = new System.Drawing.Point(62, 230);
            this.lblAllyTwo.Name = "lblAllyTwo";
            this.lblAllyTwo.Size = new System.Drawing.Size(55, 17);
            this.lblAllyTwo.TabIndex = 26;
            this.lblAllyTwo.Text = "Ally two";
            // 
            // txtAllyone
            // 
            this.txtAllyone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAllyone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAllyone.Location = new System.Drawing.Point(149, 166);
            this.txtAllyone.Name = "txtAllyone";
            this.txtAllyone.Size = new System.Drawing.Size(408, 22);
            this.txtAllyone.TabIndex = 27;
            // 
            // txtAllyTwo
            // 
            this.txtAllyTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAllyTwo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAllyTwo.Location = new System.Drawing.Point(149, 224);
            this.txtAllyTwo.Name = "txtAllyTwo";
            this.txtAllyTwo.Size = new System.Drawing.Size(408, 22);
            this.txtAllyTwo.TabIndex = 28;
            // 
            // frmplayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nightfall.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(613, 455);
            this.Controls.Add(this.txtAllyTwo);
            this.Controls.Add(this.txtAllyone);
            this.Controls.Add(this.lblAllyTwo);
            this.Controls.Add(this.lblAllyOne);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmplayerInfo";
            this.Text = "playerInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblAllyOne;
        private System.Windows.Forms.Label lblAllyTwo;
        private System.Windows.Forms.TextBox txtAllyone;
        private System.Windows.Forms.TextBox txtAllyTwo;
    }
}