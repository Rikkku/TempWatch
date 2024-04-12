namespace TempCheck
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
            this.BackPanel = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegPass2Box = new System.Windows.Forms.TextBox();
            this.RegPassBox = new System.Windows.Forms.TextBox();
            this.RegUserBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordBox = new System.Windows.Forms.TextBox();
            this.LoginUserBox = new System.Windows.Forms.TextBox();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ConnectCheck = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(123)))), ((int)(((byte)(147)))));
            this.BackPanel.Controls.Add(this.LogoutButton);
            this.BackPanel.Controls.Add(this.RegisterButton);
            this.BackPanel.Controls.Add(this.LoginButton);
            this.BackPanel.Controls.Add(this.RegPass2Box);
            this.BackPanel.Controls.Add(this.RegPassBox);
            this.BackPanel.Controls.Add(this.RegUserBox);
            this.BackPanel.Controls.Add(this.LoginPasswordBox);
            this.BackPanel.Controls.Add(this.LoginUserBox);
            this.BackPanel.Controls.Add(this.RegisterLabel);
            this.BackPanel.Controls.Add(this.LoginLabel);
            this.BackPanel.Controls.Add(this.ConnectCheck);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(800, 450);
            this.BackPanel.TabIndex = 0;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(175, 192);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Visible = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(175, 163);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegPass2Box
            // 
            this.RegPass2Box.Location = new System.Drawing.Point(150, 112);
            this.RegPass2Box.Name = "RegPass2Box";
            this.RegPass2Box.Size = new System.Drawing.Size(100, 20);
            this.RegPass2Box.TabIndex = 7;
            this.RegPass2Box.Visible = false;
            // 
            // RegPassBox
            // 
            this.RegPassBox.Location = new System.Drawing.Point(150, 86);
            this.RegPassBox.Name = "RegPassBox";
            this.RegPassBox.Size = new System.Drawing.Size(100, 20);
            this.RegPassBox.TabIndex = 6;
            this.RegPassBox.Visible = false;
            // 
            // RegUserBox
            // 
            this.RegUserBox.Location = new System.Drawing.Point(150, 60);
            this.RegUserBox.Name = "RegUserBox";
            this.RegUserBox.Size = new System.Drawing.Size(100, 20);
            this.RegUserBox.TabIndex = 5;
            this.RegUserBox.Visible = false;
            // 
            // LoginPasswordBox
            // 
            this.LoginPasswordBox.Location = new System.Drawing.Point(44, 86);
            this.LoginPasswordBox.Name = "LoginPasswordBox";
            this.LoginPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.LoginPasswordBox.TabIndex = 4;
            // 
            // LoginUserBox
            // 
            this.LoginUserBox.Location = new System.Drawing.Point(44, 60);
            this.LoginUserBox.Name = "LoginUserBox";
            this.LoginUserBox.Size = new System.Drawing.Size(100, 20);
            this.LoginUserBox.TabIndex = 3;
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Source Code Pro", 15.75F);
            this.RegisterLabel.Location = new System.Drawing.Point(145, 9);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(116, 27);
            this.RegisterLabel.TabIndex = 2;
            this.RegisterLabel.Text = "Register";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Source Code Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(39, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(77, 27);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // ConnectCheck
            // 
            this.ConnectCheck.AutoSize = true;
            this.ConnectCheck.Location = new System.Drawing.Point(727, 9);
            this.ConnectCheck.Name = "ConnectCheck";
            this.ConnectCheck.Size = new System.Drawing.Size(61, 13);
            this.ConnectCheck.TabIndex = 0;
            this.ConnectCheck.Text = "unchanged";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(175, 221);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label ConnectCheck;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.TextBox LoginUserBox;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.TextBox RegPass2Box;
        private System.Windows.Forms.TextBox RegPassBox;
        private System.Windows.Forms.TextBox RegUserBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}

