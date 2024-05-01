namespace FoodOrderUI
{
    partial class UserProfile
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
            btnAddressInformation = new Button();
            btnOrders = new Button();
            btnAddressAdd = new Button();
            btnAddressDelete = new Button();
            btnOrderAdd = new Button();
            btnOrderCancel = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lstViewAdress = new ListView();
            SuspendLayout();
            // 
            // btnAddressInformation
            // 
            btnAddressInformation.Location = new Point(200, 29);
            btnAddressInformation.Name = "btnAddressInformation";
            btnAddressInformation.Size = new Size(145, 93);
            btnAddressInformation.TabIndex = 0;
            btnAddressInformation.Text = "Adres Bilgileri";
            btnAddressInformation.UseVisualStyleBackColor = true;
            btnAddressInformation.Click += btnAddressInformation_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(478, 29);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(145, 93);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Sipariş Bilgileri";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnAddressAdd
            // 
            btnAddressAdd.Location = new Point(126, 138);
            btnAddressAdd.Name = "btnAddressAdd";
            btnAddressAdd.Size = new Size(116, 62);
            btnAddressAdd.TabIndex = 3;
            btnAddressAdd.Text = "Adres Ekle";
            btnAddressAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddressDelete
            // 
            btnAddressDelete.Location = new Point(288, 138);
            btnAddressDelete.Name = "btnAddressDelete";
            btnAddressDelete.Size = new Size(116, 62);
            btnAddressDelete.TabIndex = 4;
            btnAddressDelete.Text = "Adres Sil";
            btnAddressDelete.UseVisualStyleBackColor = true;
            // 
            // btnOrderAdd
            // 
            btnOrderAdd.Location = new Point(522, 154);
            btnOrderAdd.Name = "btnOrderAdd";
            btnOrderAdd.Size = new Size(135, 46);
            btnOrderAdd.TabIndex = 5;
            btnOrderAdd.Text = "Sipariş Oluştur";
            btnOrderAdd.UseVisualStyleBackColor = true;
            // 
            // btnOrderCancel
            // 
            btnOrderCancel.Location = new Point(696, 152);
            btnOrderCancel.Name = "btnOrderCancel";
            btnOrderCancel.Size = new Size(105, 48);
            btnOrderCancel.TabIndex = 6;
            btnOrderCancel.Text = "Siparişi İptal Et";
            btnOrderCancel.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Müşteri ID";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adres Detayı";
            // 
            // lstViewAdress
            // 
            lstViewAdress.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstViewAdress.Dock = DockStyle.Bottom;
            lstViewAdress.FullRowSelect = true;
            lstViewAdress.GridLines = true;
            lstViewAdress.Location = new Point(0, 272);
            lstViewAdress.Name = "lstViewAdress";
            lstViewAdress.Size = new Size(848, 376);
            lstViewAdress.TabIndex = 7;
            lstViewAdress.UseCompatibleStateImageBehavior = false;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 648);
            Controls.Add(lstViewAdress);
            Controls.Add(btnOrderCancel);
            Controls.Add(btnOrderAdd);
            Controls.Add(btnAddressDelete);
            Controls.Add(btnAddressAdd);
            Controls.Add(btnOrders);
            Controls.Add(btnAddressInformation);
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddressInformation;
        private Button btnOrders;
        private Button btnAddressAdd;
        private Button btnAddressDelete;
        private Button btnOrderAdd;
        private Button btnOrderCancel;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lstViewAdress;
    }
}