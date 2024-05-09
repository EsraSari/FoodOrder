using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using FoodOrderDomain.Views;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodOrderUI
{
    public partial class FoodOrderMenu : Form
    {
        AppDBContext db = new AppDBContext();
        LoadComboBoxManager loadCombo;
        int _customerID;
        int _addressID;
        int _contactID;
        decimal total;
        public FoodOrderMenu()
        {
            InitializeComponent();
        }
        public FoodOrderMenu(int customerID, int addressID, int contactID)
        {
            InitializeComponent();
            _customerID = customerID;
            _addressID = addressID;
            _contactID = contactID;
        }
        private void orderManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOrderItems();
        }

        private void FoodOrderMenu_Load(object sender, EventArgs e)
        {
            gpOrder.Visible = true;
            gpMenuAdd.Visible = false;
            gpProductAdd.Visible = false;
            LoadOrderItems();
        }

        private void productManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpProductAdd.Visible = true;
            gpOrder.Visible = false;
            gpMenuAdd.Visible = false;

            var categories = LoadComboBoxEntities.LoadCategories(db);

            cbCategory.DisplayMember = "Value";
            cbCategory.ValueMember = "Key";
            cbCategory.DataSource = new BindingSource(categories, null);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductAdd();
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            int itemType = 1;
            int productID = 0;
            int productAmount = (int)nuProductAmount.Value;
            int menuAmount = (int)nuMenuAmount.Value;

            AddToListView(itemType, productID, productAmount, menuAmount);
            
            lblTotalPrice.Text = TotalPriceCalculate().ToString();
            cbProducts.SelectedIndex = -1;
            cbMenus.SelectedIndex = -1;
            nuMenuAmount.Value = 0;
            nuProductAmount.Value = 0;
        }
        
        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            MenuAdd();
        }

        private void menuManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpMenuAdd.Visible = true;
            gpProductAdd.Visible = false;
            gpOrder.Visible = false;
            loadCombo = new LoadComboBoxManager();
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

        private void btnOrderConfirm_Click(object sender, EventArgs e)
        {
            string orderNotes = txtOrderNotes.Text.Trim();
            List<OrderItems> orderItems = new List<OrderItems>();

            foreach (ListViewItem item in lstOrderItems.Items)
            {
                int itemType = int.Parse(item.Text);
                int itemId = int.Parse(item.SubItems[1].Text); // ID, örneğin ilk alt öğe olarak varsayıldı
                int amount = int.Parse(item.SubItems[2].Text);
                orderItems.Add(new OrderItems { TypeID = itemType, ID = itemId, Amount = amount });
            }
            OrderManager orderManager = new OrderManager();

            bool returnValue = orderManager.CreateOrder(_customerID, _addressID, _contactID, total, orderNotes, orderItems);

            if (returnValue)
            {
                DialogResult result = MessageBox.Show("Sipariş oluşturuldu, siparişinizi takip etmek için tamam'a tıklayın.", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    UserProfile userProfile = new UserProfile(_customerID);
                    userProfile.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hata alındı.");
            }
        }
        private void LoadOrderItems()
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

            cbProducts.SelectedIndex = -1;
            cbMenus.SelectedIndex = -1;
        }
        private void MenuAdd()
        {
            string menuName = txtMenuName.Text.Trim();
            int prepTime = (int)nuPrepTimeMenu.Value;
            bool isAllergen = cxbIsAllergen.Checked;
            decimal price = (int)nuMenuPrice.Value;

            List<int> productIDs = new List<int>();
            foreach (var item in lbSelectedItemIds.Items)
            {
                int productID = Convert.ToInt32(item);
                productIDs.Add(productID);
            }

            MenuManager menuManager = new MenuManager();
            bool returnValue = menuManager.CreateMenu(menuName, prepTime, isAllergen, price, productIDs);

            if (returnValue)
            {
                DialogResult result = MessageBox.Show("Ürün başarılı bir şekilde eklendi", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    txtMenuName.Text = String.Empty;
                    nuPrice.Value = 0;
                    nuPrepTimeMenu.Value = 0;
                    nuMenuPrice.Value = 0;
                    cxbIsAllergen.Checked = false;
                    cbProductList.SelectedItem = -1;
                    lbSelectedItemIds.Items.Clear();
                    lbProduct.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Hata alındı.");
            }
        }
        private void ProductAdd()
        {
            string productName = txtProductName.Text.Trim();
            decimal price = nuPrice.Value;
            int catID = (int)cbCategory.SelectedValue;
            int prepTime = (int)nuPrepTime.Value;

            ProductManager productManager = new ProductManager();
            bool returnValue = productManager.CreateProduct(productName, price, catID, prepTime);

            if (returnValue)
            {
                DialogResult result = MessageBox.Show("Ürün başarılı bir şekilde eklendi", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    txtProductName.Text = String.Empty;
                    nuPrice.Value = 0;
                    nuPrepTime.Value = 0;
                    cbCategory.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Hata alındı.");
            }
        }
        private decimal TotalPriceCalculate()
        {

            total = 0;

            foreach (ListViewItem item in lstOrderItems.Items)
            {
                int itemType = int.Parse(item.Text);
                int itemId = int.Parse(item.SubItems[1].Text); // ID, örneğin ilk alt öğe olarak varsayıldı
                int amount = int.Parse(item.SubItems[2].Text);
                if (itemType == 1)
                {
                    var productPrices = (from pr in db.Products
                                         where pr.ID == itemId
                                         select pr.Price).FirstOrDefault();
                    total += productPrices * amount;
                }
                if (itemType == 2)
                {
                    var menuPrices = (from m in db.Menu
                                      where m.ID == itemId
                                      select m.Price).FirstOrDefault();
                    total += menuPrices * amount;
                }
            }
            return total;
        }

        private void AddToListView(int itemType, int productID, int productAmount, int menuAmount)
        {
            if (cbProducts.Text != String.Empty)
            {
                string productText = cbProducts.Text + " " + "Adet: " + nuProductAmount.Text;
                lbOrders.Items.Add(productText);

                if (cbProducts.SelectedValue != null)
                {
                    productID = (int)cbProducts.SelectedValue;
                    itemType = 1;
                    ListViewItem item = new ListViewItem(itemType.ToString());
                    item.SubItems.Add(productID.ToString());
                    item.SubItems.Add(productAmount.ToString());
                    lstOrderItems.Items.Add(item);
                }
            }

            if (cbMenus.Text != String.Empty)
            {
                string menuText = cbMenus.Text + " " + "Adet: " + nuMenuAmount.Text;
                lbOrders.Items.Add(menuText);

                if (cbMenus.SelectedValue != null)
                {
                    int menuId = (int)cbMenus.SelectedValue;
                    itemType = 2;
                    ListViewItem item = new ListViewItem(itemType.ToString());
                    item.SubItems.Add(menuId.ToString());
                    item.SubItems.Add(menuAmount.ToString());
                    lstOrderItems.Items.Add(item);
                }
            }
        }


    }
}
