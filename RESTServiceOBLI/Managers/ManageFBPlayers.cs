using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NFL2021.Model;

namespace RESTServiceOBLI.Managers
{
    public class ManageFbPlayers : IManageFbPlayers
    {
        public bool Create(FootBallPlayer value)
        {
            _footBallPlayers.Add(value);
            return true;
        }

        public FootBallPlayer Delete(int id)
        {
            FootBallPlayer footBallPlayer = Get(id);
            _footBallPlayers.Remove(footBallPlayer);
            return footBallPlayer;
        }

        public IEnumerable<FootBallPlayer> Get()
        {
            return new List<FootBallPlayer>(_footBallPlayers);
        }

        public FootBallPlayer Get(int id)
        {
            return _footBallPlayers.Find(f => f.Id == id);
        }

        public bool Update(int id, FootBallPlayer value)
        {
            FootBallPlayer footBallPlayers = Get(id);
            if (footBallPlayers != null)
            {
                footBallPlayers.Id = value.Id;
                footBallPlayers.Name = value.Name;
                footBallPlayers.Price = value.Price;
                footBallPlayers.ShirtNumber = value.ShirtNumber;

                return true;
            }

            return false;
        }

        // Static list for objects
        private static List<FootBallPlayer> _footBallPlayers = new List<FootBallPlayer>()
        {
            new FootBallPlayer(1,"Mike Johnson", 10, 1),
            new FootBallPlayer(2,"John Doe", 7, 2),
            new FootBallPlayer(3,"Mike Wasowski", 24, 3 ),
            new FootBallPlayer(4,"Tom Brady", 1, 4 )

        };
    }
}
