namespace PlayDespacito
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxSpeech = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxSpeech
            // 
            this.rtxSpeech.Location = new System.Drawing.Point(12, 12);
            this.rtxSpeech.Name = "rtxSpeech";
            this.rtxSpeech.Size = new System.Drawing.Size(289, 129);
            this.rtxSpeech.TabIndex = 0;
            this.rtxSpeech.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(189, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Textbox";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(12, 147);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(112, 31);
            this.btnRecognize.TabIndex = 2;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtxSpeech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Speech Recognition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxSpeech;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRecognize;
    }
}

