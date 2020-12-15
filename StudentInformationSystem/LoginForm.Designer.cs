
namespace StudentInformationSystem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.labelusernamevalidate = new System.Windows.Forms.Label();
            this.labelpasswordvalidate = new System.Windows.Forms.Label();
            this.labelloginsuccess = new System.Windows.Forms.Label();
            this.labelloginfailed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(179, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(140, 144);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(183, 20);
            this.textboxusername.TabIndex = 1;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(137, 127);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(56, 14);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Location = new System.Drawing.Point(137, 189);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(57, 14);
            this.labelpassword.TabIndex = 4;
            this.labelpassword.Text = "Password";
            // 
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(140, 206);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(183, 20);
            this.textboxpassword.TabIndex = 3;
            this.textboxpassword.UseSystemPasswordChar = true;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(140, 245);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(183, 25);
            this.buttonlogin.TabIndex = 5;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // labelusernamevalidate
            // 
            this.labelusernamevalidate.AutoSize = true;
            this.labelusernamevalidate.Font = new System.Drawing.Font("Arial", 6.59F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusernamevalidate.ForeColor = System.Drawing.Color.Red;
            this.labelusernamevalidate.Location = new System.Drawing.Point(139, 168);
            this.labelusernamevalidate.Name = "labelusernamevalidate";
            this.labelusernamevalidate.Size = new System.Drawing.Size(106, 11);
            this.labelusernamevalidate.TabIndex = 6;
            this.labelusernamevalidate.Text = "Username is required!";
            this.labelusernamevalidate.Visible = false;
            // 
            // labelpasswordvalidate
            // 
            this.labelpasswordvalidate.AutoSize = true;
            this.labelpasswordvalidate.Font = new System.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpasswordvalidate.ForeColor = System.Drawing.Color.Red;
            this.labelpasswordvalidate.Location = new System.Drawing.Point(139, 229);
            this.labelpasswordvalidate.Name = "labelpasswordvalidate";
            this.labelpasswordvalidate.Size = new System.Drawing.Size(105, 11);
            this.labelpasswordvalidate.TabIndex = 7;
            this.labelpasswordvalidate.Text = "Password is required!";
            this.labelpasswordvalidate.Visible = false;
            // 
            // labelloginsuccess
            // 
            this.labelloginsuccess.AutoSize = true;
            this.labelloginsuccess.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloginsuccess.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelloginsuccess.Location = new System.Drawing.Point(185, 287);
            this.labelloginsuccess.Name = "labelloginsuccess";
            this.labelloginsuccess.Size = new System.Drawing.Size(98, 12);
            this.labelloginsuccess.TabIndex = 8;
            this.labelloginsuccess.Text = "Successfully login.";
            this.labelloginsuccess.Visible = false;
            // 
            // labelloginfailed
            // 
            this.labelloginfailed.AutoSize = true;
            this.labelloginfailed.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloginfailed.ForeColor = System.Drawing.Color.Red;
            this.labelloginfailed.Location = new System.Drawing.Point(200, 287);
            this.labelloginfailed.Name = "labelloginfailed";
            this.labelloginfailed.Size = new System.Drawing.Size(65, 12);
            this.labelloginfailed.TabIndex = 9;
            this.labelloginfailed.Text = "Login failed!\r\n";
            this.labelloginfailed.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(157, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "Programmed by: Kim Dave Torres";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelloginfailed);
            this.Controls.Add(this.labelloginsuccess);
            this.Controls.Add(this.labelpasswordvalidate);
            this.Controls.Add(this.labelusernamevalidate);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textboxpassword;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Label labelusernamevalidate;
        private System.Windows.Forms.Label labelpasswordvalidate;
        private System.Windows.Forms.Label labelloginsuccess;
        private System.Windows.Forms.Label labelloginfailed;
        private System.Windows.Forms.Label label3;
    }
}