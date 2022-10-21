namespace Labor2
{
        class Student
        {
            private Person info;
            private Education form;
            private int group;
            private Exam[] sdal;


            public Student(Person info, Education form, int group)
            {
                this.info = info;
                this.form = form;
                this.group = group;
            }

            public Student()
            {
                this.info = new Person();
                this.group = 0;
                this.form = Education.Bachelor;
            }

            public Person Info
            {
                get { return info; }
                set { info = value; }
            }
            public Education Form
            {
                get { return form; }
                set { form = value; }
            }
            public int Group
            {
                get { return group; }
                set { group = value; }
            }
            public Exam[] Sdal
            {
                get { return sdal; }
                set {sdal = value; }
            }
            public double AvarageRate
            {
                get
                {
                    return AvarageRate;
                }
                set
                {
                    AvarageRate = new Exam().score / sdal.Length;
                }
            }
            public void addExams(params Exam[] exam)
            {

            }
            public string ToFullString()
            {
                return $"студент: {info.Name} {info.Secondname} {info.Birthday}, форма обучения:{form}, группа ПИБ{group}, результат экзамена: {sdal}";
            }
            public string ToShortString(string _name, string _secondname)
            {
                return $"студент: {info.Name} {info.Secondname} {info.Birthday},  форма обучения:{form}, группа ПИБ{group}, средний балл {AvarageRate}";
            }
        }
}