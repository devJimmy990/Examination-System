using examinationSystem2.Context;
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
    public partial class StdAnswer : UserControl
    {
        public StdAnswer()
        {
            InitializeComponent();
        }

        public async void setAnswer(string body, string std, string model, int QuesID, int i)
        {
            qus.Text = i + 1 + "- " + body;
            stdans.Text += std;
            modelans.Text += model;
            using SQL_ProjectContext context = new SQL_ProjectContext();
            var con = new SQL_ProjectContextProcedures(context);
            var result = await con.SP_SelectQuesChoicesAsync(QuesID);
            if (result.Count == 4)
            {
                lblA.Text = result[0].Ques_Choices;
                lblB.Text = result[1].Ques_Choices;
                lblC.Visible = true;
                lblD.Visible = true;
                lblC.Text = result[2].Ques_Choices;
                lblD.Text = result[3].Ques_Choices;
            }
            else
            {
                lblA.Text = result[0].Ques_Choices;
                lblB.Text = result[1].Ques_Choices;
                lblC.Visible = false;
                lblD.Visible = false;
            }
        }

        private void StdAnswer_Load(object sender, EventArgs e)
        {

        }

        private void modelans_Click(object sender, EventArgs e)
        {

        }
    }
}
