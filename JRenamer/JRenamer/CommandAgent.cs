﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    /// <summary>
    /// Agent class that manages and executes the commands, following the Command pattern.
    /// If you need events (ex. for UI refresh) when data is changed on the commands, then do NOT
    /// use the Commands List directly (add, remove, etc.) and use the methods in this class instead
    /// as a "PropertyChanged" event is fired.
    /// This way you can set any implementation of IList in the Commands and still get notifications of data changes.
    /// </summary>
    public class CommandAgent : INotifyPropertyChanged
    {
        private IList<ICommand> commandQueue = new List<ICommand>();

        public event PropertyChangedEventHandler PropertyChanged;

        // OnPropertyChanged will raise the PropertyChanged event passing the
        // source property that is being updated.
        private void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public IList<ICommand> Commands
        {
            get { return commandQueue; }
            set
            {
                commandQueue = value;
                NotifyPropertyChanged();
            }
        }

        public DirectoryFileName Execute(string fileNameFull)
        {
            return Execute(new DirectoryFileName(fileNameFull));
        }

        public DirectoryFileName Execute(DirectoryFileName directoryFileName)
        {
            IEnumerator<ICommand> enumerator = Commands.GetEnumerator();
            while(enumerator.MoveNext())
            {
                directoryFileName = enumerator.Current.Execute(directoryFileName);
            }

            return directoryFileName;
        }

        public DirectoryFileName ExecuteAndRemoveAll(DirectoryFileName fileNameFull)
        {
            fileNameFull = Execute(fileNameFull);
            Clear();

            return fileNameFull;
        }

        public void Clear()
        {
            Commands.Clear();
            NotifyPropertyChanged();
        }

        public void MoveUp(int pos)
        {
            if (commandQueue == null || commandQueue.Count <= 1 || pos < 1)
                return;

            ICommand aux = Commands[pos];
            Commands[pos] = Commands[pos - 1];
            Commands[pos - 1] = aux;

            NotifyPropertyChanged();
        }

        public void MoveDown(int pos)
        {
            if (commandQueue == null || commandQueue.Count <= 1
                || pos < 0 || pos > (commandQueue.Count - 2))
                return;

            ICommand aux = Commands[pos];
            Commands[pos] = Commands[pos + 1];
            Commands[pos + 1] = aux;

            NotifyPropertyChanged();
        }

        public void RemoveAt(int pos)
        {
            if (Commands != null && pos >= 0 && pos < Commands.Count)
            {
                Commands.RemoveAt(pos);
                NotifyPropertyChanged();
            }
        }

        public void Add(ICommand command)
        {
            if (command != null)
            {
                Commands.Add(command);
                NotifyPropertyChanged();
            }
        }

        public void Insert(int index, ICommand command)
        {
            if (command != null)
            {
                Commands.Insert(index, command);
                NotifyPropertyChanged();
            }
        }
    }
}
