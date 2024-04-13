using examinationSystem2.Context;
using examinationSystem2.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace examinationSystem2
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            using SQL_ProjectContext context = new SQL_ProjectContext();
            var con = new SQL_ProjectContextProcedures(context);

            if (!string.IsNullOrWhiteSpace(txtSSN.Text) && txtSSN.Text.Length == 14 && txtSSN.Text.All(char.IsDigit))
            {
                var result = await con.SP_logINAsync(txtSSN.Text);
                SP_logINResult student = result[0];

                this.Hide();
                Choosefrm choosefrm = new Choosefrm(student);
                choosefrm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Invalid SSN", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
