using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeam
{
    public class League

    {
        private List<Team> teams;
        
        public League()
        {
            teams = new List<Team>();


        }
        public List<Team> TopTeams(int Topcount)
        {
            List<Team> copyTeam = new List<Team>();
            for (int i = 0; i < teams.Count; i++)
            {
                copyTeam.Add(teams[i]);
            }
            for (int i = 0; i <= copyTeam.Count; i++)
            {
                for (int j = i + 1; j < copyTeam.Count; j++)
                {
                    if (copyTeam[i].points_ < copyTeam[j].points_)
                    {
                        Team team = copyTeam[i];
                        copyTeam[i] = copyTeam[j];
                        copyTeam[j] = team;
                    }
                }
            }

            List<Team> result = new List<Team>();
            for (int i = 0; i < Topcount && i < copyTeam.Count; i++)
            {
                result.Add(copyTeam[i]);
            }
            return result;
        }

        public List<Team> AddTeam(string name, int score, int goals)
        {
            teams.Add(new Team(name, score, goals));
            return teams;
        }
    }
}
