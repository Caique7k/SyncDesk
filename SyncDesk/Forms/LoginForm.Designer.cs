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
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Cursor = Cursors.IBeam;
            label1.Name = "label1";
            // 
            // textBoxemail
            // 
            textBoxemail.Cursor = Cursors.IBeam;
            resources.ApplyResources(textBoxemail, "textBoxemail");
            textBoxemail.Name = "textBoxemail";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Cursor = Cursors.IBeam;
            label2.Name = "label2";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Cursor = Cursors.IBeam;
            resources.ApplyResources(textBoxSenha, "textBoxSenha");
            textBoxSenha.Name = "textBoxSenha";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLogin);
            Controls.Add(textBoxSenha);
            Controls.Add(label2);
            Controls.Add(textBoxemail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
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