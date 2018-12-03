using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZingMP3_buildproject.Model.Object
{
    public class SingObject : CategoryObject
    {
        private int sing_id;
        private int sing_category_id;
        private string sing_name;
        private string sing_author;
        private string sing_singer;
        private int sing_listened;
        private string sing_created_date;
        private bool sing_focus;
        private string sing_content;
        private string sing_path_mp3;
        private int sing_time;
        private bool sing_dowloaded;
        private bool sing_national;


        public int getSing_id()
        {
            return this.sing_id;
        }
        public void setSing_id(int sing_id) 
        {
            this.sing_id = sing_id;
        }

        public int getSing_category_id()
        {
            return this.sing_category_id;
        }
        public void setSing_category_id(int sing_category_id)
        {
            this.sing_category_id = sing_category_id;
        }


        public string getSing_name()
        {
            return this.sing_name;
        }
        public void setSing_name(string sing_name)
        {
            this.sing_name = sing_name;
        }

        public string getSing_author()
        {
            return this.sing_author;
        }
        public void setSing_author(string sing_author)
        {
            this.sing_author = sing_author;
        }

        public string getSing_singer()
        {
            return this.sing_singer;
        }
        public void setSing_singer(string sing_singer)
        {
            this.sing_singer = sing_singer;
        }


        public int getSing_listened()
        {
            return this.sing_listened;
        }
        public void setSing_listened(int sing_listened)
        {
            this.sing_listened = sing_listened;
        }

        public string getSing_created_date()
        {
            return this.sing_created_date;
        }
        public void setSing_created_date(string sing_created_date)
        {
            this.sing_created_date = sing_created_date;
        }

        public bool getSing_focus()
        {
            return this.sing_focus;
        }
        public void setSing_focus(bool sing_focus)
        {
            this.sing_focus = sing_focus;
        }

        public string getSing_content()
        {
            return this.sing_content;
        }
        public void setSing_content(string sing_content)
        {
            this.sing_content = sing_content;
        }

        public string getSing_path_mp3()
        {
            return this.sing_path_mp3;
        }
        public void setSing_path_mp3(string sing_path_mp3)
        {
            this.sing_path_mp3 = sing_path_mp3;
        }

        public int getSing_time()
        {
            return this.sing_time;
        }
        public void setSing_time(int sing_time)
        {
            this.sing_time = sing_time;
        }

        public bool getSing_dowloaded()
        {
            return this.sing_dowloaded;
        }
        public void setSing_dowloaded(bool sing_dowloaded)
        {
            this.sing_dowloaded = sing_dowloaded;
        }

        public bool getSing_national()
        {
            return this.sing_national;
        }
        public void setSing_national(bool sing_national)
        {
            this.sing_national = sing_national;
        }

    }
}
