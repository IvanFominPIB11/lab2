namespace Labor2
{
        class Exam
        {
            public string dicipline;
            public int score;
            public DateTime ExamDate;

            public Exam(string dicipline, int score, DateTime ExamDate)
            {
                this.dicipline = dicipline;
                this.score = score;
                this.ExamDate = ExamDate;
            }
            public Exam()
            {

                this.dicipline = "";
                this.score = 0;
                this.ExamDate = new DateTime(1999, 01, 01);
            }
            public string ToFullString()
            {
                return $"Наименование: {dicipline}, оценка: {score}, дата экзамена: {ExamDate}";
            }

        }
}
