using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.Commands
{
    public class CommandHandler
    {
        public Stack<Command> commands= new Stack<Command>();

        public void invoke (Command command)
        {
            command.execute();
            commands.Push(command);
        }

        public bool undo()
        {
            if(commands.Peek() is Revertable)
            {
                Revertable revertable = (Revertable)commands.Pop();
                revertable.undo();
                return true;
            }
            return false;
        }
    }
}
