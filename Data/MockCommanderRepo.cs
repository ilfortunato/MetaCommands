using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo="Cozinhar ovo", Line="Ferva água", Platform="Cozinha"},
                new Command {Id=1, HowTo="Cortar pão", Line="Usar faca", Platform="Faca e cozinha?"},
                new Command {Id=2, HowTo="Fazer chá", Line="Colocar a bolsinha de chá", Platform="Na xícara"},
            };

            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command {Id=0, HowTo="Boil and egg", Line="Boil water", Platform="Kettle & None"};
        }
    }
}
