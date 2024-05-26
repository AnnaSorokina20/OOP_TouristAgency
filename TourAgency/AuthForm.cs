using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TourAgency.Services;
using TourAgency.Models;

namespace TourAgency
{
    public partial class AuthForm : Form
    {
        private readonly IUserService _userService;
        private readonly UserSession _userSession;

        public event EventHandler<UserEventArgs> UserAuthenticated;

        public AuthForm(IUserService userService, UserSession userSession)
        {
            _userService = userService;
            _userSession = userSession;
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }

        private void radioButtonR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonR.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var email = textBoxAEmail.Text;
            var password = textBoxAPassword.Text;

            var user = _userService.Authenticate(email, password);

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                _userSession.CurrentUser = user;
                UserAuthenticated?.Invoke(this, new UserEventArgs { User = user });
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var email = textBoxREmail.Text;
            var lastName = textBoxLastName.Text;
            var firstName = textBoxFirstName.Text;
            var phone = textBoxPhone.Text;
            var password = textBoxRPassword.Text;

            // Validation checks
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            // Check if email already exists
            var existingUser = _userService.GetAllUsers().FirstOrDefault(u => u.Email == email);
            if (existingUser != null)
            {
                MessageBox.Show("User with this email already exists.");
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            // Validate first name length (must be less than or equal to 15 characters)
            if (firstName.Length > 15)
            {
                MessageBox.Show("First name cannot be longer than 15 characters.");
                return;
            }

            // Validate last name length (must be less than or equal to 20 characters)
            if (lastName.Length > 20)
            {
                MessageBox.Show("Last name cannot be longer than 20 characters.");
                return;
            }

            // Validate password length (must be between 6 and 10 characters)
            if (password.Length < 6 || password.Length > 10)
            {
                MessageBox.Show("Password length must be between 6 and 10 characters.");
                return;
            }

            // Validate phone number (must be numeric and have a reasonable length)
            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number.");
                return;
            }

            var user = new User
            {
                Email = email,
                LastName = lastName,
                FirstName = firstName,
                Phone = phone,
                Password = password,
                IsAdmin = false // Assuming new users are not admins by default
            };

            _userService.AddUser(user);
            MessageBox.Show("Registration successful! You can now login.");
            radioButtonA.Checked = true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 10 && phone.Length <= 15;
        }
    }

    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
    }
}
