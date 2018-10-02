using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_Engineer_Chief
{
    interface IWorker
    {
        string[] FullName { get; set; }//ФИО
        string Position { get; set; }//должность
        int Salary { get; set; }//зп
        void Work();
        void GetSalary();
    }
}
