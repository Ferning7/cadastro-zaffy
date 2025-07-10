namespace cadastro
{
    partial class Conteudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteudo));
            navBar = new Panel();
            pbMinimize = new PictureBox();
            pbClose = new PictureBox();
            panelCentral = new Panel();
            navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // navBar
            // 
            navBar.BackColor = Color.Indigo;
            navBar.Controls.Add(pbMinimize);
            navBar.Controls.Add(pbClose);
            navBar.Dock = DockStyle.Top;
            navBar.Location = new Point(0, 0);
            navBar.Name = "navBar";
            navBar.Size = new Size(801, 32);
            navBar.TabIndex = 1;
            navBar.MouseDown += navBar_MouseDown;
            navBar.MouseMove += navBar_MouseMove;
            navBar.MouseUp += navBar_MouseUp;
            // 
            // pbMinimize
            // 
            pbMinimize.Cursor = Cursors.Hand;
            pbMinimize.Image = Properties.Resources.minimize;
            pbMinimize.Location = new Point(736, 3);
            pbMinimize.Name = "pbMinimize";
            pbMinimize.Size = new Size(28, 26);
            pbMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMinimize.TabIndex = 1;
            pbMinimize.TabStop = false;
            pbMinimize.Click += pbMinimize_Click_1;
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(770, 3);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(26, 26);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 0;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // panelCentral
            // 
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 32);
            panelCentral.Margin = new Padding(2);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(801, 493);
            panelCentral.TabIndex = 2;
            // 
            // Conteudo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 525);
            Controls.Add(panelCentral);
            Controls.Add(navBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Conteudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zaffy";
            Load += Conteudo_Load;
            navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navBar;
        private PictureBox pbClose;
        private Panel panelCentral;
        private PictureBox pbMinimize;
    }
}
