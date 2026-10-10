
using DO;

namespace Dal;

internal static class DataSource
{
    internal static List<Answer>? Answers = new();
    internal static List<Exam>? Exams = new();
    internal static List<Question>? questions=new();
    internal static List<Student>? Students = new();
    internal static List<StudentQuestion>? studentQuestions = new();

    internal static class Config
    {
            //שדות מס' רץ עבור Student
            internal const int StudentIdStart = 1;

            private static int nextStudentId = StudentIdStart;

            public static int NextStudentId
            {
                get { return nextStudentId++; }
            }

            //שדות מס' רץ עבור Exam

            internal const int ExamIdStart = 1000;

            private static int nextExamId = ExamIdStart;

            public static int NextExamId
            {
                get { return nextExamId++; }
            }

            //שדות מס' רץ עבור Question

            internal const int QuestionIdStart = 1;

            private static int nextQuestionId = QuestionIdStart;

            public static int NextQuestionId
            {
            get { return nextQuestionId++; }
            }

            //שדות מס' רץ עבור Answer

            internal const int AnswerIdStart = 1;

            private static int nextAnswerId = AnswerIdStart;

             public static int NextAnswerId
            {
                get { return nextAnswerId++; }
            }

            //שדות מס' רץ עבור StudentQuestion

            internal const int StudentQuestionIdStart = 1;

            private static int nextStudentQuestionId = StudentQuestionIdStart;

            public static int NextStudentQuestionId
            {
                get { return nextStudentQuestionId++; }
            }
    }

}
