using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStoreManagementSystem
{
    public partial class Login : Form
    {
        ModelContext _context = new ModelContext();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty && Properties.Settings.Default.Password != string.Empty)
            {
                userNameInput.Text = Properties.Settings.Default.UserName;
                passwordInput.Text = Properties.Settings.Default.Password;
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (userNameInput.Text.Trim() != "" && passwordInput.Text.Trim() != "")
            {
                var x = _context.User.Where(u => u.userName == userNameInput.Text).FirstOrDefault();

                if (x != null)
                {
                    if (x.userPassword == passwordInput.Text)
                    {
                        if (check_RememberMe.Checked == true)
                        {
                            Properties.Settings.Default.UserName = userNameInput.Text;
                            Properties.Settings.Default.Password = passwordInput.Text;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.UserName = "";
                            Properties.Settings.Default.Password = "";
                            Properties.Settings.Default.Save();
                        }

                        this.Hide();
                        var role = _context.Roles.Where(r => r.roleId == x.roleId).FirstOrDefault();
                        var main = new Main(role.roleName);
                        main.Closed += (s, args) => this.Close();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifrə yanlışdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("İstifadəçi mövcud deyil", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və şifrə boş ola bilməz", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
