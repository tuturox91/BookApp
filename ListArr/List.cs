using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArr
{
    class Lists
    {
        public int Data { get; set; }

        

        public Lists FristItem { get; set; } = null;
        public Lists SecondItem { get; set; } = null;

        public  Lists(ref Lists add, int data)
        {
            //Lists newList = new Lists(data, add);
            //add.SecondItem = newList;
        }
        public Lists(int data, ref Lists firstlist) { Data = data; FristItem = firstlist; firstlist.SecondItem = this; }

        public Lists(int data) { Data = data; }



        public void Add()
        {

        }
    }
}
