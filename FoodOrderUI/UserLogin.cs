using FoodOrderDAL.Context;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodOrderUI
{
    public partial class UserLogin : Form
    {
        AppDBContext db;
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (db.Customers.FirstOrDefault(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text) != null)
            {
                int customerID = db.Customers
                    .Where(c => c.UserName == txtUserName.Text)
                    .Select(c => c.ID)
                    .FirstOrDefault();
                if (customerID == 0)
                {
                    MessageBox.Show("Test");
                }
                else
                {
                    UserProfile profile = new UserProfile(customerID);
                    profile.Show();
                    this.Hide();
                }

                //int addressInfo = (from d in db.AddressInformations
                //                  where d.CustomerID == customerID
                //                   select d.ID).FirstOrDefault();

                //FoodOrderMenu productManager = new FoodOrderMenu(customerID, addressInfo);
                //productManager.Show();

            }
            else
            {
                MessageBox.Show("Kullanýcý adý ya da parola hatalý", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error
                     );
                txtUserName.Text = txtUserName.Text = "";
                txtPassword.Clear();
                txtUserName.Focus(); // mouse imlecini oraya getirir.
            }

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            db = new AppDBContext();
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
