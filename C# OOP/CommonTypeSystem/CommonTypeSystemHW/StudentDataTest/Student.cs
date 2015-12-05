using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentDataTest
{
     public class Student:ICloneable, IComparable<Student>
    {
        //Fields
       
        private string firstName;
        private string middleName;
        private string lastName;
        private string socialSecurityNumber;
        private string address;
        private string mobilePhone;
        private string eMail;
        private int course;
        private University university;
        private Facultity facultity;
        private Speciality speciality;

        //Constructor
        public Student(string firstName, string middleName, string lastName, string socialSecurityNumber, string address,
                       string mobilePhone, string eMail, int course, University university, Facultity facultity, Speciality speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumberc = socialSecurityNumber;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.University = university;
            this.Facultity = facultity;
            this.Speciality = speciality;
        }

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string SocialSecurityNumberc
        {
            get { return this.socialSecurityNumber; }
            set { this.socialSecurityNumber = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                //if ((this.mobilePhone[0] != '0') && (this.mobilePhone.Length !=10))
                //{
                //    throw new ArgumentException("Incorrect mobile number");
                //}
                this.mobilePhone = value;
            }
        }
        public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }
        public int Course
        {
            get { return this.course; }
            set
            {
                //if (course <= 0)
                //{
                //    throw new ArgumentOutOfRangeException("Course can not be <0");
                //}
                this.course = value;
            }
        }
        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public Facultity Facultity
        {
            get { return this.facultity; }
            set { this.facultity = value; }
        }
        public Speciality Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }

        //Overriding standart methods Equal(), GetHeshCode(), String(), operators == and !=
        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }
            if (!Object.Equals(student.firstName, this.firstName) || !Object.Equals(student.middleName, this.middleName) ||
                !Object.Equals(student.lastName, this.lastName) || !Object.Equals(student.socialSecurityNumber, this.socialSecurityNumber))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ course.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Student name is {0} {1} {2}.", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendFormat("Its SSN is {0}, addres {1}.", this.SocialSecurityNumberc, this.Address);
            sb.AppendFormat("Its phone is {0} and email {1}.", this.MobilePhone, this.EMail);
            sb.AppendFormat("This student study in {0}, {1}, {2}. Course - {3}", this.University, this.Facultity, this.Speciality, this.Course);
            return sb.ToString();
        }
        public static bool operator ==(Student student1, Student student2)
        {
            if (student1.FirstName == student2.FirstName && student1.LastName == student2.LastName)
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }
        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }

        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumberc, this.Address,
                this.MobilePhone, this.EMail, this.Course, this.University, this.Facultity, this.Speciality);
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            else if (this.LastName != other.lastName)
            {
               return this.LastName.CompareTo(other.LastName);
            }
            else if (this.SocialSecurityNumberc != other.SocialSecurityNumberc)
            {
                return this.SocialSecurityNumberc.CompareTo(other.SocialSecurityNumberc);
            }
            else
            {
                return 0;
            }
        }
    }
}
