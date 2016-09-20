namespace Nightfall
{
    partial class frmMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessages));
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRiddle = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lsbRiddle = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGo.Location = new System.Drawing.Point(125, 353);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(288, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(457, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRiddle
            // 
            this.lblRiddle.AutoSize = true;
            this.lblRiddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiddle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRiddle.Location = new System.Drawing.Point(241, 18);
            this.lblRiddle.Name = "lblRiddle";
            this.lblRiddle.Size = new System.Drawing.Size(244, 25);
            this.lblRiddle.TabIndex = 3;
            this.lblRiddle.Text = "Can you guess the answer";
            // 
            // txtGuess
            // 
            this.txtGuess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGuess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGuess.Location = new System.Drawing.Point(216, 301);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(269, 22);
            this.txtGuess.TabIndex = 5;
            // 
            // lsbRiddle
            // 
            this.lsbRiddle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lsbRiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbRiddle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsbRiddle.FormattingEnabled = true;
            this.lsbRiddle.HorizontalScrollbar = true;
            this.lsbRiddle.ItemHeight = 20;
            this.lsbRiddle.Location = new System.Drawing.Point(3, 71);
            this.lsbRiddle.Name = "lsbRiddle";
            this.lsbRiddle.Size = new System.Drawing.Size(752, 204);
            this.lsbRiddle.TabIndex = 6;
            // 
            // frmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nightfall.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(758, 411);
            this.Controls.Add(this.lsbRiddle);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblRiddle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMessages";
            this.Text = "Messages";
            this.Shown += new System.EventHandler(this.frmMessages_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRiddle;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.ListBox lsbRiddle;
    }
}