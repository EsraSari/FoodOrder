using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDomain;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderUI
{
    public partial class UserProfile : Form
    {
        private int _customerID;
        AppDBContext db;
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
            db = new AppDBContext();
            LoadInformationManager mng = new LoadInformationManager(db, _customerID);
            var addressInfo = mng.GetAddressInfo().ToList();

            int index = 0;
            if (addressInfo.Count() > 0)
            {
                foreach (AddressInformations address in addressInfo)
                {
                    lstViewAdress.Items.Add(address.ID.ToString()); // ilki satırı başlatıyor diğer colonlar da subitem olarak yazdırıyoruz. 
                    lstViewAdress.Items[index].SubItems.Add(address.CustomerID.ToString());
                    lstViewAdress.Items[index].SubItems.Add(address.AddressDetail.ToString());
                    index++;
                }

            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
