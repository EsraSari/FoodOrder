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
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            orderManagerToolStripMenuItem = new ToolStripMenuItem();
            productManagerToolStripMenuItem = new ToolStripMenuItem();
            menuManagerToolStripMenuItem = new ToolStripMenuItem();
            pbProductPic = new PictureBox();
            cbProducts = new ComboBox();
            cbKetchup = new CheckBox();
            cbMayonnaise = new CheckBox();
            lblOrderDetails = new Label();
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
            lblOrderNotes = new Label();
            txtOrderNotes = new TextBox();
            lstOrderItems = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            nuMenuAmount = new NumericUpDown();
            lblMenuAmount = new Label();
            nuProductAmount = new NumericUpDown();
            lblProductAmount = new Label();
            lbOrders = new ListBox();
            btnOrderAdd = new Button();
            cbMenus = new ComboBox();
            lblMenus = new Label();
            lblProducts = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductPic).BeginInit();
            gpProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrepTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            gpMenuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuMenuPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuPrepTimeMenu).BeginInit();
            gpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuMenuAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuProductAmount).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { orderManagerToolStripMenuItem, productManagerToolStripMenuItem, menuManagerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(903, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // orderManagerToolStripMenuItem
            // 
            orderManagerToolStripMenuItem.Name = "orderManagerToolStripMenuItem";
            orderManagerToolStripMenuItem.Size = new Size(129, 24);
            orderManagerToolStripMenuItem.Text = "Sipariş Yönetimi";
            orderManagerToolStripMenuItem.Click += orderManagerToolStripMenuItem_Click;
            // 
            // productManagerToolStripMenuItem
            // 
            productManagerToolStripMenuItem.Name = "productManagerToolStripMenuItem";
            productManagerToolStripMenuItem.Size = new Size(116, 24);
            productManagerToolStripMenuItem.Text = "Ürün Yönetimi";
            productManagerToolStripMenuItem.Click += productManagerToolStripMenuItem_Click;
            // 
            // menuManagerToolStripMenuItem
            // 
            menuManagerToolStripMenuItem.Name = "menuManagerToolStripMenuItem";
            menuManagerToolStripMenuItem.Size = new Size(122, 24);
            menuManagerToolStripMenuItem.Text = "Menü Yönetimi";
            menuManagerToolStripMenuItem.Click += menüYönetimiToolStripMenuItem_Click;
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
            cbKetchup.Location = new Point(15, 331);
            cbKetchup.Name = "cbKetchup";
            cbKetchup.Size = new Size(77, 24);
            cbKetchup.TabIndex = 3;
            cbKetchup.Text = "Ketçap";
            cbKetchup.UseVisualStyleBackColor = true;
            // 
            // cbMayonnaise
            // 
            cbMayonnaise.AutoSize = true;
            cbMayonnaise.Location = new Point(15, 375);
            cbMayonnaise.Name = "cbMayonnaise";
            cbMayonnaise.Size = new Size(91, 24);
            cbMayonnaise.TabIndex = 4;
            cbMayonnaise.Text = "Mayonez";
            cbMayonnaise.UseVisualStyleBackColor = true;
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Location = new Point(225, 23);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(50, 20);
            lblOrderDetails.TabIndex = 7;
            lblOrderDetails.Text = "Sepet:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(578, 356);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 20);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Toplam";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(666, 356);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(14, 20);
            lblTotalPrice.TabIndex = 11;
            lblTotalPrice.Text = "t";
            // 
            // btnOrderConfirm
            // 
            btnOrderConfirm.Location = new Point(412, 513);
            btnOrderConfirm.Name = "btnOrderConfirm";
            btnOrderConfirm.Size = new Size(131, 53);
            btnOrderConfirm.TabIndex = 12;
            btnOrderConfirm.Text = "Siparişi Onayla";
            btnOrderConfirm.UseVisualStyleBackColor = true;
            btnOrderConfirm.Click += btnOrderConfirm_Click;
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
            gpMenuAdd.Location = new Point(34, 36);
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
            gpOrder.Controls.Add(lblOrderNotes);
            gpOrder.Controls.Add(txtOrderNotes);
            gpOrder.Controls.Add(lstOrderItems);
            gpOrder.Controls.Add(nuMenuAmount);
            gpOrder.Controls.Add(lblMenuAmount);
            gpOrder.Controls.Add(nuProductAmount);
            gpOrder.Controls.Add(lblProductAmount);
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
            gpOrder.Controls.Add(lblOrderDetails);
            gpOrder.Location = new Point(34, 36);
            gpOrder.Name = "gpOrder";
            gpOrder.Size = new Size(723, 595);
            gpOrder.TabIndex = 14;
            gpOrder.TabStop = false;
            gpOrder.Text = "Sipariş";
            // 
            // lblOrderNotes
            // 
            lblOrderNotes.AutoSize = true;
            lblOrderNotes.Location = new Point(274, 372);
            lblOrderNotes.Name = "lblOrderNotes";
            lblOrderNotes.Size = new Size(90, 20);
            lblOrderNotes.TabIndex = 32;
            lblOrderNotes.Text = "Sipariş Notu";
            // 
            // txtOrderNotes
            // 
            txtOrderNotes.Location = new Point(274, 400);
            txtOrderNotes.Multiline = true;
            txtOrderNotes.Name = "txtOrderNotes";
            txtOrderNotes.Size = new Size(411, 86);
            txtOrderNotes.TabIndex = 31;
            // 
            // lstOrderItems
            // 
            lstOrderItems.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstOrderItems.Location = new Point(403, 87);
            lstOrderItems.Name = "lstOrderItems";
            lstOrderItems.Size = new Size(261, 237);
            lstOrderItems.TabIndex = 23;
            lstOrderItems.UseCompatibleStateImageBehavior = false;
            lstOrderItems.View = View.Details;
            lstOrderItems.Visible = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TypeId";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ItemId";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Amount";
            // 
            // nuMenuAmount
            // 
            nuMenuAmount.Location = new Point(145, 274);
            nuMenuAmount.Name = "nuMenuAmount";
            nuMenuAmount.Size = new Size(77, 27);
            nuMenuAmount.TabIndex = 21;
            // 
            // lblMenuAmount
            // 
            lblMenuAmount.AutoSize = true;
            lblMenuAmount.Location = new Point(15, 276);
            lblMenuAmount.Name = "lblMenuAmount";
            lblMenuAmount.Size = new Size(90, 20);
            lblMenuAmount.TabIndex = 22;
            lblMenuAmount.Text = "Menu Adedi";
            // 
            // nuProductAmount
            // 
            nuProductAmount.Location = new Point(145, 188);
            nuProductAmount.Name = "nuProductAmount";
            nuProductAmount.Size = new Size(77, 27);
            nuProductAmount.TabIndex = 19;
            // 
            // lblProductAmount
            // 
            lblProductAmount.AutoSize = true;
            lblProductAmount.Location = new Point(15, 190);
            lblProductAmount.Name = "lblProductAmount";
            lblProductAmount.Size = new Size(84, 20);
            lblProductAmount.TabIndex = 20;
            lblProductAmount.Text = "Ürün Adedi";
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
            cbMenus.Location = new Point(81, 232);
            cbMenus.Name = "cbMenus";
            cbMenus.Size = new Size(151, 28);
            cbMenus.TabIndex = 15;
            // 
            // lblMenus
            // 
            lblMenus.AutoSize = true;
            lblMenus.Location = new Point(9, 232);
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
            ClientSize = new Size(903, 670);
            Controls.Add(gpMenuAdd);
            Controls.Add(gpOrder);
            Controls.Add(gpProductAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FoodOrderMenu";
            Text = "ProductManager";
            Load += FoodOrderMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductPic).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)nuMenuAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuProductAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem orderManagerToolStripMenuItem;
        private ToolStripMenuItem productManagerToolStripMenuItem;
        private MenuStrip menuStrip1;
        private PictureBox pbProductPic;
        private ComboBox cbProducts;
        private CheckBox cbKetchup;
        private CheckBox cbMayonnaise;
        private Label lblOrderDetails;
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
        private ToolStripMenuItem menuManagerToolStripMenuItem;
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
        private ListBox lbOrders;
        private Label lblMenuPrice;
        private NumericUpDown nuMenuPrice;
        private NumericUpDown nuMenuAmount;
        private Label lblMenuAmount;
        private NumericUpDown nuProductAmount;
        private Label lblProductAmount;
        private ListView lstOrderItems;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblOrderNotes;
        private TextBox txtOrderNotes;
    }
}