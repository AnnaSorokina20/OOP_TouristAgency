using Microsoft.Extensions.DependencyInjection;
using TourAgency.Models;

namespace TourAgency
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var authForm = _serviceProvider.GetRequiredService<AuthForm>();
            authForm.UserAuthenticated += AuthForm_UserAuthenticated;
            authForm.ShowDialog();
        }

        private void AuthForm_UserAuthenticated(object sender, UserEventArgs e)
        {
            var userSession = _serviceProvider.GetRequiredService<UserSession>();
            userSession.CurrentUser = e.User;
            if (e.User.IsAdmin)
            {
                var manageToursForm = _serviceProvider.GetRequiredService<ManageToursForm>();
                manageToursForm.FormClosed += (s, args) => this.Close();
                manageToursForm.Show();
            }
            else
            {
                var viewToursForm = _serviceProvider.GetRequiredService<SearchToursForm>();
                viewToursForm.FormClosed += (s, args) => this.Close();
                viewToursForm.Show();
            }
            this.Hide();

        }
    }
}
