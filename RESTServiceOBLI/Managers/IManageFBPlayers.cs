using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NFL2021.Model;

namespace RESTServiceOBLI.Managers
{
    interface IManageFbPlayers
    {
        IEnumerable<FootBallPlayer> Get();
        FootBallPlayer Get (int id);
        bool Create(FootBallPlayer value);
        bool Update(int id, FootBallPlayer value);
        FootBallPlayer Delete(int id);
    }
}
