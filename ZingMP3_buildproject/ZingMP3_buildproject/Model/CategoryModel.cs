using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZingMP3_buildproject.Model.Object;
using System.Data;

namespace ZingMP3_buildproject.Model
{
    class CategoryModel
    {
        public void addCategory(CategoryObject item)
        {
            string sql = "INSERT INTO tblcategory(category_name)"
                 +" VALUES ('"+item.getCategory_name()+"');";

            Connection.ExcuteNonQuery(sql);
        }
        public void editCategory(CategoryObject item)
        {
            string sql = "UPDATE tblcategory SET category_name = '"+item.getCategory_name()
                +"' WHERE sing_id = '"+item.getCategory_id()+"';";

            Connection.ExcuteNonQuery(sql);
        }
        public void delCategory(CategoryObject item)
        {
            string sql = "DELETE FROM tblcategory WHERE category_id = '" + item.getCategory_id() + "';";
        }



        public DataTable getCategory(int category_id)
        {
            String sql = "SELECT * FROM tblcategory "
                +"WHERE category_id = '"+category_id+"'";
            DataTable dt = new DataTable();
            dt = Connection.getTable(sql);

            return dt;
        }
        public DataTable getCategorys()
        {
            String sql = "SELECT * FROM tblcategory ";
           
            
            //sql += " LIMIT " + limit + ";";
            DataTable dt = new DataTable();
            dt = Connection.getTable(sql);

            return dt;
        }
    }
    
}
