using FoodOrderBL;
using FoodOrderDAL.Context;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodOrderUI
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            CustomerManager customerManager = new CustomerManager();
            int customerID = customerManager.FindCustomer(userName, password);
            if (customerID != -1)
            {
                UserProfile profile = new UserProfile(customerID);
                profile.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý ya da parola hatalý", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = txtUserName.Text = "";
                txtPassword.Clear();
                txtUserName.Focus(); 
            }

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegister rg = new UserRegister();
            rg.Show();
            this.Hide();
        }
    }
}
