namespace InterfazV1
{
    partial class formAyuda
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
            this.imgAyuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAyuda
            // 
            this.imgAyuda.BackgroundImage = global::InterfazV1.Properties.Resources.LAyuda;
            this.imgAyuda.Location = new System.Drawing.Point(0, 0);
            this.imgAyuda.Name = "imgAyuda";
            this.imgAyuda.Size = new System.Drawing.Size(1404, 420);
            this.imgAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAyuda.TabIndex = 0;
            this.imgAyuda.TabStop = false;
            // 
            // formAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.imgAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAyuda";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.imgAyuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAyuda;
    }
}