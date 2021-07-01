using CommandDemo.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandDemo.ViewModels
{
    public class MessageViewModel
    {
        public ObservableCollection<string> messages { get; private set; }

        public RelayCommand MessageBoxCommand { get; private set; }
        public RelayCommand ConsoleLogCommand { get; private set; }

        public MessageViewModel()
        {
            messages = new ObservableCollection<string>()
            {
                "Message Box",
                "Hello world",
                "Hello Laptop",
                "Console Log"
            };

            MessageBoxCommand = new RelayCommand(DisplayMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new RelayCommand(DisplayConsoleBox, ConsoleCanUse);
        }

        public void DisplayMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }

        public void DisplayConsoleBox(object message)
        {
            MessageBox.Show((string)message);
        }

        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "Console Log")
                return false;

            return true;
        }

        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "Message Box")
                return false;

            return true;
        }

    }
}