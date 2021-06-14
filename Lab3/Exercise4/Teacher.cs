using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine($"Explanation {subject} begins");
        }

        public void SetSubject(string subject)
        {
            this.subject = subject;
        }
    }
}
