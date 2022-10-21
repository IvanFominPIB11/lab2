namespace Labor2
    {
        class Person
        {
            private string name;
            private string secondname;
            private DateTime birthday;


            public Person(string name, string secondname, DateTime birthday)
            {
                this.name = name;
                this.secondname = secondname;
                this.birthday = birthday;
            }
            public Person()
            {
                this.name = "Иван";
                this.secondname = "Фомин";
                this.birthday = new DateTime(1999, 07, 01);
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Secondname
            {
                get { return secondname; }
                set { secondname = value; }
            }
            public DateTime Birthday
            {
                get { return birthday; }
                set { birthday = value; }
            }
            public int year
            {
                get { return year; }
                set { year = value; }
            }
            public string ToFullString()
            {
                return $"Имя: {name}, " + $"фамилия: {secondname}, " + $"дата рождения: {birthday}";
            }
            public string ToShortString(string name, string secondname)
            {
                return $"Имя: {name}, фамилия: {secondname}";
            }

        }
    }