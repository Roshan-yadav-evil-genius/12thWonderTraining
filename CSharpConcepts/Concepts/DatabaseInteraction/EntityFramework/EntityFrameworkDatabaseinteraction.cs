using CSharpConcepts.Concepts.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Concepts
{
    internal class EntityFrameworkDatabaseinteraction
    {
        public void Execute()
        {

            var context = new GameHubEntities();
            var player = new PLAYER
            {
                NAME = "roni",
                PSWD = "123"
            };
            context.PLAYERS.Add(player);
            context.SaveChanges();
        }
    }
}
