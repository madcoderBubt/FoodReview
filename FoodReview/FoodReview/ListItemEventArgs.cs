using System;
using System.Collections.Generic;
using System.Text;

namespace FoodReview
{
    class ListItemEventArgs : EventArgs
    {
        public Object MyItem { get; set; }
        public ListItemEventArgs(Object item)
        {
            this.MyItem = item;
        }
    }
}
