namespace FoodOrderUI
{
    partial class FoodOrderMenu
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
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            siparisYonetimiToolStripMenuItem1 = new ToolStripMenuItem();
            urunYonetimiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menüYönetimiToolStripMenuItem = new ToolStripMenuItem();
            pbProductPic = new PictureBox();
            cbProducts = new ComboBox();
            cbKetchup = new CheckBox();
            cbMayonnaise = new CheckBox();
            lblOrderDetails = new Label();
            nuAmount = new NumericUpDown();
            lblAmount = new Label();
            lblTotal = new Label();
            lblTotalPrice = new Label();
            btnOrderConfirm = new Button();
            gpProductAdd = new GroupBox();
            lblPrepTime = new Label();
            nuPrepTime = new NumericUpDown();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            btnProductAdd = new Button();
            txtProductName = new TextBox();
            nuPrice = new NumericUpDown();
            lblPrice = new Label();
            lblProductName = new Label();
            gpMenuAdd = new GroupBox();
            lblMenuPrice = new Label();
            nuMenuPrice = new NumericUpDown();
            lbSelectedItemIds = new ListBox();
            btnMenuProduct = new Button();
            btnMenuAdd = new Button();
            lblProductList = new Label();
            cbProductList = new ComboBox();
            cxbIsAllergen = new CheckBox();
            lblPrepTimeMenu = new Label();
            nuPrepTimeMenu = new NumericUpDown();
            txtMenuName = new TextBox();
            lblMenuName = new Label();
            lblProduct = new Label();
            lbProduct = new ListBox();
            gpOrder = new GroupBox();
            lbOrderID = new ListBox();
            lbOrders = new ListBox();
            btnOrderAdd = new Button();
            cbMenus = new ComboBox();
            lblMenus = new Label();
            lblProducts = new Label();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuAmount).BeginInit();
            gpProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrepTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            gpMenuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuMenuPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuPrepTimeMenu).BeginInit();
            gpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(184, 24);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { siparişYönetimiToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 28);
            // 
            // siparisYonetimiToolStripMenuItem1
            // 
            siparisYonetimiToolStripMenuItem1.Name = "siparisYonetimiToolStripMenuItem1";
            siparisYonetimiToolStripMenuItem1.Size = new Size(129, 24);
            siparisYonetimiToolStripMenuItem1.Text = "Sipariş Yönetimi";
            siparisYonetimiToolStripMenuItem1.Click += siparisYonetimiToolStripMenuItem1_Click;
            // 
            // urunYonetimiToolStripMenuItem
            // 
            urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            urunYonetimiToolStripMenuItem.Size = new Size(116, 24);
            urunYonetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            urunYonetimiToolStripMenuItem.Click += urunYonetimiToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparisYonetimiToolStripMenuItem1, urunYonetimiToolStripMenuItem, menüYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1068, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menüYönetimiToolStripMenuItem
            // 
            menüYönetimiToolStripMenuItem.Name = "menüYönetimiToolStripMenuItem";
            menüYönetimiToolStripMenuItem.Size = new Size(122, 24);
            menüYönetimiToolStripMenuItem.Text = "Menü Yönetimi";
            menüYönetimiToolStripMenuItem.Click += menüYönetimiToolStripMenuItem_Click;
            // 
            // pbProductPic
            // 
            pbProductPic.Location = new Point(15, 26);
            pbProductPic.Name = "pbProductPic";
            pbProductPic.Size = new Size(155, 91);
            pbProductPic.TabIndex = 2;
            pbProductPic.TabStop = false;
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(81, 137);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(151, 28);
            cbProducts.TabIndex = 3;
            // 
            // cbKetchup
            // 
            cbKetchup.AutoSize = true;
            cbKetchup.Location = new Point(15, 294);
            cbKetchup.Name = "cbKetchup";
            cbKetchup.Size = new Size(77, 24);
            cbKetchup.TabIndex = 4;
            cbKetchup.Text = "Ketçap";
            cbKetchup.UseVisualStyleBackColor = true;
            // 
            // cbMayonnaise
            // 
            cbMayonnaise.AutoSize = true;
            cbMayonnaise.Location = new Point(15, 338);
            cbMayonnaise.Name = "cbMayonnaise";
            cbMayonnaise.Size = new Size(91, 24);
            cbMayonnaise.TabIndex = 5;
            cbMayonnaise.Text = "Mayonez";
            cbMayonnaise.UseVisualStyleBackColor = true;
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Location = new Point(218, 11);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(50, 20);
            lblOrderDetails.TabIndex = 7;
            lblOrderDetails.Text = "Sepet:";
            // 
            // nuAmount
            // 
            nuAmount.Location = new Point(79, 378);
            nuAmount.Name = "nuAmount";
            nuAmount.Size = new Size(150, 27);
            nuAmount.TabIndex = 8;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(13, 378);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(41, 20);
            lblAmount.TabIndex = 9;
            lblAmount.Text = "Adet";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(311, 418);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 20);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Toplam";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(399, 418);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(14, 20);
            lblTotalPrice.TabIndex = 11;
            lblTotalPrice.Text = "t";
            // 
            // btnOrderConfirm
            // 
            btnOrderConfirm.Location = new Point(497, 395);
            btnOrderConfirm.Name = "btnOrderConfirm";
            btnOrderConfirm.Size = new Size(131, 66);
            btnOrderConfirm.TabIndex = 12;
            btnOrderConfirm.Text = "Siparişi Onayla";
            btnOrderConfirm.UseVisualStyleBackColor = true;
            // 
            // gpProductAdd
            // 
            gpProductAdd.Controls.Add(lblPrepTime);
            gpProductAdd.Controls.Add(nuPrepTime);
            gpProductAdd.Controls.Add(lblCategory);
            gpProductAdd.Controls.Add(cbCategory);
            gpProductAdd.Controls.Add(btnProductAdd);
            gpProductAdd.Controls.Add(txtProductName);
            gpProductAdd.Controls.Add(nuPrice);
            gpProductAdd.Controls.Add(lblPrice);
            gpProductAdd.Controls.Add(lblProductName);
            gpProductAdd.Location = new Point(34, 36);
            gpProductAdd.Name = "gpProductAdd";
            gpProductAdd.Size = new Size(595, 292);
            gpProductAdd.TabIndex = 13;
            gpProductAdd.TabStop = false;
            gpProductAdd.Text = "Ürün Ekle";
            // 
            // lblPrepTime
            // 
            lblPrepTime.AutoSize = true;
            lblPrepTime.Location = new Point(308, 87);
            lblPrepTime.Name = "lblPrepTime";
            lblPrepTime.Size = new Size(158, 20);
            lblPrepTime.TabIndex = 20;
            lblPrepTime.Text = "Hazırlanma Süresi (dk)";
            // 
            // nuPrepTime
            // 
            nuPrepTime.Location = new Point(316, 120);
            nuPrepTime.Name = "nuPrepTime";
            nuPrepTime.Size = new Size(150, 27);
            nuPrepTime.TabIndex = 19;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(300, 41);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(66, 20);
            lblCategory.TabIndex = 18;
            lblCategory.Text = "Kategori";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(403, 37);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 28);
            cbCategory.TabIndex = 14;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(225, 190);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(141, 70);
            btnProductAdd.TabIndex = 17;
            btnProductAdd.Text = "Ürün Ekle";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(97, 34);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 16;
            // 
            // nuPrice
            // 
            nuPrice.Location = new Point(97, 80);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(150, 27);
            nuPrice.TabIndex = 14;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(26, 82);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(40, 20);
            lblPrice.TabIndex = 15;
            lblPrice.Text = "Fiyat";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(26, 37);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(28, 20);
            lblProductName.TabIndex = 14;
            lblProductName.Text = "Ad";
            // 
            // gpMenuAdd
            // 
            gpMenuAdd.Controls.Add(lblMenuPrice);
            gpMenuAdd.Controls.Add(nuMenuPrice);
            gpMenuAdd.Controls.Add(lbSelectedItemIds);
            gpMenuAdd.Controls.Add(btnMenuProduct);
            gpMenuAdd.Controls.Add(btnMenuAdd);
            gpMenuAdd.Controls.Add(lblProductList);
            gpMenuAdd.Controls.Add(cbProductList);
            gpMenuAdd.Controls.Add(cxbIsAllergen);
            gpMenuAdd.Controls.Add(lblPrepTimeMenu);
            gpMenuAdd.Controls.Add(nuPrepTimeMenu);
            gpMenuAdd.Controls.Add(txtMenuName);
            gpMenuAdd.Controls.Add(lblMenuName);
            gpMenuAdd.Controls.Add(lblProduct);
            gpMenuAdd.Controls.Add(lbProduct);
            gpMenuAdd.Location = new Point(252, 619);
            gpMenuAdd.Name = "gpMenuAdd";
            gpMenuAdd.Size = new Size(645, 404);
            gpMenuAdd.TabIndex = 16;
            gpMenuAdd.TabStop = false;
            gpMenuAdd.Text = "Menü Ekle";
            // 
            // lblMenuPrice
            // 
            lblMenuPrice.AutoSize = true;
            lblMenuPrice.Location = new Point(19, 115);
            lblMenuPrice.Name = "lblMenuPrice";
            lblMenuPrice.Size = new Size(40, 20);
            lblMenuPrice.TabIndex = 30;
            lblMenuPrice.Text = "Fiyat";
            // 
            // nuMenuPrice
            // 
            nuMenuPrice.Location = new Point(155, 119);
            nuMenuPrice.Name = "nuMenuPrice";
            nuMenuPrice.Size = new Size(150, 27);
            nuMenuPrice.TabIndex = 29;
            // 
            // lbSelectedItemIds
            // 
            lbSelectedItemIds.FormattingEnabled = true;
            lbSelectedItemIds.Location = new Point(448, 289);
            lbSelectedItemIds.Name = "lbSelectedItemIds";
            lbSelectedItemIds.Size = new Size(150, 104);
            lbSelectedItemIds.TabIndex = 28;
            lbSelectedItemIds.Visible = false;
            // 
            // btnMenuProduct
            // 
            btnMenuProduct.Location = new Point(18, 266);
            btnMenuProduct.Name = "btnMenuProduct";
            btnMenuProduct.Size = new Size(290, 29);
            btnMenuProduct.TabIndex = 27;
            btnMenuProduct.Text = "Menüye Ekle";
            btnMenuProduct.UseVisualStyleBackColor = true;
            btnMenuProduct.Click += btnMenuProduct_Click;
            // 
            // btnMenuAdd
            // 
            btnMenuAdd.Location = new Point(256, 317);
            btnMenuAdd.Name = "btnMenuAdd";
            btnMenuAdd.Size = new Size(146, 73);
            btnMenuAdd.TabIndex = 26;
            btnMenuAdd.Text = "Menü Oluştur";
            btnMenuAdd.UseVisualStyleBackColor = true;
            btnMenuAdd.Click += btnMenuAdd_Click;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Location = new Point(18, 213);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(126, 20);
            lblProductList.TabIndex = 25;
            lblProductList.Text = "Eklenecek Ürünler";
            // 
            // cbProductList
            // 
            cbProductList.FormattingEnabled = true;
            cbProductList.Location = new Point(155, 210);
            cbProductList.Name = "cbProductList";
            cbProductList.Size = new Size(151, 28);
            cbProductList.TabIndex = 24;
            // 
            // cxbIsAllergen
            // 
            cxbIsAllergen.AutoSize = true;
            cxbIsAllergen.Location = new Point(28, 161);
            cxbIsAllergen.Name = "cxbIsAllergen";
            cxbIsAllergen.Size = new Size(169, 24);
            cxbIsAllergen.TabIndex = 23;
            cxbIsAllergen.Text = "Alerjen içerik var mı?";
            cxbIsAllergen.UseVisualStyleBackColor = true;
            // 
            // lblPrepTimeMenu
            // 
            lblPrepTimeMenu.AutoSize = true;
            lblPrepTimeMenu.Location = new Point(18, 80);
            lblPrepTimeMenu.Name = "lblPrepTimeMenu";
            lblPrepTimeMenu.Size = new Size(131, 20);
            lblPrepTimeMenu.TabIndex = 22;
            lblPrepTimeMenu.Text = "Hazırlanma Süresi:";
            // 
            // nuPrepTimeMenu
            // 
            nuPrepTimeMenu.Location = new Point(155, 75);
            nuPrepTimeMenu.Name = "nuPrepTimeMenu";
            nuPrepTimeMenu.Size = new Size(150, 27);
            nuPrepTimeMenu.TabIndex = 21;
            // 
            // txtMenuName
            // 
            txtMenuName.Location = new Point(155, 37);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.Size = new Size(125, 27);
            txtMenuName.TabIndex = 18;
            // 
            // lblMenuName
            // 
            lblMenuName.AutoSize = true;
            lblMenuName.Location = new Point(15, 37);
            lblMenuName.Name = "lblMenuName";
            lblMenuName.Size = new Size(73, 20);
            lblMenuName.TabIndex = 17;
            lblMenuName.Text = "Menü Adı";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(448, 25);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(168, 20);
            lblProduct.TabIndex = 16;
            lblProduct.Text = "Menüye Eklenen Ürünler";
            // 
            // lbProduct
            // 
            lbProduct.FormattingEnabled = true;
            lbProduct.Location = new Point(448, 58);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new Size(170, 204);
            lbProduct.TabIndex = 15;
            // 
            // gpOrder
            // 
            gpOrder.Controls.Add(lbOrderID);
            gpOrder.Controls.Add(lbOrders);
            gpOrder.Controls.Add(btnOrderAdd);
            gpOrder.Controls.Add(cbMenus);
            gpOrder.Controls.Add(lblMenus);
            gpOrder.Controls.Add(lblProducts);
            gpOrder.Controls.Add(pbProductPic);
            gpOrder.Controls.Add(cbProducts);
            gpOrder.Controls.Add(lblTotalPrice);
            gpOrder.Controls.Add(btnOrderConfirm);
            gpOrder.Controls.Add(lblTotal);
            gpOrder.Controls.Add(cbKetchup);
            gpOrder.Controls.Add(cbMayonnaise);
            gpOrder.Controls.Add(nuAmount);
            gpOrder.Controls.Add(lblOrderDetails);
            gpOrder.Controls.Add(lblAmount);
            gpOrder.Location = new Point(34, 36);
            gpOrder.Name = "gpOrder";
            gpOrder.Size = new Size(723, 577);
            gpOrder.TabIndex = 14;
            gpOrder.TabStop = false;
            gpOrder.Text = "Sipariş";
            // 
            // lbOrderID
            // 
            lbOrderID.FormattingEnabled = true;
            lbOrderID.Location = new Point(468, 76);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(167, 144);
            lbOrderID.TabIndex = 18;
            lbOrderID.Visible = false;
            // 
            // lbOrders
            // 
            lbOrders.FormattingEnabled = true;
            lbOrders.Location = new Point(274, 29);
            lbOrders.Name = "lbOrders";
            lbOrders.Size = new Size(411, 324);
            lbOrders.TabIndex = 17;
            // 
            // btnOrderAdd
            // 
            btnOrderAdd.Location = new Point(27, 428);
            btnOrderAdd.Name = "btnOrderAdd";
            btnOrderAdd.Size = new Size(128, 45);
            btnOrderAdd.TabIndex = 16;
            btnOrderAdd.Text = "Ekle";
            btnOrderAdd.UseVisualStyleBackColor = true;
            btnOrderAdd.Click += btnOrderAdd_Click;
            // 
            // cbMenus
            // 
            cbMenus.FormattingEnabled = true;
            cbMenus.Location = new Point(81, 197);
            cbMenus.Name = "cbMenus";
            cbMenus.Size = new Size(151, 28);
            cbMenus.TabIndex = 15;
            // 
            // lblMenus
            // 
            lblMenus.AutoSize = true;
            lblMenus.Location = new Point(15, 205);
            lblMenus.Name = "lblMenus";
            lblMenus.Size = new Size(63, 20);
            lblMenus.TabIndex = 14;
            lblMenus.Text = "Menüler";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(15, 137);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(57, 20);
            lblProducts.TabIndex = 13;
            lblProducts.Text = "Ürünler";
            // 
            // FoodOrderMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 1061);
            Controls.Add(gpMenuAdd);
            Controls.Add(gpOrder);
            Controls.Add(gpProductAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FoodOrderMenu";
            Text = "ProductManager";
            Load += FoodOrderMenu_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuAmount).EndInit();
            gpProductAdd.ResumeLayout(false);
            gpProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrepTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            gpMenuAdd.ResumeLayout(false);
            gpMenuAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuMenuPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuPrepTimeMenu).EndInit();
            gpOrder.ResumeLayout(false);
            gpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem siparisYonetimiToolStripMenuItem1;
        private ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private MenuStrip menuStrip1;
        private PictureBox pbProductPic;
        private ComboBox cbProducts;
        private CheckBox cbKetchup;
        private CheckBox cbMayonnaise;
        private Label lblOrderDetails;
        private NumericUpDown nuAmount;
        private Label lblAmount;
        private Label lblTotal;
        private Label lblTotalPrice;
        private Button btnOrderConfirm;
        private GroupBox gpProductAdd;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Button btnProductAdd;
        private TextBox txtProductName;
        private NumericUpDown nuPrice;
        private Label lblPrice;
        private Label lblProductName;
        private Label lblPrepTime;
        private NumericUpDown nuPrepTime;
        private ToolStripMenuItem menüYönetimiToolStripMenuItem;
        private GroupBox gpOrder;
        private Label lblMenus;
        private Label lblProducts;
        private ComboBox cbMenus;
        private Button btnOrderAdd;
        private ListBox lbProduct;
        private GroupBox gpMenuAdd;
        private Label lblMenuName;
        private Label lblProduct;
        private TextBox txtMenuName;
        private CheckBox cxbIsAllergen;
        private Label lblPrepTimeMenu;
        private NumericUpDown nuPrepTimeMenu;
        private Button btnMenuAdd;
        private Label lblProductList;
        private ComboBox cbProductList;
        private Button btnMenuProduct;
        private ListBox lbSelectedItemIds;
        private ListBox lbOrderID;
        private ListBox lbOrders;
        private Label lblMenuPrice;
        private NumericUpDown nuMenuPrice;
    }
}