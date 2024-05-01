using FoodOrderBL;
using FoodOrderDAL.Context;
using FoodOrderDAL.Repositories;
using FoodOrderDomain;


namespace FoodOrderUI
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }
        AppDBContext db;
        LoadComboBoxManager loadCombo;
        private void btnRegister_Click_1(object sender, EventArgs e)
        {

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            int gender = (int)cbGender.SelectedValue;
            DateTime birthDate = dtBirthDate.Value;
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            Customers customer = new Customers();
            customer.AddressInfo = new List<AddressInformations>();
            AddressInformations addressInfo = new AddressInformations();

            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.UserName = userName;
            customer.Password = password;
            customer.GenderID = gender;
            customer.BirthDate = birthDate;
            customer.Status = true;
            customer.AddedDate = DateTime.Now;
            customer.ModifiedDate = DateTime.Now;
            db.Customers.Add(customer);


            int country = (int)cbCountries.SelectedValue;
            int city = (int)cbCities.SelectedValue;
            int county = (int)cbCounties.SelectedValue;

            string addressdetail = txtAddressDetails.Text.Trim();

            addressInfo.CountryID = country;
            addressInfo.CityID = city;
            addressInfo.CountyID = county;
            addressInfo.CustomerID = customer.ID;
            addressInfo.AddressDetail = addressdetail;
            customer.AddressInfo.Add(addressInfo);

            db.AddressInformations.Add(addressInfo);
            db.SaveChanges();
            MessageBox.Show("Kayıt oldu");

        }
        
        private void UserRegister_Load(object sender, EventArgs e)
        {
            ClearComboBox();
            cbCities.Enabled = cbCounties.Enabled = false;

            db = new AppDBContext();
            loadCombo = new LoadComboBoxManager(db);

            var genders = loadCombo.LoadGenders();
            var countries = loadCombo.LoadCountries();


            cbGender.DisplayMember = "Value"; // ComboBox'ta görüntülenecek metin, Value özelliği (yani cinsiyet ismi) olacak
            cbGender.ValueMember = "Key"; // ComboBox'tan seçilen öğenin değeri, Key özelliği (yani cinsiyet ID'si) olacak
            cbGender.DataSource = new BindingSource(genders, null);


            cbCountries.DisplayMember = "Value"; // ComboBox'ta görüntülenecek metin, Value özelliği (yani cinsiyet ismi) olacak
            cbCountries.ValueMember = "Key"; // ComboBox'tan seçilen öğenin değeri, Key özelliği (yani cinsiyet ID'si) olacak
            cbCountries.DataSource = new BindingSource(countries, null);

        }
        public void ClearComboBox()
        {
            cbCountries.Items.Clear();
            cbCities.Items.Clear();
            cbCounties.Items.Clear();
            cbGender.Items.Clear();

            cbCountries.SelectedIndex = -1;
            cbCities.SelectedIndex = -1;
            cbCounties.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
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
    }
}
