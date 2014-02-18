using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace TaskStudent
{
    class Student
    {
        private string id;
        private string firstName;
        private string secondName;
        private string lastName;
        private int facultyNumber;
        private int[] mark;
        private DateTime birthDate;

        private static int count;

        //public static Student()
        //{
                // do not work :(
        //    Student.count = 0;
        //}

        public Student(string id, int facultyNumber, int[] mark, string firstName, string secondName, string lastName)
        {
            try
            {
                ValidateID(id);
                this.facultyNumber = facultyNumber;
                this.firstName = firstName;
                this.secondName = secondName;
                this.lastName = lastName;
                this.Mark = mark;
                Student.count++;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Student(string id, int facultyNumber)
            : this(id, facultyNumber, new int[] { 2, 2 }, null, null, null)
        {
        }

        public Student(string id, int facultyNumber, int[] mark)
            : this(id, facultyNumber, mark, null, null, null)
        {
        }

        public Student(string id, int facultyNumber, string firstName, string secondName, string lastName)
            : this(id, facultyNumber, new int[] { 2, 2 }, firstName, secondName, lastName)
        {
        }

        public Student(string id, int facultyNumber, string firstName, string lastName)
            : this(id, facultyNumber, new int[] { 2, 2 }, firstName, null, lastName)
        {
        }

        public Student(string id, int facultyNumber, int[] mark, string firstName, string lastName)
            : this(id, facultyNumber, mark, firstName, null, lastName)
        {
        }

        ~Student()
        {
            Student.count--;
        }

        public int[] Mark
        {
            get { return this.mark; }
            set
            {
                if (value != null)
                {
                    if (value.Length != 2)
                    {
                        throw new ArgumentOutOfRangeException("The subject must be two.");
                    }
                    foreach (var item in value)
                    {
                        if ((item < 2) || (item > 6))
                        {
                            throw new ArgumentOutOfRangeException("The subject must be from 2 to 6");
                        }
                    }
                }
                this.mark = value;
            }
        }

        public static int Count
        {
            get { return Student.count; }
            set { Student.count = value; }
        }

        private void ValidateID(string id)
        {
            int mounth;
            string birthYear;
            string birthMounth;
            string formats;
            string strBirthDate;

            if (id.Length != 10)
            {
                throw new ArgumentOutOfRangeException("The id must have 10 symbols.");
            }
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    byte.Parse(id.Substring(i, 1));
                }
            }
            catch (FormatException)
            {
                throw new ArgumentOutOfRangeException("The id must have only numbers.");
            }

            birthYear = id.Substring(0, 2);
            birthMounth = id.Substring(2, 2);
            mounth = Convert.ToInt32(birthMounth);
            if (mounth > 40)
            {
                birthYear = "20" + birthYear;
                mounth -= 40;
            }
            else
            {
                birthYear = "19" + birthYear;
            }

            
            strBirthDate = id.Substring(4, 2) + "." + mounth + "." + birthYear;
            formats = "dd.M.yyyy";

            if (!DateTime.TryParseExact(strBirthDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                throw new ArgumentOutOfRangeException("The date is not valid.");
            }
            
            if (this.GetAge(id) < 16)
            {
                throw new ArgumentOutOfRangeException("The student must be greater than 16 years.");
            }
            this.id = id;
        }

        public int GetAge(string id)
        {
            int age;
            DateTime currentDate = DateTime.Now;

            age = currentDate.Year - birthDate.Year;

            if ((currentDate.Month < birthDate.Month) || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }

        public void PrintData()
        {
            try
            {
                Console.WriteLine("ID = {0}", this.id);
                Console.WriteLine("Name = {0} {1} {2}", this.firstName, this.secondName, this.lastName);
                Console.WriteLine("FacNum = {0}", this.facultyNumber);
                Console.WriteLine("Age = {0}", this.GetAge(this.id));

                for (int i = 0; i < this.mark.Length; i++)
                {
                    Console.WriteLine("mark{0} = {1}", i, this.mark[i]);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static int StudentObjectCounter()
        {
            return Student.count;
        }
    }
}
