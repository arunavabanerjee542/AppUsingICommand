using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppUsingICommand
{
    class ViewModel
    {
        public ObservableCollection<string> collectionOfMessage { get; set; }
        public MyCommand MessageCommand { get; set; }
        public MyCommand ConsoleCommand { get; set; }

        public ViewModel()
        {
            MessageCommand = new MyCommand(CanMessageCommandExecute,ExecuteMessageCommand);
            ConsoleCommand = new MyCommand(CanConsoleCommandExecute,ExecuteConsoleCommand);

            collectionOfMessage = new ObservableCollection<string>()
            {
                "HI I AM ARUNAVA BANERJEE",
                "HI I AM A COMPETITIVE PROGRAMMER",
                "ONLY MESSAGE BOX CONTENT",
                "ONLY CONSOLE CONTENT"

            };

        }


        public bool CanMessageCommandExecute(object o)
        {
            string oo = (string)o;
            if(oo == null || string.IsNullOrEmpty(oo))
            {
                return false;
            }
            if(oo.Equals("ONLY CONSOLE CONTENT"))
            {
                return false;
            }
            return true;

        }

        public void ExecuteMessageCommand(object o)
        {
            MessageBox.Show((string)o);
        }

        public bool CanConsoleCommandExecute(object o)
        {
            string oo = (string)o;
            if (oo == null || string.IsNullOrEmpty(oo))
            {
                return false;
            }
            if (oo.Equals("ONLY MESSAGE BOX CONTENT"))
            {
                return false;
            }
            return true;

        }

        public void ExecuteConsoleCommand(object o)
        {
            Console.WriteLine((string)o);
        }










    }
}
