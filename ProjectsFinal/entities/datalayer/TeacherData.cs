using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using framework;
using entities;

namespace datalayer
{
   public  class TeacherData
    {

      public DataAccess dataAccess = new DataAccess();
        public void insertTeacher( int ID, string NAME, int CONTACTNO, string ADDRESS, int AGE, string TYPE, string GENDER , int SALARY)
        {
            DataClasses1DataContext LINQ = new DataClasses1DataContext();
            teacher_information TEACHER = new teacher_information();

            TEACHER.teacher_id = ID;
            TEACHER.teacher_name = NAME;
            TEACHER.teacher_address = ADDRESS;
            TEACHER.teacher_phone = CONTACTNO;
            TEACHER.teacher_type = TYPE;
            TEACHER.teacher_gender = GENDER;
            TEACHER.teacher_age = AGE;
          
            LINQ.teacher_informations.InsertOnSubmit(TEACHER);
            LINQ.SubmitChanges();


        }

        public void DelteTeacher(int ID)
        {

            DataClasses1DataContext teacherDelete = new DataClasses1DataContext();

            teacher_information TEACHER = teacherDelete.teacher_informations.Single(teacher_information => teacher_information.teacher_id == ID);
            teacherDelete.teacher_informations.DeleteOnSubmit(TEACHER);



            teacherDelete.SubmitChanges();

        }

        public void updateTeacher(int ID, string NAME, int CONTACTNO, string ADDRESS, int AGE, string TYPE, string GENDER, int SALARY)
        {
            DataClasses1DataContext TeacherUpdate = new DataClasses1DataContext();

            teacher_information Teacher = TeacherUpdate.teacher_informations.Single(teacher_information => teacher_information.teacher_id == ID);

            Teacher.teacher_id = ID;
            Teacher.teacher_name = NAME;
            Teacher.teacher_address = ADDRESS;
            Teacher.teacher_phone = CONTACTNO;
            Teacher.teacher_type = TYPE;
            Teacher.teacher_gender = GENDER;
            Teacher.teacher_age = AGE;
            //Teacher.teacher_salary = SALARY;

            TeacherUpdate.SubmitChanges();

        }

        public void ResetTeacherPayment(string TYPE, int AMMOUNT)
        {
            DataClasses1DataContext teachertUpdate = new DataClasses1DataContext();



            var TeacherTable = teachertUpdate.teachers_salaries;
            foreach (teachers_salary teacher in TeacherTable)
            {
                teachers_salary t = teachertUpdate.teachers_salaries.FirstOrDefault(teachers_salary => teachers_salary.type == TYPE);

                if (teacher.type == TYPE)
                {
                    teacher.salary = AMMOUNT;

                }
            }
            teachertUpdate.SubmitChanges();

        }

        public DataTable showTeacher()
        {
            string SQL = " select teacher_information.teacher_id ID,teacher_information.teacher_name NAME,teacher_information.teacher_address ADDRESS,teacher_information.teacher_phone PHHONE,teacher_information.teacher_type 'TEACHER TYPE',teacher_information.teacher_gender GENDER,teacher_information.teacher_age AGE from teacher_information";
            SqlCommand command = new SqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }

       

        public DataTable showTeacherPayment()
        {

            string SQL = " select teacher_information.teacher_id ID, teacher_information.teacher_name NAME , teachers_salary.type TYPE , teachers_salary.salary SALARY from teacher_information,teachers_salary where teacher_information.teacher_type = teachers_salary.type ";
            SqlCommand command = new SqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }

        public DataTable ShowTypeSalary()
        {

            string SQL = " select * from teachers_salary";
            SqlCommand command = new SqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }

        
    }


}
