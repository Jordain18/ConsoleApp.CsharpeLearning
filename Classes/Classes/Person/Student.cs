using Classes.Utils;
using System.Security.Cryptography;

namespace Classes.Classes.Person
{
    public class Student : Person
    {
        public void GenerateStudentIDNumber()
        {
            _idNumber = PersonHelper.GenerateNumber("STU");
        }

    }
}
