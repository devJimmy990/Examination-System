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
    public partial class Correctionfrm : Form
    {
        int ExamID;
        SP_logINResult StID;
        char[] ans;
        int crsID;
        public Correctionfrm(int _ExamID, SP_logINResult _StID, char[] _ans, int _crsID)
        {
            InitializeComponent();
            ExamID = _ExamID;
            StID = _StID;
            ans = _ans;
            crsID = _crsID;
        }
        int result;
        private async void Correctionfrm_Load(object sender, EventArgs e)
        {
            using SQL_ProjectContext context = new SQL_ProjectContext();
            var con = new SQL_ProjectContextProcedures(context);
            result = await con.SP_ExamAnswersAsync(ExamID, StID.St_id, crsID, "" + ans[0], "" + ans[1], "" + ans[2], "" + ans[3], "" + ans[4], "" + ans[5], "" + ans[6], "" + ans[7], "" + ans[8], "" + ans[9]);
            var correct = await con.SP_ExamCorrectionAsync(ExamID, StID.St_id);
            lblGrade.Text = correct[0].grade+"%";
            Trace.WriteLine(correct);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choosefrm coursesfrm = new Choosefrm(StID);
            coursesfrm.ShowDialog();

        }
    }
}
