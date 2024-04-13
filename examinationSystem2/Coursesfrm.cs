using examinationSystem2.Context;
using examinationSystem2.Models;
using ITIExamination;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examinationSystem2
{
    public partial class Coursesfrm : Form
    {
        SP_logINResult std;
        public Coursesfrm(SP_logINResult _std)
        {
            InitializeComponent();
            std = _std;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            Trace.WriteLine(comboCourses.SelectedValue);

            this.Hide();
            frmExam exam = new frmExam(int.Parse(comboCourses.SelectedValue.ToString()), std);
            exam.ShowDialog();

        }

        private async void Coursesfrm_Load(object sender, EventArgs e)
        {
            using SQL_ProjectContext context = new SQL_ProjectContext();
            var con = new SQL_ProjectContextProcedures(context);
            var result = await con.SP_GetStdCoursesAsync(std.St_id);
            comboCourses.DataSource = result;
            comboCourses.DisplayMember = "Crs_Name";
            comboCourses.ValueMember = "Crs_ID";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choosefrm ch = new Choosefrm(std);
            ch.ShowDialog();
        }
    }
}
