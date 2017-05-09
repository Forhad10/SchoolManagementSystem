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
  public class studentdata
    {
        DataAccess dataAccess = new DataAccess();
       
     public void insert(string CLASS,int ID,string NAME,int CONTACTNO,string ADDRESS,int AGE,string REGISTER,string GENDER,string FATHER,string MOTHER,int CONTACT)
        {
            DataClasses1DataContext LINQ = new DataClasses1DataContext();
            rslt RESULT = new rslt();
       
            RESULT.s_id = ID;
            RESULT.r_id = ID;


            student_info std = new student_info();
            std.s_class = CLASS;
            std.id = ID;
            std.name = NAME;
            std.contactno = CONTACTNO;
            std.address = ADDRESS;
            std.age = AGE;
            std.register = REGISTER;
            std.gender = GENDER;
            std.father = FATHER;
            std.mother = MOTHER;
            std.contact = CONTACT;

          
            LINQ.rslts.InsertOnSubmit(RESULT);
            LINQ.student_infos.InsertOnSubmit(std);
            LINQ.SubmitChanges();


        }


        public void updateResult( int ID, int MATH, int ENGLISH, int BANGLA, int SCIENCE, int TOTAL_MARK)
        {
            DataClasses1DataContext studentUpdate = new DataClasses1DataContext();

           rslt RESULT = studentUpdate.rslts.Single(rslt => rslt.r_id == ID);
        
            RESULT.math = MATH;
            RESULT.english = ENGLISH;
            RESULT.bangla = BANGLA;
            RESULT.science = SCIENCE;
            RESULT.total_mark = TOTAL_MARK;

            studentUpdate.SubmitChanges();
        }

        public void updatePayment(int IDD, int AMMOUNT, int PAID, int PAYABLE)
        {
            DataClasses1DataContext studentUpdate = new DataClasses1DataContext();

            student_info student = studentUpdate.student_infos.Single(student_info => student_info.id == IDD);

            
            student.amount = AMMOUNT;
            student.paid = PAID;
            student.payable = PAYABLE;
          studentUpdate.SubmitChanges();

        }

        public void ResetPayment(string CLASS, int AMMOUNT, int PAID, int PAYABLE)
        {
            DataClasses1DataContext studentUpdate = new DataClasses1DataContext();

           

                var StudentTable = studentUpdate.student_infos;
                foreach (student_info student in StudentTable)
            {
               if (student.s_class == CLASS)
                {
                    student.amount = AMMOUNT;
                    student.paid = PAID;
                    student.payable = PAYABLE;
                }
          }
                studentUpdate.SubmitChanges();

          }

        public void deltec(int ID)
        {

            DataClasses1DataContext studentDelete = new DataClasses1DataContext();

            rslt RESULT = studentDelete.rslts.Single(rslt => rslt.s_id == ID);
            studentDelete.rslts.DeleteOnSubmit(RESULT);


            student_info objCourse = studentDelete.student_infos.Single(student_info => student_info.id == ID);

            studentDelete.student_infos.DeleteOnSubmit(objCourse);

            studentDelete.SubmitChanges();

        }

        public void update(string CLASS, int ID, string NAME, int CONTACTNO, string ADDRESS, int AGE, string REGISTER, string GENDER, string FATHER, string MOTHER, int CONTACT)
        {
            DataClasses1DataContext studentUpdate = new DataClasses1DataContext();

            student_info stdt = studentUpdate.student_infos.Single(student_info => student_info.id == ID);

            stdt.s_class = CLASS;

            stdt.name = NAME;
            stdt.contactno = CONTACTNO;
            stdt.address = ADDRESS;
            stdt.age = AGE;
            stdt.register = REGISTER;
            stdt.gender = GENDER;
            stdt.father = FATHER;
            stdt.mother = MOTHER;
            stdt.contact = CONTACT;

            studentUpdate.SubmitChanges();

        }

       public DataTable showStudent()
        {
            string SQL = " select student_info.s_class CLASS,student_info.id ID,student_info.name NAME,student_info.contactno 'CONTACT NO',student_info.address ADDRESS,student_info.age AGE,student_info.register REGISTER,student_info.gender GENDER,student_info.father FATHER,student_info.mother MOTHER,student_info.contact CONTACT FROM student_info";
            SqlCommand command = new SqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }

       public DataTable showStudentResult(string CLS)
       {

           string SQL = " select student_info.s_class CLASS,student_info.name NAME,student_info.id ID,rslt.math MATH,rslt.english ENGLISH,rslt.bangla BANGLA,rslt.science SCIENCE,rslt.total_mark 'TOTAL MARK' from student_info,rslt where student_info.id=rslt.s_id and student_info.s_class='" + CLS + "' ";
           SqlCommand command = new SqlCommand(SQL);
           DataTable dt = dataAccess.Query(command);
           return dt;

       }

       public DataTable showStudentPayment(string CLS_ID)
       {

           string SQL = " select student_info.s_class CLASS,student_info.name NAME,student_info.id ID,student_info.amount AMMOUNT,student_info.paid PAID,student_info.payable PAYABLE from student_info where  student_info.id ='" + CLS_ID + "' ";
           SqlCommand command = new SqlCommand(SQL);
           DataTable dt = dataAccess.Query(command);
           return dt;

       }
      
     
 }
}
