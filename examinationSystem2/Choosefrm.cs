using examinationSystem2.Context;
using examinationSystem2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examinationSystem2
{
    public partial class Choosefrm : Form
    {
        SP_logINResult std;
        public Choosefrm(SP_logINResult _std)
        {
            InitializeComponent();
            std = _std;
        }

        private void Choosefrm_Load(object sender, EventArgs e)
        {
            lblName.Text += std.St_Fname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Examsfrm examsfrm = new Examsfrm(std);
            examsfrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Coursesfrm c = new Coursesfrm(std);
            c.ShowDialog();
        }
    }
}
