using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    internal class OCP1
    {
    }

    public enum CricketerRole
    {
        WicketKeeper, //added
        Fielder,
        Batsman,
        Bowler
    }

    public interface ICricketer
    {
        int GetPlayers(int totalPlayers);
    }

    public class Fielder : ICricketer
    {
        public int GetPlayers(int totalPlayers)
        {
            return totalPlayers - (totalPlayers - 2);
        }
    }

    public class Batsman : ICricketer
    {
        public int GetPlayers(int totalPlayers)
        {
            return totalPlayers - (totalPlayers - 7);
        }
    }

    public class Bowler : ICricketer
    {
        public int GetPlayers(int totalPlayers)
        {
            return totalPlayers - (totalPlayers - 4);
        }
    }

    public class WicketKeeper : ICricketer  //If new role is added we will extend interface, not changing any class
    {
        public int GetPlayers(int totalPlayers)
        {
            return totalPlayers - (totalPlayers - 2);
        }
    }

    //public class Cricketer
    //{
    //    //2F, 7B, 2WK,4Bwl
    //    public decimal GetPlayers(CricketerRole role, decimal totalPlayers = 15)
    //    {
    //        if (role == CricketerRole.Fielder)
    //        {
    //            return totalPlayers - (totalPlayers - 2); //2 Fielders can be there in 15 squad
    //        }
    //        else if (role == CricketerRole.Batsman)
    //        {
    //            return totalPlayers - (totalPlayers - 7);
    //        }
    //        else if(role== CricketerRole.WicketKeeper) //added which breaks OCP
    //        {
    //            return totalPlayers - (totalPlayers - 2);
    //        }
    //        else
    //        {
    //            return totalPlayers - (totalPlayers - 4); //4 Bowlers
    //        }
    //    }
    //}
}
