namespace Student_ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Student s=new Student(1,"Rushikesh",80,90,85);
            s.Display();
            Student s1 = new Student(2, "Shubham", 70, 60, 55);
            s1.Display();

            Student s2 = new Student(3, "Rohit", 90, 78, 90);
            s2.Display();

            Student s3 = new Student(4, "Shivam", 70, 50, 60);
            s3.Display();

            Student s4 = new Student(5, "Himan", 60, 40, 80);
            s4.Display();
            
        }
    }

    public class Student
    {
        public decimal per;
        public string name;
        public string Name
        {
            set
            {
                if(value.Length<=50)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Name.");
                }
            }
            get
            {
                return name;
            }
        }

        public int rollNo;
        public int RollNo
        {
            set
            {
                if(value>0)
                {
                    rollNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid RollNo.");
                }
            }
            get
            {
                return rollNo;
            }
        }

        public decimal subject1Marks;
        public decimal Subject1Marks
        {
            set
            {
                if( value>0 && value<100)
                {
                    subject1Marks = value;  
                }
                else
                {
                    Console.WriteLine("Invalid MArks.");
                }
            }
            get
            {
                return subject1Marks;
            }
        }

        public decimal subject2Marks;
        public decimal Subject2Marks
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    subject2Marks = value;
                }
                else
                {
                    Console.WriteLine("Invalid MArks.");
                }
            }
            get
            {
                return subject2Marks;
            }
        }

        public decimal subject3Marks;
        public decimal Subject3Marks
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    subject3Marks = value;
                }
                else
                {
                    Console.WriteLine("Invalid MArks.");
                }
            }
            get
            {
                return subject3Marks;
            }
        }

        public decimal percentage()
        {
            decimal per1 = (subject1Marks + subject2Marks + subject3Marks )/ 3;
            decimal r1 = Decimal.Round(per1, 5);
            return r1;
        }

        public Student(int rollNo, string name, decimal subject1Marks, decimal subject2Marks, decimal subject3Marks)
        {
            this.RollNo = rollNo;
            this.Name = name;
            this.Subject1Marks = subject1Marks;
            this.Subject2Marks = subject2Marks;
            this.Subject3Marks = subject3Marks;
            this.per = percentage();

        }

        public void Display()
        {
            Console.WriteLine("RollNo: "+rollNo+ "--- Name: "+name+"--- Subject_1:-> "+subject1Marks+ "--- Subject_2:-> " +subject2Marks+"--- Subject_3:-> "+subject3Marks+ "--- Percentage:-> "+percentage());
            Console.WriteLine();
        }
    }
}