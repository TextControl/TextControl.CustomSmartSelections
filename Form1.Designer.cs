namespace tx_sample_selectdecimalnumbers
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
            this.textControl1 = new TXTextControl.TextControl();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.ControlChars = true;
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(0, 0);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(542, 446);
            this.textControl1.TabIndex = 0;
            this.textControl1.Text = "Price: 20.33";
            this.textControl1.ViewMode = TXTextControl.ViewMode.PageView;
            this.textControl1.DoubleClick += new System.EventHandler(this.textControl1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 446);
            this.Controls.Add(this.textControl1);
            this.Name = "Form1";
            this.Text = "TX Text Control Sample: Select Decimal Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private TXTextControl.TextControl textControl1;
    }
}

