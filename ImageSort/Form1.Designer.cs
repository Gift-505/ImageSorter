namespace ImageSort
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
            this._lblHydrant = new System.Windows.Forms.Label();
            this._lblBench = new System.Windows.Forms.Label();
            this._lblBin = new System.Windows.Forms.Label();
            this._pctPreview = new System.Windows.Forms.PictureBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this._btnAnalyze = new System.Windows.Forms.Button();
            this._txtSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._pctPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblHydrant
            // 
            this._lblHydrant.AutoSize = true;
            this._lblHydrant.Location = new System.Drawing.Point(45, 38);
            this._lblHydrant.Name = "_lblHydrant";
            this._lblHydrant.Size = new System.Drawing.Size(50, 15);
            this._lblHydrant.TabIndex = 0;
            this._lblHydrant.Text = "Hydrant";
            // 
            // _lblBench
            // 
            this._lblBench.AutoSize = true;
            this._lblBench.Location = new System.Drawing.Point(45, 9);
            this._lblBench.Name = "_lblBench";
            this._lblBench.Size = new System.Drawing.Size(46, 15);
            this._lblBench.TabIndex = 1;
            this._lblBench.Text = "Lavička";
            // 
            // _lblBin
            // 
            this._lblBin.AutoSize = true;
            this._lblBin.Location = new System.Drawing.Point(45, 71);
            this._lblBin.Name = "_lblBin";
            this._lblBin.Size = new System.Drawing.Size(26, 15);
            this._lblBin.TabIndex = 2;
            this._lblBin.Text = "Koš";
            // 
            // _pctPreview
            // 
            this._pctPreview.Location = new System.Drawing.Point(141, 9);
            this._pctPreview.Name = "_pctPreview";
            this._pctPreview.Size = new System.Drawing.Size(258, 272);
            this._pctPreview.TabIndex = 3;
            this._pctPreview.TabStop = false;
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(22, 118);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 23);
            this._txtName.TabIndex = 4;
            // 
            // _btnAnalyze
            // 
            this._btnAnalyze.Location = new System.Drawing.Point(35, 176);
            this._btnAnalyze.Name = "_btnAnalyze";
            this._btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this._btnAnalyze.TabIndex = 5;
            this._btnAnalyze.Text = "button1";
            this._btnAnalyze.UseVisualStyleBackColor = true;
            this._btnAnalyze.Click += new System.EventHandler(this._btnAnalyze_Click);
            // 
            // _txtSurname
            // 
            this._txtSurname.Location = new System.Drawing.Point(22, 147);
            this._txtSurname.Name = "_txtSurname";
            this._txtSurname.Size = new System.Drawing.Size(100, 23);
            this._txtSurname.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 291);
            this.Controls.Add(this._btnAnalyze);
            this.Controls.Add(this._txtSurname);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._pctPreview);
            this.Controls.Add(this._lblBin);
            this.Controls.Add(this._lblBench);
            this.Controls.Add(this._lblHydrant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pctPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _lblHydrant;
        private Label _lblBench;
        private Label _lblBin;
        private PictureBox _pctPreview;
        private TextBox _txtName;
        private Button _btnAnalyze;
        private TextBox _txtSurname;
    }
}