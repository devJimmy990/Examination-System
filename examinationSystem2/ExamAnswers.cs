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
    public partial class ExamAnswers : Form
    {
        SP_logINResult stID;
        int crsID;
        public ExamAnswers(SP_logINResult _stID, int _crsID)
        {
            InitializeComponent();
            stID = _stID;
            crsID = _crsID;
        }

        private async void ExamAnswers_Load(object sender, EventArgs e)
        {
            using SQL_ProjectContext context = new SQL_ProjectContext();
            var con = new SQL_ProjectContextProcedures(context);
            var result = await con.SP_RepoStudentAnsAsync(crsID, stID.St_id);
            panel1.AutoScroll = true;


            int i = 0;
            foreach (var item in result)
            {

                StdAnswer showeaxms = new StdAnswer();

                showeaxms.setAnswer(item.Question, item.StdAnswer, item.Answer, item.QuesID, i);
                showeaxms.Location = new Point(0, i * (this.Height / 2));

                panel1.Controls.Add(showeaxms);
                i++;
                //Trace.WriteLine(i);

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Examsfrm exams = new Examsfrm(stID);
            exams.ShowDialog();
        }
    }
}
