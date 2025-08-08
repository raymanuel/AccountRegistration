using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    public class StudentInfoClass
    {
        public delegate string DelegateText(string text);

        public delegate long DelegateNum(long number);    

        //texts
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";

        //numbers
        public static long Age = 0;
        public static long ContactNumber = 0;
        public static long StudentNumber = 0;

        public static string GetFirstName(string firstname) => firstname;
        public static string GetLastName(string lastname) => lastname;
        public static string GetMiddleName(string middlename) => middlename;
        public static string GetAddress(string address) => address;
        public static string GetProgram(string program) => program;
        public static long GetAge(long age) => age;
        public static long GetContactNumber(long contactnumber) => contactnumber;
        public static long GetStudentNumber(long studentnumber) => studentnumber;






    }
}
