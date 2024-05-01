using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using System.Data.Common;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FoodOrderUI
{
    public partial class FoodOrderMenu : Form
    {
        AppDBContext db = new AppDBContext();
        LoadComboBoxManager loadCombo;
        int _customerID;
        int _addressID;
        public FoodOrderMenu()
        {
            InitializeComponent();
        }
        public FoodOrderMenu(int customerID, int addressID)
        {
            InitializeComponent();
            _customerID = customerID;
            _addressID = addressID;
        }
        private void siparisYonetimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gpOrder.Visible = true;
            gpProductAdd.Visible = false;
            gpMenuAdd.Visible = false;
            var menus = LoadComboBoxEntities.LoadMenus(db);
            var products = LoadComboBoxEntities.LoadProducts(db);

            cbMenus.DisplayMember = "Value";
            cbMenus.ValueMember = "Key";
            cbMenus.DataSource = new BindingSource(menus, null);

            cbProducts.DisplayMember = "Value";
            cbProducts.ValueMember = "Key";
            cbProducts.DataSource = new BindingSource(products, null);
        }

        private void FoodOrderMenu_Load(object sender, EventArgs e)
        {
            gpOrder.Visible = false;
            gpMenuAdd.Visible = false;
            gpProductAdd.Visible = false;
        }

        private void urunYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpProductAdd.Visible = true;
            gpOrder.Visible = false;
            gpMenuAdd.Visible = false;

            var categories = LoadComboBoxEntities.LoadCategories(db);

            cbCategory.DisplayMember = "Value"; // ComboBox'ta görüntülenecek metin, Value özelliği (yani cinsiyet ismi) olacak
            cbCategory.ValueMember = "Key"; // ComboBox'tan seçilen öğenin değeri, Key özelliği (yani cinsiyet ID'si) olacak
            cbCategory.DataSource = new BindingSource(categories, null);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductAdd();
        }

        private void ProductAdd()
        {
            string productName = txtProductName.Text.Trim();
            decimal price = nuPrice.Value;
            int catID = (int)cbCategory.SelectedValue;
            int prepTime = (int)nuPrepTime.Value;
            Products product = new Products()
            {
                ProductName = productName,
                Price = price,
                CategoryID = catID,
                PreparationTime = prepTime,
            };
            db.Products.Add(product);
            db.SaveChanges();
            DialogResult dgResult = MessageBox.Show("Ürün eklendi", "", MessageBoxButtons.OK);
            if (dgResult == DialogResult.OK)
            {
                txtProductName.Text = String.Empty;
                nuPrice.Value = 0;
                nuPrepTime.Value = 0;
                cbCategory.SelectedIndex = -1;

            }
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            lbOrders.Items.Add(cbProducts.Text);
            lbOrders.Items.Add(cbMenus.Text);
            lbOrderID.Items.Add((int)cbProducts.SelectedValue);
            lbOrderID.Items.Add((int)cbMenus.SelectedValue);
            TotalPriceCalculate();
        }
        private void TotalPriceCalculate()
        {
            decimal total = 0;
            for (int i = 0; i < lbOrderID.Items.Count; i++)
            {
                int itemID = (int)lbOrderID.Items[i];
                var productPrices = (from pr in db.Products
                                     where pr.ID == itemID
                                     select pr.Price).FirstOrDefault();
                total += productPrices;
                var menuPrices = (from m in db.Menu
                                  where m.ID == itemID
                                  select m.Price).FirstOrDefault();
                total += menuPrices;
            }
            lblTotalPrice.Text = total.ToString();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            MenuAdd();
        }

        private void MenuAdd()
        {
            string menuName = txtMenuName.Text.Trim();
            int prepTime = (int)nuPrepTimeMenu.Value;
            bool isAllergen = cxbIsAllergen.Checked;
            decimal price = (int)nuMenuPrice.Value;
            Menu menu = new Menu()
            {
                MenuName = menuName,
                IsAllergen = isAllergen,
                PreparationTime = prepTime,
                Price = price
            };

            db.Menu.Add(menu);
            db.SaveChanges();

            for (int i = 0; i < lbSelectedItemIds.Items.Count; i++)
            {
                int productId = (int)lbSelectedItemIds.Items[i];

                // Her seçilen ürün için yeni bir ProductMenu nesnesi oluştur
                ProductMenu productMenu = new ProductMenu
                {
                    MenuID = menu.ID, // Oluşturulan menünün ID'si
                    ProductID = productId // Seçilen ürün ID'si
                };

                db.ProductMenu.Add(productMenu);
            }
            db.SaveChanges();

            DialogResult dgResult = MessageBox.Show("Menü eklendi", "", MessageBoxButtons.OK);
            if (dgResult == DialogResult.OK)
            {
                txtMenuName.Text = String.Empty;
                nuPrice.Value = 0;
                nuPrepTimeMenu.Value = 0;
                nuMenuPrice.Value = 0;
                cxbIsAllergen.Checked = false;
                lbSelectedItemIds.Items.Clear();
                lbProduct.Items.Clear();
            }
        }

        private void menüYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpMenuAdd.Visible = true;
            gpProductAdd.Visible = false;
            gpOrder.Visible = false;
            db = new AppDBContext();
            loadCombo = new LoadComboBoxManager(db);
            var products = loadCombo.LoadProducts();

            cbProductList.DisplayMember = "Value";
            cbProductList.ValueMember = "Key";
            cbProductList.DataSource = new BindingSource(products, null);
        }

        private void btnMenuProduct_Click(object sender, EventArgs e)
        {
            lbProduct.Items.Add(cbProductList.Text);
            lbSelectedItemIds.Items.Add((int)cbProductList.SelectedValue);
        }
       
    }
}
