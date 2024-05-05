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
            db = new AppDBContext();
            loadCombo = new LoadComboBoxManager(db);
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
                int selectedCountryId = (int)cbCountries.SelectedValue; // Seçilen ülkenin ID'sini al
                loadCombo = new LoadComboBoxManager(db, selectedCountryId);
                using (var db = new AppDBContext())
                {
                    var cities = loadCombo.LoadCities();
                    cbCities.DisplayMember = "Value"; // ComboBox'ta görüntülenecek metin, Value özelliği (yani şehir ismi) olacak
                    cbCities.ValueMember = "Key"; // ComboBox'tan seçilen öğenin değeri, Key özelliği (yani şehir ID'si) olacak
                    cbCities.DataSource = new BindingSource(cities, null);
                }
                cbCities.Enabled = true;
                cbCities.SelectedIndex = -1; // Şehir seçimini temizle
            }
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCounties.SelectedIndex = -1;
            if (cbCities.SelectedValue != null)
            {
                int selectedCityId = (int)cbCities.SelectedValue; // Seçilen ülkenin ID'sini al
                loadCombo = new LoadComboBoxManager(db, selectedCityId);
                using (var db = new AppDBContext())
                {
                    var counties = loadCombo.LoadCounties();
                    cbCounties.Enabled = true;
                    cbCounties.DisplayMember = "Value"; // ComboBox'ta görüntülenecek metin, Value özelliği (yani şehir ismi) olacak
                    cbCounties.ValueMember = "Key"; // ComboBox'tan seçilen öğenin değeri, Key özelliği (yani şehir ID'si) olacak
                    cbCounties.DataSource = new BindingSource(counties, null);
                }
                cbCounties.SelectedIndex = -1; // Şehir seçimini temizle
            }
        }

        private void btnAddressAdd_Click(object sender, EventArgs e)
        {
            AddressInformations addressInfo = new AddressInformations();
            int country = (int)cbCountries.SelectedValue;
            int city = (int)cbCities.SelectedValue;
            int county = (int)cbCounties.SelectedValue;

            string addressdetail = txtAddressDetails.Text.Trim();

            addressInfo.CountryID = country;
            addressInfo.CityID = city;
            addressInfo.CountyID = county;
            addressInfo.CustomerID = _customerid;
            addressInfo.AddressDetail = addressdetail;

            db.AddressInformations.Add(addressInfo);

            db.SaveChanges();
            DialogResult result = MessageBox.Show("Adres kaydedilmiştir", "Başarılı", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                UserProfile profile = new UserProfile(_customerid);
                profile.Show();
                this.Close();
            }
        }
    }
}
