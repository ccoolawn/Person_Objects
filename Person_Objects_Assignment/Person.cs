using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Objects_Assignment
{
    class Person
    {
        /*-----=PRIVATE FIELDS=-----*/
        private string _firstname;
        private string _lastname;
        private List<string> _emails = new List<string>();
        private List<string> _cellNums = new List<string>();
        private DateTime _dateOfBirth;

        /*-----=CONSTRUCTOR=-----*/
        public Person(string firstname, string lastname, DateTime dateOfBirth)
        {
            _firstname = firstname;
            _lastname = lastname;
            _dateOfBirth = dateOfBirth;
        }

        /*-----=PROPERTIES=-----*/
        public string Firstname
        { get { return _firstname; } }

        public string Lastname
        { get { return _lastname; } }

        public DateTime DateOfBirth
        { get { return _dateOfBirth; }}

        public string[] EmailsList
        { get { return _emails.ToArray();} }

        public string[] CellNumsList
        { get { return _cellNums.ToArray(); } }


        /*-----=METHODS=-----*/
        public void AddCellPhone(string phone, string phone2)
        {
            if (phone != String.Empty)
            {
                _cellNums.Add(phone);
                _cellNums.Add(phone2);
            }
        }

        public void AddEmail(string email, string email2)
        {
            if (email != String.Empty)
            {
                _emails.Add(email);
                _emails.Add(email2);
            }
        }

        public int GetAge(DateTime bDay)
        {
            DateTime currentDT = DateTime.Now;
            TimeSpan ts = currentDT - bDay;
            int age = ((int)ts.TotalDays) / 365;
            return age;
        }

        public int GetDaysUntilNextBirthday(DateTime birthdate)
        {
            DateTime nextBday = new DateTime(DateTime.Now.Year, birthdate.Month, birthdate.Day);
            if (DateTime.Today > nextBday)
            {
                nextBday = nextBday.AddYears(1);
            }
            return (nextBday - DateTime.Today).Days;
        }

        public void updateCellNum(string newNum)
        {
            if (newNum != String.Empty)
            {
                _cellNums.Add(newNum);
            }
        }

        public void DeleteCellNum(string numDelete)
        {
            int idx = _cellNums.IndexOf(numDelete);
            _cellNums.RemoveAt(idx);
        }

        public void UpdateEmail(string newEmail)
        {
            if (newEmail != String.Empty)
            {
                _emails.Add(newEmail);
            }
        }

        public void RemoveEmail(string emailDelete)
        {
            if (emailDelete != String.Empty)
            {
                int idx = _emails.IndexOf(emailDelete);
                _emails.RemoveAt(idx);
            }
        }
    }
}
