
namespace Test2
{
    partial class Login_Form
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
            this.login_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_login_textBox = new System.Windows.Forms.TextBox();
            this.pw_login_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(346, 67);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(112, 38);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "LOGIN";
            // 
            // username_label
            // 
            this.username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(160, 162);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(111, 23);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "USERNAME";
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(163, 230);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(108, 23);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "PASSWORD";
            // 
            // username_login_textBox
            // 
            this.username_login_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_login_textBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_login_textBox.Location = new System.Drawing.Point(300, 159);
            this.username_login_textBox.Name = "username_login_textBox";
            this.username_login_textBox.Size = new System.Drawing.Size(262, 31);
            this.username_login_textBox.TabIndex = 3;
            // 
            // pw_login_textBox
            // 
            this.pw_login_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pw_login_textBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_login_textBox.Location = new System.Drawing.Point(300, 227);
            this.pw_login_textBox.Name = "pw_login_textBox";
            this.pw_login_textBox.Size = new System.Drawing.Size(262, 31);
            this.pw_login_textBox.TabIndex = 4;
            this.pw_login_textBox.UseSystemPasswordChar = true;
            this.pw_login_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_button.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(472, 293);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(90, 43);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pw_login_textBox);
            this.Controls.Add(this.username_login_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_label);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_login_textBox;
        private System.Windows.Forms.TextBox pw_login_textBox;
        private System.Windows.Forms.Button login_button;
    }
}