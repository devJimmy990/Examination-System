using examinationSystem2;
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

namespace ITIExamination
{
    public partial class frmExam : Form
    {

        int counter, idx;
        char[] ans;
        int CourseID;
        bool flag;
        SP_logINResult stID;
        int countdown=180;
        int hours, minutes, seconds;
        public frmExam(int _CourseID, SP_logINResult _stID)
        {
            InitializeComponent();
            CourseID = _CourseID;
            stID=_stID;
            flag = false;
            counter = 0;
            idx = -1;
            ans=new char[10];

            timer1.Interval = 1000; // 1 second interval
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            calcTime();
        }
        private void calcTime()
        {
            hours = countdown / 3600;
            minutes = (countdown % 3600) / 60;
            seconds = countdown % 60;
            lblTimer.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            countdown--;
            calcTime();
            if (countdown <= 0)
            {
                // Stop the timer
                timer1.Stop();

                // Navigate to another form
                this.Hide();
                Correctionfrm correctionfrm = new Correctionfrm(result[0].Exam_ID, stID, ans, CourseID);
                correctionfrm.ShowDialog();
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(counter==9)
            {
                BtnNext.Text = "Submit";
                ans[counter - 1] = CheckSelectedAnswer();
                ToggleClick();
                CheckButton(ans[counter - 1]);
                
            }
            else if(counter == 10)
            {
                ans[counter - 1] = CheckSelectedAnswer();
                this.Hide();
                Correctionfrm correctionfrm = new Correctionfrm(result[0].Exam_ID, stID, ans,CourseID);
                correctionfrm.ShowDialog();
            }
            else
            {
                BtnNext.Text = "Next";
                ans[counter - 1] = CheckSelectedAnswer();
                ToggleClick();
                CheckButton(ans[counter - 1]);
            }
            
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            ans[counter - 1] = CheckSelectedAnswer();
            //flag = true;
            ToggleClick(false);
            Trace.WriteLine(counter);
            CheckButton(ans[counter-1]);
        }
        private void resetChoices()
        {
            RbtnA.Checked = false;
            RbtnB.Checked = false;
            RbtnC.Checked = false;
            RbtnD.Checked = false;
        }

        private async void ToggleClick(bool isNext = true)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\meraf\\Desktop\\photo\\1.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            if (isNext)
            {
                //BtnPrev.Enabled = true;

                if (flag)
                {
                    if (result[idx].Ques_Type == "mcq")
                    {
                        idx += 3;
                    }
                    else
                    {
                        idx++;
                    }
                    flag = false;
                    lblTimer.Text = flag.ToString();

                }

                if (counter <= 9)
                {
                    counter++;
                    
                    lblQues.Text = counter+"- "+result[++idx].Ques_Body;
                    
                    if (result[idx].Ques_Type == "mcq")
                    {
                        RbtnA.Text = result[idx++].Ques_Choices;
                        RbtnB.Text = result[idx++].Ques_Choices;
                        RbtnC.Text = result[idx++].Ques_Choices;
                        RbtnD.Text = result[idx].Ques_Choices;
                        
                        
                    }
                    else
                    {
                        RbtnA.Text = result[idx++].Ques_Choices;
                        RbtnB.Text = result[idx].Ques_Choices;
                        RbtnC.Visible = false;
                        RbtnD.Visible = false;
                    }
                }
                
            }
            else
            {   
                if (counter > 1)
                {
                    BtnPrev.Enabled = true;
                    Trace.WriteLine(idx);
                    counter--;
                    
                    if (result[idx-1].Ques_Type == "mcq")
                    {
                        if (!flag)
                        {
                            idx-=3;
                            flag = true;
                        }
                        
                        lblQues.Text = counter + "- " + result[--idx].Ques_Body;
                        RbtnD.Text = result[idx--].Ques_Choices;
                        RbtnC.Text = result[idx--].Ques_Choices;
                        RbtnC.Visible = true;
                        RbtnD.Visible = true;
                        RbtnB.Text = result[idx--].Ques_Choices;
                        RbtnA.Text = result[idx].Ques_Choices;
                        Trace.WriteLine(RbtnA.Checked);
                        //idx++;
                    }
                    else
                    {
                        BtnPrev.Enabled = false;
                        if (!flag)
                        {
                            idx--;
                            flag = true;
                        }
                        lblQues.Text = counter + "- " + result[--idx].Ques_Body;
                        RbtnB.Text = result[idx--].Ques_Choices;
                        RbtnA.Text = result[idx].Ques_Choices;
                        RbtnC.Visible = false;
                        RbtnD.Visible = false;
                        Trace.WriteLine(RbtnA.Checked);
                    }
                }
                
            }
            

        }

        private char CheckSelectedAnswer()
        {
            char r;
            if (RbtnA.Checked)
                r = 'A';
            else if (RbtnB.Checked)
                r = 'B';
            else if (RbtnC.Checked)
                r = 'C';
            else if (RbtnD.Checked)
                r = 'D';
            else
                r = ' ';

            return r;
            //Debug.WriteLine(ans.ToString());
        }
        private void CheckButton(char ch)
        {
            resetChoices();
            Trace.WriteLine(ch);
            switch (ch)
            {
                case 'A':

                    RbtnA.Checked = true;
                    Trace.WriteLine("A");
                    break;
                case 'B':
                    RbtnB.Checked = true;
                    Trace.WriteLine("B");
                    break;
                case 'C':
                    RbtnC.Checked = true;
                    Trace.WriteLine("C");
                    break;
                case 'D':
                    RbtnD.Checked = true;
                    Trace.WriteLine("D");
                    break;
                default:
                    resetChoices();
                    Trace.WriteLine("Default");
                    break;

            }
        }
        List<SP_ExamGenerationResult> result;
        private async void frmExam_Load(object sender, EventArgs e)
        {
            using SQL_ProjectContext context = new SQL_ProjectContext();
            var con = new SQL_ProjectContextProcedures(context);
            Random random = new Random();
            int mcq= random.Next(0,10);
            result = await con.SP_ExamGenerationAsync(CourseID, mcq, 10 - mcq, 3);
            resetChoices();
            ToggleClick();
            
        }
    }
}
