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
            components = new System.ComponentModel.Container();
            btnAddressInformation = new Button();
            btnOrders = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lstViewAdress = new ListView();
            cntAddressUpdate = new ContextMenuStrip(components);
            addNewAddressToolStripMenuItem = new ToolStripMenuItem();
            updateAddressToolStripMenuItem = new ToolStripMenuItem();
            deleteAddressToolStripMenuItem = new ToolStripMenuItem();
            lstViewOrders = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            cntOrderUpdate = new ContextMenuStrip(components);
            cancelOrderToolStripMenuItem = new ToolStripMenuItem();
            addNewOrderToolStripMenuItem = new ToolStripMenuItem();
            btnCommInfos = new Button();
            lstViewCommInfo = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            cntCommUpdate = new ContextMenuStrip(components);
            addNewContactStripMenuItem = new ToolStripMenuItem();
            updateContactToolStripMenuItem = new ToolStripMenuItem();
            deleteContactToolStripMenuItem = new ToolStripMenuItem();
            cntAddressUpdate.SuspendLayout();
            cntOrderUpdate.SuspendLayout();
            cntCommUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddressInformation
            // 
            btnAddressInformation.Location = new Point(116, 77);
            btnAddressInformation.Name = "btnAddressInformation";
            btnAddressInformation.Size = new Size(145, 93);
            btnAddressInformation.TabIndex = 0;
            btnAddressInformation.Text = "Adres Bilgileri";
            btnAddressInformation.UseVisualStyleBackColor = true;
            btnAddressInformation.Click += btnAddressInformation_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(591, 77);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(145, 93);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Sipariş Bilgileri";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Müşteri ID";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adres Detayı";
            columnHeader3.Width = 700;
            // 
            // lstViewAdress
            // 
            lstViewAdress.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstViewAdress.ContextMenuStrip = cntAddressUpdate;
            lstViewAdress.Dock = DockStyle.Bottom;
            lstViewAdress.FullRowSelect = true;
            lstViewAdress.GridLines = true;
            lstViewAdress.Location = new Point(0, 265);
            lstViewAdress.Name = "lstViewAdress";
            lstViewAdress.Size = new Size(848, 383);
            lstViewAdress.TabIndex = 7;
            lstViewAdress.UseCompatibleStateImageBehavior = false;
            lstViewAdress.View = View.Details;
            lstViewAdress.Visible = false;
            // 
            // cntAddressUpdate
            // 
            cntAddressUpdate.ImageScalingSize = new Size(20, 20);
            cntAddressUpdate.Items.AddRange(new ToolStripItem[] { addNewAddressToolStripMenuItem, updateAddressToolStripMenuItem, deleteAddressToolStripMenuItem });
            cntAddressUpdate.Name = "cntAddressUpdate";
            cntAddressUpdate.Size = new Size(137, 76);
            // 
            // addNewAddressToolStripMenuItem
            // 
            addNewAddressToolStripMenuItem.Name = "addNewAddressToolStripMenuItem";
            addNewAddressToolStripMenuItem.Size = new Size(136, 24);
            addNewAddressToolStripMenuItem.Text = "Yeni Ekle";
            addNewAddressToolStripMenuItem.Click += addNewAddressToolStripMenuItem_Click;
            // 
            // updateAddressToolStripMenuItem
            // 
            updateAddressToolStripMenuItem.Name = "updateAddressToolStripMenuItem";
            updateAddressToolStripMenuItem.Size = new Size(136, 24);
            updateAddressToolStripMenuItem.Text = "Güncelle";
            updateAddressToolStripMenuItem.Click += updateAddressToolStripMenuItem_Click;
            // 
            // deleteAddressToolStripMenuItem
            // 
            deleteAddressToolStripMenuItem.Name = "deleteAddressToolStripMenuItem";
            deleteAddressToolStripMenuItem.Size = new Size(136, 24);
            deleteAddressToolStripMenuItem.Text = "Sil";
            deleteAddressToolStripMenuItem.Click += deleteAddressToolStripMenuItem_Click;
            // 
            // lstViewOrders
            // 
            lstViewOrders.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstViewOrders.ContextMenuStrip = cntOrderUpdate;
            lstViewOrders.FullRowSelect = true;
            lstViewOrders.GridLines = true;
            lstViewOrders.Location = new Point(0, 265);
            lstViewOrders.Name = "lstViewOrders";
            lstViewOrders.Size = new Size(848, 383);
            lstViewOrders.TabIndex = 8;
            lstViewOrders.UseCompatibleStateImageBehavior = false;
            lstViewOrders.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fiyat";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Şipariş Durumu";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "OrderDetail";
            columnHeader7.Width = 500;
            // 
            // cntOrderUpdate
            // 
            cntOrderUpdate.ImageScalingSize = new Size(20, 20);
            cntOrderUpdate.Items.AddRange(new ToolStripItem[] { cancelOrderToolStripMenuItem, addNewOrderToolStripMenuItem });
            cntOrderUpdate.Name = "contextMenuStrip1";
            cntOrderUpdate.Size = new Size(178, 52);
            // 
            // cancelOrderToolStripMenuItem
            // 
            cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            cancelOrderToolStripMenuItem.Size = new Size(177, 24);
            cancelOrderToolStripMenuItem.Text = "Siparişi İptal Et";
            cancelOrderToolStripMenuItem.Click += cancelOrderToolStripMenuItem_Click;
            // 
            // addNewOrderToolStripMenuItem
            // 
            addNewOrderToolStripMenuItem.Name = "addNewOrderToolStripMenuItem";
            addNewOrderToolStripMenuItem.Size = new Size(177, 24);
            addNewOrderToolStripMenuItem.Text = "Sipariş Oluştur";
            addNewOrderToolStripMenuItem.Click += addNewOrderToolStripMenuItem_Click;
            // 
            // btnCommInfos
            // 
            btnCommInfos.Location = new Point(354, 77);
            btnCommInfos.Name = "btnCommInfos";
            btnCommInfos.Size = new Size(145, 93);
            btnCommInfos.TabIndex = 9;
            btnCommInfos.Text = "İletişim Bilgileri";
            btnCommInfos.UseVisualStyleBackColor = true;
            btnCommInfos.Click += btnCommInfos_Click;
            // 
            // lstViewCommInfo
            // 
            lstViewCommInfo.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            lstViewCommInfo.ContextMenuStrip = cntCommUpdate;
            lstViewCommInfo.FullRowSelect = true;
            lstViewCommInfo.GridLines = true;
            lstViewCommInfo.Location = new Point(0, 265);
            lstViewCommInfo.Name = "lstViewCommInfo";
            lstViewCommInfo.Size = new Size(848, 383);
            lstViewCommInfo.TabIndex = 10;
            lstViewCommInfo.UseCompatibleStateImageBehavior = false;
            lstViewCommInfo.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Müşteri ID";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "İletişim Tipi";
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "İletişim Detay";
            columnHeader11.Width = 350;
            // 
            // cntCommUpdate
            // 
            cntCommUpdate.ImageScalingSize = new Size(20, 20);
            cntCommUpdate.Items.AddRange(new ToolStripItem[] { addNewContactStripMenuItem, updateContactToolStripMenuItem, deleteContactToolStripMenuItem });
            cntCommUpdate.Name = "contextMenuStrip1";
            cntCommUpdate.Size = new Size(137, 76);
            // 
            // addNewContactStripMenuItem
            // 
            addNewContactStripMenuItem.Name = "addNewContactStripMenuItem";
            addNewContactStripMenuItem.Size = new Size(136, 24);
            addNewContactStripMenuItem.Text = "Yeni Ekle";
            addNewContactStripMenuItem.Click += addNewContactStripMenuItem_Click;
            // 
            // updateContactToolStripMenuItem
            // 
            updateContactToolStripMenuItem.Name = "updateContactToolStripMenuItem";
            updateContactToolStripMenuItem.Size = new Size(136, 24);
            updateContactToolStripMenuItem.Text = "Güncelle";
            updateContactToolStripMenuItem.Click += updateContactToolStripMenuItem_Click;
            // 
            // deleteContactToolStripMenuItem
            // 
            deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            deleteContactToolStripMenuItem.Size = new Size(136, 24);
            deleteContactToolStripMenuItem.Text = "Sil";
            deleteContactToolStripMenuItem.Click += deleteContactToolStripMenuItem_Click;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 648);
            Controls.Add(lstViewCommInfo);
            Controls.Add(btnCommInfos);
            Controls.Add(lstViewOrders);
            Controls.Add(lstViewAdress);
            Controls.Add(btnOrders);
            Controls.Add(btnAddressInformation);
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            cntAddressUpdate.ResumeLayout(false);
            cntOrderUpdate.ResumeLayout(false);
            cntCommUpdate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddressInformation;
        private Button btnOrders;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lstViewAdress;
        private ContextMenuStrip cntAddressUpdate;
        private ToolStripMenuItem updateAddressToolStripMenuItem;
        private ToolStripMenuItem deleteAddressToolStripMenuItem;
        private ListView lstViewOrders;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ContextMenuStrip cntOrderUpdate;
        private ToolStripMenuItem cancelOrderToolStripMenuItem;
        private ToolStripMenuItem addNewOrderToolStripMenuItem;
        private Button btnCommInfos;
        private ListView lstViewCommInfo;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ContextMenuStrip cntCommUpdate;
        private ToolStripMenuItem addNewContactStripMenuItem;
        private ToolStripMenuItem updateContactToolStripMenuItem;
        private ToolStripMenuItem deleteContactToolStripMenuItem;
        private ToolStripMenuItem addNewAddressToolStripMenuItem;
    }
}