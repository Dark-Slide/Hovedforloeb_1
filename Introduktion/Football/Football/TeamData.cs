using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public  class TeamData
    {
        PlayerData pData = new PlayerData();
        TeamData()
        {
            AddData();
        }
        private void AddData()
        {
            Team t1 = new() { TeamName = "Manchester United" };
            t1.Players.Add(pData.P1);
            t1.Players.Add(pData.P2);
        }
    }
}
