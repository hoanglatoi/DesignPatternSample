using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral
{
    class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class Remote
    {
        private readonly ICommand turnOnCommand;
        private readonly ICommand turnOffCommand;

        public Remote(ICommand turnOnCommand, ICommand turnOffCommand)
        {
            this.turnOnCommand = turnOnCommand;
            this.turnOffCommand = turnOffCommand;
        }

        public void TurnOnButtonClick()
        {
            turnOnCommand.Execute();
        }

        public void TurnOffButtonClick()
        {
            turnOffCommand.Execute();
        }
    }

    class TurnOffCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.TurnOff();
        }

        public void Undo()
        {
            fan.TurnOn();
        }
    }

    class TurnOnCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOnCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.TurnOn();
        }

        public void Undo()
        {
            fan.TurnOff();
        }
    }



}
