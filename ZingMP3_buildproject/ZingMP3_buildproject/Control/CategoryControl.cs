using ZingMP3_buildproject.Model;
using ZingMP3_buildproject.Model.Object;
using System.Data;
using System.Collections.Generic;



namespace ZingMP3_buildproject.Control
{
    class CategoryControl
    {
        CategoryModel cm = new CategoryModel();
        public void addCategory(CategoryObject item)
        {
            cm.addCategory(item);
        }
        public void editCategory(CategoryObject item)
        {
            cm.editCategory(item);
        }
        public void dellCategory(CategoryObject item)
        {
            cm.delCategory(item);
        }

        public CategoryObject getCategory(int Category_id)
        {

            CategoryObject item = null;

            DataTableReader dt = cm.getCategory(Category_id).CreateDataReader();

            if (dt.Read())
            {
                item = new CategoryObject();
                item.setCategory_id(dt.GetInt32(0));
                item.setCategory_name(dt.GetString(1));
            }

            return item;
        }
        public List<CategoryObject> getCategorys()
        {
            List<CategoryObject> items = new List<CategoryObject>();

            CategoryObject item = null;
            DataTableReader dt = cm.getCategorys().CreateDataReader();

            while (dt.Read())
            {
                item = new CategoryObject();
                item.setCategory_id(dt.GetInt32(0));
                item.setCategory_name(dt.GetString(1));

                items.Add(item);

            }

            return items;
        }
    }
}
