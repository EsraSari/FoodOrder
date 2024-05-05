using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDomain;

namespace FoodOrderUI
{
    public partial class UserProfile : Form
    {
        private int _customerID;
        AppDBContext db = new AppDBContext();
        AddressManager addressManager;
        CommunicationManager communicationManager;
        public UserProfile()
        {
            InitializeComponent();
        }
        public UserProfile(int customerId)
        {
            _customerID = customerId;
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            lstViewAdress.Visible = false;
            lstViewOrders.Visible = false;
            lstViewCommInfo.Visible = false;
            addressManager = new AddressManager(_customerID);
            communicationManager = new CommunicationManager(_customerID);
        }
        private void btnAddressInformation_Click(object sender, EventArgs e)
        {
            lstViewAdress.Visible = true;
            lstViewOrders.Visible = false;
            lstViewCommInfo.Visible = false;
            LoadAddressInfo();
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            lstViewAdress.Visible = false;
            lstViewOrders.Visible = true;
            lstViewCommInfo.Visible = false;
            LoadOrders();
        }
        private void btnCommInfos_Click(object sender, EventArgs e)
        {
            lstViewAdress.Visible = false;
            lstViewAdress.Visible = false;
            lstViewCommInfo.Visible = true;
            LoadCommInfo();
        }
        private void addNewAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            AddressAdd communicationAdd = new AddressAdd(_customerID);
            communicationAdd.Show();
        }
        private void deleteAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAddress();
        }
        private void updateAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAddress();
        }
        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder();
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addressDetail = addressManager.GetAddressInfo().FirstOrDefault();
            int addressID = addressDetail.ID;
            FoodOrderMenu orders = new FoodOrderMenu(_customerID, addressID);
            orders.ShowDialog();
            this.Close();
        }


        private void addNewContactStripMenuItem_Click(object sender, EventArgs e)
        {
            CommunicationAdd cad = new CommunicationAdd(_customerID);
            cad.Show();
            this.Close();
        }

        private void updateContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Güncelle:", "Yeni İletişim Bilgisi:", "");

            if (!string.IsNullOrEmpty(userInput))
            {
                int commID = int.Parse(lstViewCommInfo.SelectedItems[0].SubItems[0].Text);
                bool returnValue = communicationManager.UpdateComm(commID, userInput);

                if (returnValue)
                {
                    DialogResult result = MessageBox.Show("İletişim bilgisi başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        LoadCommInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip iletişim bilgisi bulunamadı.", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Metin girmediniz!", "Hata");
            }
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int commID = int.Parse(lstViewCommInfo.SelectedItems[0].SubItems[0].Text);
            bool returnValue = communicationManager.DeleteComm(commID);

            if (returnValue)
            {
                DialogResult result = MessageBox.Show("İletişim bilgisi başarıyla silindi.", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    LoadCommInfo();
                }
            }
            else
            {
                MessageBox.Show("Belirtilen ID'ye sahip iletişim bilgisi bulunamadı.", "Hata");
            }
        }


        private void LoadCommInfo()
        {
            lstViewCommInfo.Items.Clear();
            CommunicationManager communicationManager = new CommunicationManager(_customerID);
            var commInfos = communicationManager.GetCommInfo().ToList();

            int index = 0;
            if (commInfos.Count() > 0)
            {
                foreach (ContactInformations cc in commInfos)
                {
                    lstViewCommInfo.Items.Add(cc.ID.ToString());
                    lstViewCommInfo.Items[index].SubItems.Add(cc.CustomerID.ToString());
                    lstViewCommInfo.Items[index].SubItems.Add(cc.ContactTypeID.ToString());
                    lstViewCommInfo.Items[index].SubItems.Add(cc.CommDetail.ToString());
                    index++;
                }
            }
        }


        private void LoadAddressInfo()
        {
            lstViewAdress.Items.Clear();
            AddressManager addressManager = new AddressManager(_customerID);
            var addressInfo = addressManager.GetAddressInfo().ToList();

            int index = 0;
            if (addressInfo.Count() > 0)
            {
                foreach (AddressInformations address in addressInfo)
                {
                    lstViewAdress.Items.Add(address.ID.ToString());
                    lstViewAdress.Items[index].SubItems.Add(address.CustomerID.ToString());
                    lstViewAdress.Items[index].SubItems.Add(address.AddressDetail.ToString());
                    index++;
                }
            }
        }

        private void LoadOrders()
        {
            lstViewOrders.Items.Clear();
            OrderManager orderManager = new OrderManager(_customerID);
            var orders = orderManager.GetOrders().ToList();

            int index = 0;
            if (orders.Count() > 0)
            {
                foreach (var order in orders)
                {
                    lstViewOrders.Items.Add(order.OrderID.ToString());
                    lstViewOrders.Items[index].SubItems.Add(order.OrderPrice.ToString());
                    lstViewOrders.Items[index].SubItems.Add(order.OrderState.ToString());
                    lstViewOrders.Items[index].SubItems.Add(order.OrderDetail.ToString());
                    index++;
                }
            }
        }
        private void UpdateAddress()
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Güncelle:", "Yeni Adres Detayı:", "");
            if (!string.IsNullOrEmpty(userInput))
            {
                int addressID = int.Parse(lstViewAdress.SelectedItems[0].SubItems[0].Text);
                bool returnValue = addressManager.UpdateAddress(addressID, userInput);

                if (returnValue)
                {
                    DialogResult result = MessageBox.Show("Adres başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        LoadAddressInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip adres bulunamadı.", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Metin girmediniz!", "Hata");
            }
        }
        private void DeleteAddress()
        {
            int addressID = int.Parse(lstViewAdress.SelectedItems[0].SubItems[0].Text);
            bool returnValue = addressManager.DeleteAddress(addressID);
            if (returnValue)
            {
                DialogResult result = MessageBox.Show("Adres silindi.", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    LoadAddressInfo();
                }
            }
            else
            {
                MessageBox.Show("Belirtilen ID'ye sahip adres bulunamadı.", "Hata");
            }
        }
        private void CancelOrder()
        {
            OrderManager orderManager = new OrderManager();
            int orderID = int.Parse(lstViewOrders.SelectedItems[0].SubItems[0].Text);
            bool returnValue = orderManager.UpdateOrder(orderID);
            if (returnValue)
            {
                DialogResult result = MessageBox.Show("Sipariş iptal edildi.", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    LoadOrders();
                }
            }
            else
            {
                MessageBox.Show("Belirtilen ID'ye sahip sipariş bulunamadı.", "Hata");
            }
        }
    }
}
