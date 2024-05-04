﻿using FoodOrderBL;
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
            LoadAddressInfo();

        }

        private void LoadAddressInfo()
        {
            lstViewAdress.Items.Clear();
            LoadInformationManager mng = new LoadInformationManager(db, _customerID);
            var addressInfo = mng.GetAddressInfo().ToList();

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
            lstOrders.Items.Clear();
            LoadInformationManager mng = new LoadInformationManager(db, _customerID);
            var orders = mng.GetOrders();

            int index = 0;
            if (orders.Count() > 0)
            {
                foreach (var order in orders)
                {
                    lstOrders.Items.Add(order.OrderID.ToString());
                    lstOrders.Items[index].SubItems.Add(order.OrderPrice.ToString());
                    lstOrders.Items[index].SubItems.Add(order.OrderState.ToString());
                    lstOrders.Items[index].SubItems.Add(order.OrderDetail.ToString());
                    index++;
                }
            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

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
                        LoadOrders();
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
            LoadOrders();
        }

        private void siparişiİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelOrder();
        }

        private void CancelOrder()
        {
            int orderID = int.Parse(lstOrders.SelectedItems[0].SubItems[0].Text);
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
            FoodOrderMenu orders =  new FoodOrderMenu(_customerID, addressId);
            orders.ShowDialog();
            this.Close();
        }
    }
}
