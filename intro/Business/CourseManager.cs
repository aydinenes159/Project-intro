using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business
{
    public class CourseManager
    {
        Course[] courses =new Course[3];
        //constructor
        public CourseManager()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "c#";
            course1.Description = ".Net 8 vs ....";
            course1.price = 0;

            Course course2 = new Course();
            course2.Id = 1;
            course2.Name = "Java";
            course2.Description = "java 17 ....";
            course2.price = 10;

            Course course3 = new Course();
            course3.Id = 1;
            course3.Name = "Python";
            course3.Description = "Python 3.12 .....";
            course3.price = 20;

            courses[0] = course1;
            courses[1] = course2;
            courses[2] =  course3;

            

        }


        public Course[] GetAll()
        {   

            return courses;
        }



        


    }
}
