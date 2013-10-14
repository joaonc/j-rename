using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    /// <summary>
    /// Item in a drop down.
    /// Consists of its description, which shows up in the UI, and the mask.
    /// </summary>
    public class DropDownItem
    {
        private const string separatorStandard = " | ";

        public string Description { get; set; }
        public List<string> MaskList { get; set; }
        public bool ShowMask { get; set; }

        public DropDownItem(string description, bool showMask, params string[] masks)
        {
            this.Description = description;
            this.MaskList = masks.ToList();
            this.ShowMask = showMask;
        }

        /// <summary>
        /// Returns the description of the item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string description = Description;

            if (ShowMask)
                description += " (" + GetMaskAsString() + ")";

            return description;
        }

        public string GetMaskAsString()
        {
            return GetMaskAsString(separatorStandard);
        }

        public string GetMaskAsString(string separator)
        {
            string maskAsString = "";

            if (MaskList.Count > 0)
            {
                foreach (string mask in MaskList)
                    maskAsString += mask + separator;

                maskAsString = maskAsString.Remove(maskAsString.Length - separator.Length, separator.Length);
            }

            return maskAsString;
        }
    }
}
