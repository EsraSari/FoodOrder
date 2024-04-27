namespace FoodOrderUI
{
    partial class UserRegister
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblGender = new Label();
            lblBirthDate = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            cbGender = new ComboBox();
            dtBirthDate = new DateTimePicker();
            btnRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(53, 21);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(28, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Ad";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(53, 72);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(50, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Soyad";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(53, 130);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Cinsiyet";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(53, 181);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(98, 20);
            lblBirthDate.TabIndex = 3;
            lblBirthDate.Text = "Doğum Tarihi";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(55, 223);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 20);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Kullanıcı Adı";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(53, 273);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Şifre";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(186, 21);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(186, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(186, 220);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 273);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 9;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cbGender.Location = new Point(186, 127);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 28);
            cbGender.TabIndex = 10;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(186, 176);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(250, 27);
            dtBirthDate.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(127, 339);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 66);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 304);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 13;
            label1.Text = "adres bilgilerini eklee";
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 450);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(dtBirthDate);
            Controls.Add(cbGender);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblBirthDate);
            Controls.Add(lblGender);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "UserRegister";
            Text = "UserRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblGender;
        private Label lblBirthDate;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private ComboBox cbGender;
        private DateTimePicker dtBirthDate;
        private Button btnRegister;
        private Label label1;
    }
}