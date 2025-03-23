namespace SyncDesk.SyncDesk.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBoxemail = new TextBox();
            label2 = new Label();
            textBoxSenha = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 171);
            label1.Name = "label1";
            label1.Size = new Size(39, 14);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(81, 188);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(155, 21);
            textBoxemail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 233);
            label2.Name = "label2";
            label2.Size = new Size(43, 14);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(81, 250);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(155, 21);
            textBoxSenha.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(111, 303);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 366);
            Controls.Add(btnLogin);
            Controls.Add(textBoxSenha);
            Controls.Add(label2);
            Controls.Add(textBoxemail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "SyncDesk - Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxemail;
        private Label label2;
        private TextBox textBoxSenha;
        private Button btnLogin;
    }
}