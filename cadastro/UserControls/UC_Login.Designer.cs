namespace cadastro.UserControls
{
    partial class UC_Login
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Login));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblEsqueciSenha = new Label();
            btnLogin = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pbEyeClosed = new PictureBox();
            pbEyeOpen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(572, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(115, 76, 191);
            panel1.Controls.Add(pbEyeClosed);
            panel1.Controls.Add(lblEsqueciSenha);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbEyeOpen);
            panel1.Location = new Point(568, -6);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 835);
            panel1.TabIndex = 10;
            // 
            // lblEsqueciSenha
            // 
            lblEsqueciSenha.AutoSize = true;
            lblEsqueciSenha.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline);
            lblEsqueciSenha.ForeColor = Color.White;
            lblEsqueciSenha.Location = new Point(111, 485);
            lblEsqueciSenha.Margin = new Padding(4, 0, 4, 0);
            lblEsqueciSenha.Name = "lblEsqueciSenha";
            lblEsqueciSenha.Size = new Size(154, 22);
            lblEsqueciSenha.TabIndex = 7;
            lblEsqueciSenha.Text = "Esqueci a senha";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(213, 620);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(153, 60);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Underline);
            label4.ForeColor = Color.White;
            label4.Location = new Point(231, 685);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 5;
            label4.Text = "Cadastra-se";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(112, 445);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 39);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(112, 406);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 34);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(112, 322);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 39);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(111, 283);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 34);
            label2.TabIndex = 1;
            label2.Text = "Usuário/Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(374, 44);
            label1.TabIndex = 0;
            label1.Text = "Seja bem-vindo(a)!";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 702);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(572, 124);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(73, 517);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(271, 21);
            label5.TabIndex = 12;
            label5.Text = "anúncios rápidos, negócios certos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Protótipo_de_Baixa_Fidelidade1;
            pictureBox1.Location = new Point(46, 217);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 340);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pbEyeClosed
            // 
            pbEyeClosed.Image = Properties.Resources.icons8_invisível_32;
            pbEyeClosed.Location = new Point(483, 440);
            pbEyeClosed.Margin = new Padding(4, 5, 4, 5);
            pbEyeClosed.Name = "pbEyeClosed";
            pbEyeClosed.Size = new Size(44, 46);
            pbEyeClosed.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeClosed.TabIndex = 15;
            pbEyeClosed.TabStop = false;
            pbEyeClosed.Click += pbEyeClosed_Click;
            // 
            // pbEyeOpen
            // 
            pbEyeOpen.Image = Properties.Resources.icons8_visível_32;
            pbEyeOpen.Location = new Point(483, 442);
            pbEyeOpen.Margin = new Padding(4, 5, 4, 5);
            pbEyeOpen.Name = "pbEyeOpen";
            pbEyeOpen.Size = new Size(44, 46);
            pbEyeOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeOpen.TabIndex = 16;
            pbEyeOpen.TabStop = false;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Name = "UC_Login";
            Size = new Size(1143, 822);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lblEsqueciSenha;
        private Button btnLogin;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pbEyeClosed;
        private PictureBox pbEyeOpen;
    }
}
