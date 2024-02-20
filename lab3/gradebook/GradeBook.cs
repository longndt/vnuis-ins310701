using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    internal class GradeBook
    {
        //private: only accessible inside current class
        private string university;    

        //public: accessible everywhere (outside class)
        //auto-implemented properties (auto getters & setters)
        public string Name { get; set; }
        public double Grade { get; set; }


        //empty constructor - parameterless constructor
        //Note: if we forgot to declare this constructor
        //C# will automatic create for us
        //public GradeBook() { }

        public GradeBook (string university)
        {
            //this.university = university;
            setUniversityName(university);
        }

        public void setUniversityName (string university)
        {
            this.university = university;
        }

        public String getUniversityName ()
        {
            return this.university;
        }
    }
}
