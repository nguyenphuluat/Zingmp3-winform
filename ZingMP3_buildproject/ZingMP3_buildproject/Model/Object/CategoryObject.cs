using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZingMP3_buildproject.Model.Object
{
    public class CategoryObject
    {
        private int category_id;
        private string category_name;

        
        public int getCategory_id(){
           return this.category_id;
        }
        public void setCategory_id(int category_id)
        {
            this.category_id = category_id;
        }

        public string getCategory_name()
        {
            return this.category_name;
        }
        public void setCategory_name(string category_name)
        {
            this.category_name = category_name;
        }

    }
}
