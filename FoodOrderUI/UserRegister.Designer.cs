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
            cbCountries = new ComboBox();
            lblCountry = new Label();
            lblCities = new Label();
            cbCities = new ComboBox();
            grpUserInfo = new GroupBox();
            lblAddressDetails = new Label();
            cbCounties = new ComboBox();
            txtAddressDetails = new TextBox();
            İlçe = new Label();
            btnRegister = new Button();
            grpUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(93, 74);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(28, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Ad";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(95, 128);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(50, 20);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Soyad";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(93, 180);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 2;
            lblGender.Text = "Cinsiyet";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(93, 234);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(98, 20);
            lblBirthDate.TabIndex = 3;
            lblBirthDate.Text = "Doğum Tarihi";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(93, 280);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 20);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Kullanıcı Adı";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(93, 326);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Şifre";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(226, 74);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(226, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(226, 273);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(226, 326);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 9;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Kadın", "Erkek" });
            cbGender.Location = new Point(226, 180);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 28);
            cbGender.TabIndex = 10;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(226, 229);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(250, 27);
            dtBirthDate.TabIndex = 11;
            // 
            // cbCountries
            // 
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(226, 387);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(151, 28);
            cbCountries.TabIndex = 14;
            cbCountries.SelectedIndexChanged += cbCountries_SelectedIndexChanged;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(93, 385);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(38, 20);
            lblCountry.TabIndex = 15;
            lblCountry.Text = "Ülke";
            // 
            // lblCities
            // 
            lblCities.AutoSize = true;
            lblCities.Location = new Point(95, 447);
            lblCities.Name = "lblCities";
            lblCities.Size = new Size(42, 20);
            lblCities.TabIndex = 16;
            lblCities.Text = "Şehir";
            // 
            // cbCities
            // 
            cbCities.FormattingEnabled = true;
            cbCities.Location = new Point(226, 439);
            cbCities.Name = "cbCities";
            cbCities.Size = new Size(151, 28);
            cbCities.TabIndex = 17;
            cbCities.SelectedIndexChanged += cbCities_SelectedIndexChanged;
            // 
            // grpUserInfo
            // 
            grpUserInfo.Controls.Add(lblAddressDetails);
            grpUserInfo.Controls.Add(cbCounties);
            grpUserInfo.Controls.Add(txtAddressDetails);
            grpUserInfo.Controls.Add(İlçe);
            grpUserInfo.Controls.Add(dtBirthDate);
            grpUserInfo.Controls.Add(cbCities);
            grpUserInfo.Controls.Add(lblFirstName);
            grpUserInfo.Controls.Add(lblCities);
            grpUserInfo.Controls.Add(lblLastName);
            grpUserInfo.Controls.Add(lblCountry);
            grpUserInfo.Controls.Add(lblGender);
            grpUserInfo.Controls.Add(cbCountries);
            grpUserInfo.Controls.Add(lblBirthDate);
            grpUserInfo.Controls.Add(lblUserName);
            grpUserInfo.Controls.Add(lblPassword);
            grpUserInfo.Controls.Add(cbGender);
            grpUserInfo.Controls.Add(txtFirstName);
            grpUserInfo.Controls.Add(txtPassword);
            grpUserInfo.Controls.Add(txtLastName);
            grpUserInfo.Controls.Add(txtUserName);
            grpUserInfo.Location = new Point(35, 12);
            grpUserInfo.Name = "grpUserInfo";
            grpUserInfo.Size = new Size(553, 844);
            grpUserInfo.TabIndex = 18;
            grpUserInfo.TabStop = false;
            grpUserInfo.Text = "Kullanıcı Bilgileri";
            // 
            // lblAddressDetails
            // 
            lblAddressDetails.AutoSize = true;
            lblAddressDetails.Location = new Point(95, 597);
            lblAddressDetails.Name = "lblAddressDetails";
            lblAddressDetails.Size = new Size(173, 20);
            lblAddressDetails.TabIndex = 21;
            lblAddressDetails.Text = "Adres bilgilerinizi giriniz:";
            // 
            // cbCounties
            // 
            cbCounties.FormattingEnabled = true;
            cbCounties.Location = new Point(226, 496);
            cbCounties.Name = "cbCounties";
            cbCounties.Size = new Size(151, 28);
            cbCounties.TabIndex = 20;
            // 
            // txtAddressDetails
            // 
            txtAddressDetails.Location = new Point(95, 629);
            txtAddressDetails.Multiline = true;
            txtAddressDetails.Name = "txtAddressDetails";
            txtAddressDetails.Size = new Size(328, 170);
            txtAddressDetails.TabIndex = 19;
            // 
            // İlçe
            // 
            İlçe.AutoSize = true;
            İlçe.Location = new Point(93, 504);
            İlçe.Name = "İlçe";
            İlçe.Size = new Size(32, 20);
            İlçe.TabIndex = 18;
            İlçe.Text = "İlçe";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(266, 894);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 58);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 982);
            Controls.Add(btnRegister);
            Controls.Add(grpUserInfo);
            Name = "UserRegister";
            Text = "UserRegister";
            Load += UserRegister_Load;
            grpUserInfo.ResumeLayout(false);
            grpUserInfo.PerformLayout();
            ResumeLayout(false);
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
        private ComboBox cbCountries;
        private Label lblCountry;
        private Label lblCities;
        private ComboBox cbCities;
        private GroupBox grpUserInfo;
        private Label lblAddressDetails;
        private ComboBox cbCounties;
        private TextBox txtAddressDetails;
        private Label İlçe;
        private Button btnRegister;
    }
}