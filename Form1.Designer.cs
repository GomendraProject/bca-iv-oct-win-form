namespace bca_iv_oct
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
            usernameElm = new TextBox();
            passwordElm = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // usernameElm
            // 
            usernameElm.Location = new Point(22, 49);
            usernameElm.Name = "usernameElm";
            usernameElm.Size = new Size(748, 27);
            usernameElm.TabIndex = 0;
            // 
            // passwordElm
            // 
            passwordElm.Location = new Point(22, 134);
            passwordElm.Name = "passwordElm";
            passwordElm.Size = new Size(748, 27);
            passwordElm.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(22, 232);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(748, 29);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login to continue!";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(passwordElm);
            Controls.Add(usernameElm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameElm;
        private TextBox passwordElm;
        private Button loginBtn;
    }
}