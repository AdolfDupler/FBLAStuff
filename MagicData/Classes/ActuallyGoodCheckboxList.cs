using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicData.Classes
{
    public sealed class ActuallyGoodCheckboxList:CheckedListBox
    {
        public ActuallyGoodCheckboxList()
        {
            ItemHeight = 30;
        }
        public override int ItemHeight
        {
            get
            {
                return base.ItemHeight;
            }

            set
            {
                base.ItemHeight = value;
            }
        }
    }
}
