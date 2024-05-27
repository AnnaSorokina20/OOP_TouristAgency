using Microsoft.Extensions.DependencyInjection;
using TourAgency.Models;

namespace TourAgency
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly UserSession _userSession;

        public MainForm(IServiceProvider serviceProvider, UserSession userSession)
        {
            _serviceProvider = serviceProvider;
            _userSession = userSession;
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
            _userSession.CurrentUser = e.User;
            if (e.User.IsAdmin)
            {
                var manageToursForm = _serviceProvider.GetRequiredService<ManageToursForm>();
                manageToursForm.FormClosed += (s, args) => this.Show();
                manageToursForm.Show();
            }
            else
            {
                var viewToursForm = _serviceProvider.GetRequiredService<SearchToursForm>();
                viewToursForm.FormClosed += (s, args) => this.Show();
                viewToursForm.Show();
            }
            this.Hide();
        }
    }
}
