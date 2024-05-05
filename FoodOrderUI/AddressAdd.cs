using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodOrderUI
{
    public partial class AddressAdd : Form
    {
        private int _customerid;
        private LoadComboBoxManager loadCombo;
        private AppDBContext db;
        public AddressAdd()
        {
            InitializeComponent();
        }
        public AddressAdd(int customerid)
        {
            InitializeComponent();
            _customerid = customerid;
        }
        private void CommunicationAdd_Load(object sender, EventArgs e)
        {
            loadCombo = new LoadComboBoxManager();
            var countries = loadCombo.LoadCountries();
            cbCountries.DisplayMember = "Value";
            cbCountries.ValueMember = "Key";
            cbCountries.DataSource = new BindingSource(countries, null);
        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCities.SelectedIndex = -1;
            if (cbCountries.SelectedValue != null)
            {
                int selectedCountryId = (int)cbCountries.SelectedValue; 
                loadCombo = new LoadComboBoxManager(selectedCountryId);
                
                var cities = loadCombo.LoadCities();
                cbCities.DisplayMember = "Value"; 
                cbCities.ValueMember = "Key"; 
                cbCities.DataSource = new BindingSource(cities, null);
                
                cbCities.Enabled = true;
                cbCities.SelectedIndex = -1;
            }
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCounties.SelectedIndex = -1;
            if (cbCities.SelectedValue != null)
            {
                int selectedCityId = (int)cbCities.SelectedValue;
                loadCombo = new LoadComboBoxManager(selectedCityId);
                var counties = loadCombo.LoadCounties();
                cbCounties.Enabled = true;
                cbCounties.DisplayMember = "Value";
                cbCounties.ValueMember = "Key";
                cbCounties.DataSource = new BindingSource(counties, null);
                
                cbCounties.SelectedIndex = -1;
            }
        }

        private void btnAddressAdd_Click(object sender, EventArgs e)
        {
            AddressManager addressManager = new AddressManager();
            int country = (int)cbCountries.SelectedValue;
            int city = (int)cbCities.SelectedValue;
            int county = (int)cbCounties.SelectedValue;
            string addressdetail = txtAddressDetails.Text.Trim();

            bool returnValue = addressManager.CreateAddress(country, city, county, addressdetail, _customerid);

            if (returnValue)
            {
                DialogResult result = MessageBox.Show("Adres kaydedilmiştir", "Başarılı", MessageBoxButtons.OK);
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
    }
}
