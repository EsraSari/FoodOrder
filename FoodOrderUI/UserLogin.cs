namespace FoodOrderUI
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();

            productManager.Show();
            this.Hide();
        }
    }
}
