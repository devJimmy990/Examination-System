using examinationSystem2.Context;
using examinationSystem2.Models;
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
    public partial class Examsfrm : Form
    {
        SP_logINResult stdID;
        public Examsfrm(SP_logINResult _stdID)
        {
            InitializeComponent();
            stdID = _stdID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        List<SP_ReopSTDCourseGradeResult> result;
        private async void Examsfrm_Load(object sender, EventArgs e)
        {
            using SQL_ProjectContext context = new SQL_ProjectContext();
            var con = new SQL_ProjectContextProcedures(context);
            result = await con.SP_ReopSTDCourseGradeAsync(stdID.St_id);
            int i = 0;
            panel1.Controls.Clear();
            panel1.AutoScroll = true;

            foreach (var item in result)
            {
                showeaxms showeaxms = new showeaxms(this, stdID, item.Crs_ID);
                //if (i == 0)
                //    panel1.Controls.Remove(showeaxms);
                showeaxms.createExam(item.Crs_Name, item.Grade);
                showeaxms.Location = new Point(0, i * (this.Height / 4));

                panel1.Controls.Add(showeaxms);
                i++;
                //Trace.WriteLine(i);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choosefrm choosefrm = new Choosefrm(stdID);
            choosefrm.ShowDialog();
        }
    }
}
