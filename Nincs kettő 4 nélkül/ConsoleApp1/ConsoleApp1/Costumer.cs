using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Costumer
    {
        private string _name;
        private int _points;
        private bool _isStudents;

        public string Name { get { return _name; } set { _name = value; } }
        public int Points { get { return _points; } set { _points = value; } }
        public bool IsStudents { get { return _isStudents; } set { _isStudents = value; } }

        public Costumer(string name, bool isstudent)
        {
            _name = name;
            _isStudents = isstudent;
        }
        public void AddPoint(int amount)
        {
            if (IsStudents)
                _points += amount * 2;
            else
                _points += amount;
        }
        public bool HasDiscount()
        {
            return _points >= 10;
        }


    }
}
