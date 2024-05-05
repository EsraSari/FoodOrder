using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderUI
{
    public partial class UserProfile : Form
    {
        private int _customerID;
        AppDBContext db = new AppDBContext();
        public UserProfile()
        {
            InitializeComponent();
        }
        public UserProfile(int customerId)
        {
            _customerID = customerId;
            InitializeComponent();
        }

        private void btnAddressInformation_Click(object sender, EventArgs e)
        {
            lstViewAdress.Visible = true;
            lstViewOrders.Visible = false;
            lstViewCommInfo.Visible = false;
            LoadAddressInfo();

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

        private void UserProfile_Load(object sender, EventArgs e)
        {
            lstViewAdress.Visible = false;
            lstViewOrders.Visible = false;
            lstViewCommInfo.Visible = false;
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        private void UpdateAddress()
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Güncelle:", "Yeni Adres Detayı:", "");
            if (!string.IsNullOrEmpty(userInput))
            {
                int addressID = int.Parse(lstViewAdress.SelectedItems[0].SubItems[0].Text);
                var address = db.AddressInformations.FirstOrDefault(x => x.ID == addressID);

                if (address != null)
                {
                    address.AddressDetail = userInput;
                    db.SaveChanges();
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

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAddress();
        }

        private void DeleteAddress()
        {
            int addressID = int.Parse(lstViewAdress.SelectedItems[0].SubItems[0].Text);
            var address = db.AddressInformations.FirstOrDefault(x => x.ID == addressID);

            if (address != null)
            {
                db.AddressInformations.Remove(address);
                db.SaveChanges();
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

        private void btnOrders_Click(object sender, EventArgs e)
        {
            lstViewAdress.Visible = false;
            lstViewOrders.Visible = true;
            lstViewCommInfo.Visible = false;
            LoadOrders();
        }

        private void siparişiİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder();
        }

        private void CancelOrder()
        {
            int orderID = int.Parse(lstViewOrders.SelectedItems[0].SubItems[0].Text);
            var order = db.Orders.FirstOrDefault(x => x.ID == orderID);

            if (order != null)
            {
                order.OrderStateID = 3;
                db.SaveChanges();
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

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int addressId = (from add in db.AddressInformations
                             where add.CustomerID == _customerID
                             select add.ID).FirstOrDefault();
            FoodOrderMenu orders = new FoodOrderMenu(_customerID, addressId);
            orders.ShowDialog();
            this.Close();
        }

        private void btnCommInfos_Click(object sender, EventArgs e)
        {
            lstViewAdress.Visible = false;
            lstViewAdress.Visible = false;
            lstViewCommInfo.Visible = true;
            LoadCommInfo();
        }


        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommunicationAdd cad = new CommunicationAdd(_customerID);
            cad.Show();
            this.Close();
        }

        private void guncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Güncelle:", "Yeni İletişim Bilgisi:", "");
            if (!string.IsNullOrEmpty(userInput))
            {
                int commId = int.Parse(lstViewCommInfo.SelectedItems[0].SubItems[0].Text);
                var contacts = db.ContactInformations.FirstOrDefault(x => x.ID == commId);

                if (contacts != null)
                {
                    contacts.CommDetail = userInput;
                    db.SaveChanges();
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

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int commId = int.Parse(lstViewCommInfo.SelectedItems[0].SubItems[0].Text);
            var contacs = db.ContactInformations.FirstOrDefault(x => x.ID == commId);

            if (contacs != null)
            {
                db.ContactInformations.Remove(contacs);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("İletişim bilgisi silindi.", "Başarılı", MessageBoxButtons.OK);
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

        private void yeniEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddressAdd communicationAdd = new AddressAdd(_customerID);
            communicationAdd.Show();
        }
    }
}
