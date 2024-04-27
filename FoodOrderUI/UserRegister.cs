using FoodOrderDAL.Context;
using FoodOrderDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodOrderUI
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }
        AppDBContext db;
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
           
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                bool gender = (cbGender.SelectedIndex == 1) ? false : true; // 1 seçtiyse kadın, 2 seçtiyse erkek
                DateTime birthDate = dtBirthDate.Value;
                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();

                Customers customer = new Customers();

                //customer.ID = 1;
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.UserName = userName;
                customer.Password = password;
                customer.Gender = gender;
                customer.BirthDate = birthDate;
                customer.Status = true;
                customer.AddedDate = DateTime.Now;
                customer.ModifiedDate = DateTime.Now;

                if (!db.Customers.Contains(customer)) // eğer içermiyorsa ekle (tüm objeyi karşılaştırıyor addeddate'e varana kadar eşit olmalı)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    //LoadCategories(db.Categories.ToList()); //ekledilkten sonra tekrar listelesin.
                    MessageBox.Show("Kayıt oldu");
                }


                //Category newCategory = new Category();
                //newCategory.Name = categoryName;
                //newCategory.Description = categoryDesc;
                //newCategory.IsActive = true;
                //newCategory.AddedDate = DateTime.Now;


            
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("Kadın");
            cbGender.Items.Add("Erkek");
            db = new AppDBContext();
        }
    }
}
