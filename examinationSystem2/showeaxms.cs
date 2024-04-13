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
    public partial class showeaxms : UserControl
    {
        Examsfrm frm;
        SP_logINResult stID;
        int crsID;
        public showeaxms(Examsfrm _frm, SP_logINResult _stID, int _crsID)
        {
            InitializeComponent();
            frm = _frm;
            stID = _stID;
            crsID = _crsID;
        }
        public void createExam(string crsName, int? grade)
        {
            lblcrs.Text += crsName;
            lblGrade.Text += grade +"%";
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            frm.Hide();
            ExamAnswers examAnswers = new ExamAnswers(stID, crsID);
            examAnswers.ShowDialog();

        }
    }
}
