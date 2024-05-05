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
            CommunicationManager communicationManager = new CommunicationManager();
            
            int contactType = (int)cbCommTypes.SelectedValue;
            string commDetail = txtCommDetail.Text.Trim();
            bool returnValue = communicationManager.CreateComm(contactType, commDetail, _customerid);

            if (returnValue)
            {
                DialogResult result = MessageBox.Show("İletişim bilgileri kaydedilmiştir", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    UserProfile profile = new UserProfile(_customerid);
                    profile.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hata alındı.");
            }

        }

        private void CommunicationAdd_Load(object sender, EventArgs e)
        {
            loadCombo = new LoadComboBoxManager();
            var commTypes = loadCombo.LoadCommTypes();
            cbCommTypes.DisplayMember = "Value";
            cbCommTypes.ValueMember = "Key";
            cbCommTypes.DataSource = new BindingSource(commTypes, null);
        }
    }
}
