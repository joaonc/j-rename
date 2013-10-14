using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    public class DropDownItemList : List<DropDownItem>
    {
        public DropDownItem FindByDescription(string description)
        {
            return this.Find(
                delegate(DropDownItem item)
                {
                    return item.Description.Equals(description);
                }
            );
        }

        public DropDownItem FindByMask(string mask)
        {
            return this.Find(
                delegate(DropDownItem item)
                {
                    return item.Description.Equals(mask);
                }
            );
        }
    }
}
