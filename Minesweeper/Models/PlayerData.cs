using System;

namespace MilestoneFour.Models
{
    /// <summary>
    /// PlayerData class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The model for the player data.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/31/19
    /// Version:    1.0
    /// </remarks>
    public class PlayerData : IComparable
    {
        // public members
        public string Name { get; set; }
        public long TimeInSeconds { get; set; }
        public long Score { get; set; }

        // Constructor
        public PlayerData(string name, long timeInSeconds, long score)
        {
            Name = name;
            TimeInSeconds = timeInSeconds;
            Score = score;
        }

        public bool Update(string name = null, long timeInSeconds = 0, long score = 0)
        {
            Name = name;
            TimeInSeconds = timeInSeconds;
            Score = score;

            return true;
        }

        // Added a scoring system based on the aggregate time
        public int CompareTo(object obj)
        {
            return Score.CompareTo(obj);
        }
    }
}
