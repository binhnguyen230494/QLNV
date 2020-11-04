using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QLNV.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectString = @"Data Source=DESKTOP-OI73O7C;Initial Catalog=QuanLyNhanVien;User ID=sa;Password=860232";
            con = new SqlConnection(connectString);
        }
    }
}
