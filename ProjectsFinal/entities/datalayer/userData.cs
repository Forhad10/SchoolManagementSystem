using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using framework;
using entities;


namespace datalayer
{
    public class userData
    {

        DataAccess dataAccess = new DataAccess();
        user_information user = new user_information();
        public void insertAdmin(int ID, string NAME, string PASSWORD)
        {
            DataClasses1DataContext LINQ = new DataClasses1DataContext();
            login admin = new login();

            admin.user_id = ID;
            admin.user_name = NAME;
            admin.user_password = PASSWORD;
            

            LINQ.logins.InsertOnSubmit(admin);
            LINQ.SubmitChanges();


        }

        public bool Login(string userName, string password)
        {
            string loginQuery = "SELECT * FROM login WHERE user_name = @NAME AND user_password = @PASSWORD";

            SqlCommand loginCommand = new SqlCommand(loginQuery);

            SqlParameter uNameParam = new SqlParameter("@NAME", SqlDbType.VarChar, 50);
            uNameParam.Value = userName;

            SqlParameter passwordParam = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50);
            passwordParam.Value = password;

            loginCommand.Parameters.Add(uNameParam);
            loginCommand.Parameters.Add(passwordParam);

            DataTable dataTable = dataAccess.Query(loginCommand);

            if (dataTable.Rows.Count > 0) return true;

            return false;
        }

        public DataTable showId()
        {

            string SQL = " select login.user_id 'ADMIN ID',login.user_name USERNAME from login ";
            SqlCommand command = new SqlCommand(SQL);
            DataTable dt = dataAccess.Query(command);
            return dt;

        }

        public void updatePassword(string USERNAME,string PASSWORD,string NEWPASSWORD)
        {
            DataClasses1DataContext passowrdUpdate = new DataClasses1DataContext();

            login log = passowrdUpdate.logins.Single(login => login.user_name == USERNAME);



            log.user_password = NEWPASSWORD;

            passowrdUpdate.SubmitChanges();




        }

        

      


  
    }
}
