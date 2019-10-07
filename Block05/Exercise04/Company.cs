using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExercise
{
    public class Company : IEnumerable<Employee>
    {
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
        public Dictionary<string, Employee> Employees { get; set; }

        public void FillCollection()
        {
            Developer dev = new Developer();
            dev.Name = "John";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C++";
            employees.Add(dev.Name, dev);

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Paul"; //Not mention Role and PreferredLanguage, it will copy above
            employees.Add(devCopy.Name, devCopy);

            Typist typist = new Typist();
            typist.Name = "Elisabeth";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;
            employees.Add(typist.Name, typist);

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Mark";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above
            employees.Add(typistCopy.Name, typistCopy);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            foreach (KeyValuePair<string, Employee> element in employees)
                yield return element.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
