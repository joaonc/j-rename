using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    class CommandRemoveByPosition : ICommand
    {
        public enum Direction
        {
            Forward,
            Backward
        }

        private string description;
        private int startIndex, nrOfCharacters;
        private string textFound;
        private Direction direction;
        private CommandApplyTo applyTo;

        /// <summary>
        /// Removes the specified number of characters in the position defined by startIndex and endIndex.
        /// </summary>
        /// <param name="startIndex">Where to start removing characters. Base 0.</param>
        /// <param name="direction">Which direction the removal of characters goes.</param>
        /// <param name="nrOfCharacters">The number of characters to remove. 0 to make it until the end/beginning.</param>
        /// <param name="textFound">The text at which to stop removing characters. Null or empty to not search for text to stop.</param>
        /// <param name="applyTo">Whether the removal of characters applies only to the filename or only to the extension or both.
        ///                       In order to apply to both, two separate commands need to be issued.</param>
        public CommandRemoveByPosition(int startIndex, Direction direction, int nrOfCharacters, string textFound = "", CommandApplyTo applyTo = CommandApplyTo.Filename)
        {
            if (IsUntilBeginningOrEnd())
                description = string.Format("Remove characters starting at {0} until {1}",
                    startIndex,
                    direction == Direction.Forward ? "the end" : "the beginning");
            else
                description = string.Format("Remove {0} character{1} {2} starting at {3}",
                    nrOfCharacters,
                    nrOfCharacters == 1 ? "" : "s",
                    direction == Direction.Forward ? "forwards" : "backwards",
                    startIndex);

            if (!string.IsNullOrEmpty(textFound))
            {
                description += string.Format(" or the text \"{0}\" is found, whichever comes first", textFound);
            }

            description += string.Format(" applying to {0}",
                applyTo == CommandApplyTo.Filename ? "the filename" : "the extension");

            this.startIndex = startIndex;
            this.nrOfCharacters = nrOfCharacters;
            this.direction = direction;
            this.textFound = textFound;
            this.applyTo = applyTo;
        }

        public string Description
        {
            get { return description; }
        }

        public override string ToString()
        {
            return Description;
        }

        private bool IsUntilBeginningOrEnd()
        {
            return nrOfCharacters < 1;
        }

        public DirectoryFileName Execute(DirectoryFileName directoryFileName)
        {
            string text = applyTo == CommandApplyTo.Filename ? directoryFileName.FileNameWithoutExtension : directoryFileName.Extension;

            return new DirectoryFileName(
                directoryFileName.DirectoryName,
                applyTo == CommandApplyTo.Filename ? text + "." + directoryFileName.Extension : directoryFileName + "." + text);
        }
    }
}
