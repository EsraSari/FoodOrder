namespace FoodOrderUI
{
    partial class AddressAdd
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
            gbAddressInfos = new GroupBox();
            btnAddressAdd = new Button();
            lblAddressDetails = new Label();
            cbCounties = new ComboBox();
            txtAddressDetails = new TextBox();
            İlçe = new Label();
            cbCities = new ComboBox();
            lblCities = new Label();
            lblCountry = new Label();
            cbCountries = new ComboBox();
            gbAddressInfos.SuspendLayout();
            SuspendLayout();
            // 
            // gbAddressInfos
            // 
            gbAddressInfos.Controls.Add(btnAddressAdd);
            gbAddressInfos.Controls.Add(lblAddressDetails);
            gbAddressInfos.Controls.Add(cbCounties);
            gbAddressInfos.Controls.Add(txtAddressDetails);
            gbAddressInfos.Controls.Add(İlçe);
            gbAddressInfos.Controls.Add(cbCities);
            gbAddressInfos.Controls.Add(lblCities);
            gbAddressInfos.Controls.Add(lblCountry);
            gbAddressInfos.Controls.Add(cbCountries);
            gbAddressInfos.Location = new Point(59, 17);
            gbAddressInfos.Name = "gbAddressInfos";
            gbAddressInfos.Size = new Size(648, 518);
            gbAddressInfos.TabIndex = 0;
            gbAddressInfos.TabStop = false;
            gbAddressInfos.Text = "Adres Bilgileri";
            // 
            // btnAddressAdd
            // 
            btnAddressAdd.Location = new Point(261, 440);
            btnAddressAdd.Name = "btnAddressAdd";
            btnAddressAdd.Size = new Size(104, 50);
            btnAddressAdd.TabIndex = 30;
            btnAddressAdd.Text = "Kaydet";
            btnAddressAdd.UseVisualStyleBackColor = true;
            btnAddressAdd.Click += btnAddressAdd_Click;
            // 
            // lblAddressDetails
            // 
            lblAddressDetails.AutoSize = true;
            lblAddressDetails.Location = new Point(161, 229);
            lblAddressDetails.Name = "lblAddressDetails";
            lblAddressDetails.Size = new Size(173, 20);
            lblAddressDetails.TabIndex = 29;
            lblAddressDetails.Text = "Adres bilgilerinizi giriniz:";
            // 
            // cbCounties
            // 
            cbCounties.FormattingEnabled = true;
            cbCounties.Location = new Point(292, 177);
            cbCounties.Name = "cbCounties";
            cbCounties.Size = new Size(151, 28);
            cbCounties.TabIndex = 28;
            // 
            // txtAddressDetails
            // 
            txtAddressDetails.Location = new Point(161, 261);
            txtAddressDetails.Multiline = true;
            txtAddressDetails.Name = "txtAddressDetails";
            txtAddressDetails.Size = new Size(328, 170);
            txtAddressDetails.TabIndex = 27;
            // 
            // İlçe
            // 
            İlçe.AutoSize = true;
            İlçe.Location = new Point(159, 185);
            İlçe.Name = "İlçe";
            İlçe.Size = new Size(32, 20);
            İlçe.TabIndex = 26;
            İlçe.Text = "İlçe";
            // 
            // cbCities
            // 
            cbCities.FormattingEnabled = true;
            cbCities.Location = new Point(292, 120);
            cbCities.Name = "cbCities";
            cbCities.Size = new Size(151, 28);
            cbCities.TabIndex = 25;
            cbCities.SelectedIndexChanged += cbCities_SelectedIndexChanged;
            // 
            // lblCities
            // 
            lblCities.AutoSize = true;
            lblCities.Location = new Point(161, 128);
            lblCities.Name = "lblCities";
            lblCities.Size = new Size(42, 20);
            lblCities.TabIndex = 24;
            lblCities.Text = "Şehir";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(159, 66);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(38, 20);
            lblCountry.TabIndex = 23;
            lblCountry.Text = "Ülke";
            // 
            // cbCountries
            // 
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(292, 68);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(151, 28);
            cbCountries.TabIndex = 22;
            cbCountries.SelectedIndexChanged += cbCountries_SelectedIndexChanged;
            // 
            // CommunicationAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(gbAddressInfos);
            Name = "CommunicationAdd";
            Text = "CommunicationAdd";
            Load += CommunicationAdd_Load;
            gbAddressInfos.ResumeLayout(false);
            gbAddressInfos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddressInfos;
        private Label lblAddressDetails;
        private ComboBox cbCounties;
        private TextBox txtAddressDetails;
        private Label İlçe;
        private ComboBox cbCities;
        private Label lblCities;
        private Label lblCountry;
        private ComboBox cbCountries;
        private Button btnAddressAdd;
    }
}