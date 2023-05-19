using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.VO
{
    public class Student
    {

        //Classe é um conjunto de objetos
        private int id;
        private string studentName;
        private string miniCurriculum;
        private string hobby;
        private string ar;
        private string classCode;



        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }



        public void SetStudentName(string studentName)
        {
            this.studentName = studentName;
        }
        public string GetStudentName()
        {
            return this.studentName;
        }



        public void SetMiniCurriculum(string miniCurriculum)
        {
            this.miniCurriculum = miniCurriculum;
        }
        public string GetMiniCurriculum()
        {
            return this.miniCurriculum;
        }



        public void SetHobby(string hobby)
        {
            this.hobby = hobby;
        }
        public string GetHobby()
        {
            return this.hobby;
        }



        public void SetAr(string ar)
        {
            this.hobby = ar;
        }
        public string GetAr()
        {
            return this.ar;
        }



        public void SetClassCode(string classCode)
        {
            this.classCode = classCode;
        }
        public string GetClassCode()
        {
            return this.classCode;
        }



    }
}
