// -----------------------------------------------------------------------
// <copyright file="Scoreboard.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Tutorial1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Scoreboard
    {
        private readonly List<TeamScoreBoard> teams = new List<TeamScoreBoard>();

        public void AddTeam(List<Character> teamMembers)
        {
            teams.Add(new TeamScoreBoard(this.GetNext(), teamMembers));
        }

        public Position GetNext()
        {
            return new Position(teams.Count * 7, 5);
        }

        public void UpdateBoard()
        {
            foreach (var team in teams)
            {
                team.Render();
            }
        }
    }

    public class TeamScoreBoard
    {
        public TeamScoreBoard(Position position, List<Character> teamMembers)
        {
            Position = position;
            TeamMembers = teamMembers;
        }

        public Position Position { get; private set; }

        public List<Character> TeamMembers { get; private set; }

        public void Render()
        {
            Console.SetCursorPosition(Position.Left, Position.Top);
            Console.Write("Team score");
            var teamMemberIndex = 0;
            foreach (var teamMember in TeamMembers)
            {
                teamMemberIndex++;
                Console.SetCursorPosition(Position.Left, Position.Top + teamMemberIndex);
                Console.Write("{0}: {1}", teamMember.Name, teamMember.Health);
            }
        }
    }


    public class Position
    {
        public Position(int top, int left)
        {
            Top = top;
            Left = left;
        }

        public int Top { get; private set; }

        public int Left { get; private set; }
    }
    
}
