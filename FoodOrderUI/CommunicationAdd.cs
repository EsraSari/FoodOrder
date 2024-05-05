using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDomain;
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
    public partial class CommunicationAdd : Form
    {
        private int _customerid;
        AppDBContext db;
        LoadComboBoxManager loadCombo;
        public CommunicationAdd()
        {
            InitializeComponent();
        }
        public CommunicationAdd(int customerid)
        {
            InitializeComponent();
            _customerid = customerid;
        }

        private void btnCommAdd_Click(object sender, EventArgs e)
        {
            int contactType = (int)cbCommTypes.SelectedValue;
            string commDetail = txtCommDetail.Text.Trim();
            ContactInformations contactInfo = new ContactInformations()
            {
                CustomerID = _customerid,
                ContactTypeID = contactType,
                CommDetail = commDetail
            };

            db.ContactInformations.Add(contactInfo);
            db.SaveChanges();
            DialogResult result = MessageBox.Show("Kayıt başarılı", "Başarılı", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                UserProfile p = new UserProfile(_customerid);
                p.Show();
                this.Close();
            }
        }

        private void CommunicationAdd_Load(object sender, EventArgs e)
        {
            db = new AppDBContext();
            loadCombo = new LoadComboBoxManager(db);
            var commTypes = loadCombo.LoadCommTypes();
            cbCommTypes.DisplayMember = "Value";
            cbCommTypes.ValueMember = "Key";
            cbCommTypes.DataSource = new BindingSource(commTypes, null);
        }
    }
}
