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
        LoadComboBoxManager loadCombo;
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            int gender = (int)cbGender.SelectedValue;
            DateTime birthDate = dtBirthDate.Value;
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            int contactType = (int)cbCommTypes.SelectedValue;
            string commDetail = txtCommDetail.Text.Trim();
            int country = (int)cbCountries.SelectedValue;
            int city = (int)cbCities.SelectedValue;
            int county = (int)cbCounties.SelectedValue;
            string addressDetail = txtAddressDetails.Text.Trim();

            CustomerManager customerManager = new CustomerManager();
            
            bool returnValue = customerManager.RegisterCustomer(firstName, lastName, gender, birthDate, userName, password, contactType, commDetail, country, city, county, addressDetail);
            
            if (returnValue)
            {
                DialogResult result = MessageBox.Show("Kayıt oldunuz giriş yapma sayfasına geçebilirsiniz", "Başarılı", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    UserLogin lg = new UserLogin();
                    lg.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hata alındı.");
            }
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            ClearComboBox();
            txtPassword.PasswordChar = '*';
            cbCities.Enabled = cbCounties.Enabled = false;
            loadCombo = new LoadComboBoxManager();

            var genders = loadCombo.LoadGenders();
            var countries = loadCombo.LoadCountries();
            var commTypes = loadCombo.LoadCommTypes();


            cbGender.DisplayMember = "Value"; // ComboBox'ta görüntülenecek metin, Value özelliği (yani cinsiyet ismi) olacak
            cbGender.ValueMember = "Key"; // ComboBox'tan seçilen öğenin değeri, Key özelliği (yani cinsiyet ID'si) olacak
            cbGender.DataSource = new BindingSource(genders, null);


            cbCountries.DisplayMember = "Value"; 
            cbCountries.ValueMember = "Key"; 
            cbCountries.DataSource = new BindingSource(countries, null);

            cbCommTypes.DisplayMember = "Value";
            cbCommTypes.ValueMember = "Key";
            cbCommTypes.DataSource = new BindingSource(commTypes, null);

        }
        public void ClearComboBox()
        {
            cbCountries.Items.Clear();
            cbCities.Items.Clear();
            cbCounties.Items.Clear();
            cbGender.Items.Clear();
            cbCommTypes.Items.Clear();

            cbCountries.SelectedIndex = -1;
            cbCities.SelectedIndex = -1;
            cbCounties.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            cbCommTypes.SelectedIndex = -1;
        }
        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCities.SelectedIndex = -1;
            if (cbCountries.SelectedValue != null)
            {
                int selectedCountryId = (int)cbCountries.SelectedValue; // Seçilen ülkenin ID'sini al
                loadCombo = new LoadComboBoxManager(selectedCountryId);
                var cities = loadCombo.LoadCities();
                cbCities.DisplayMember = "Value"; // ComboBox'ta görüntülenecek metin, Value özelliği (yani şehir ismi) olacak
                cbCities.ValueMember = "Key"; // ComboBox'tan seçilen öğenin değeri, Key özelliği (yani şehir ID'si) olacak
                cbCities.DataSource = new BindingSource(cities, null);
                cbCities.Enabled = true;
                cbCities.SelectedIndex = -1; // Şehir seçimini temizle
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
            }
        }
    }
}
