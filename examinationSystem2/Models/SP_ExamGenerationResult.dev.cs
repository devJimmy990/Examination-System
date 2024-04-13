using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem2.Models
{
    public partial class SP_ExamGenerationResult
    {
        public int Exam_ID { get; set; }
        public int Ques_ID { get; set; }
        public string Ques_Type { get; set; }
        public string Ques_Body { get; set; }
        public string Ques_Choices { get; set; }
    }
}
