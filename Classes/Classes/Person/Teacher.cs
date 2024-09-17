using Classes.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes.Person
{
    public class Teacher : Person
    {
        public void GenerateTeacherIDNumber()
        {
            _idNumber = PersonHelper.GenerateNumber("TCH");
        }
    }
}
