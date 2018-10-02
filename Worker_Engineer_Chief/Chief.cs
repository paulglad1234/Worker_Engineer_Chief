using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_Engineer_Chief
{
    class Chief : Engineer
    {
        public List<IWorker> subordinates;//подчиненные
        //честно говоря, я не знаю, чем еще руководитель принципиально отличается от обычного работника
        //так что, учитывая, что в этом проекте и так уже много воды, а этот класс я пишу последним, так что
        //надеюсь, что задача будет принята и так

        public Chief(string surname, string name, string patronymic, int salary,
            List<IWorker> workers)// предположим, список подчиненных известен заранее
        :base(surname, name, patronymic, salary, "Руководитель"){ subordinates = workers; }

        public override void Work()
        { 
            //руководитель руководит!
        }
        public void Recruit(IWorker worker)//принять кого-то на работу
        {
            subordinates.Add(worker);
        }
        public void Fire(IWorker worker)//уволить кого-то
        {
            subordinates.Remove(worker);
        }
        
    }
}
