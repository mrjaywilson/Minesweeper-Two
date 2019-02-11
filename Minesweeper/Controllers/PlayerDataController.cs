using MilestoneFour.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace MilestoneFour.Controllers
{
    /// <summary>
    /// HighScoreController class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The HighScoreController class handles the high score view
    ///             and works with the FileController class for persistent data.
    /// 
    /// Author:     Jay Wilson
    /// Date:       02/03/19
    /// Version:    1.0
    /// </remarks>
    public class PlayerDataController
    {
        // Properties
        public PlayerData Player { get; set; }

        // Variables & Objects
        FileController fileController;

        public PlayerDataController()
        {
            Player = new PlayerData(null, 0, 0);
            fileController = new FileController();
        }

        /// <summary>
        /// Returns an index number if the player's score beats a score. If not, returns
        /// a negative number.
        /// </summary>
        public int SubmitScore()
        {
            if (fileController.Data == null)
            {
                return 0;
            }

            if (Player.Score < fileController.Data[fileController.Data.Count - 1].Score)
            {
                if (fileController.Data.Count == 10 || Player.Score == 0)
                {
                    return -1;
                }
            }

            int index = -1;

            // Use FileController to access the file and check the score
            foreach (PlayerData data in fileController.Data)
            {
                if (Player.Score > data.Score)
                {
                    index = fileController.Data.IndexOf(data);

                    if (fileController.Data.Count == 10)
                    {
                        // Drop the bottom-most score
                        fileController.Data.RemoveAt(fileController.Data.Count - 1);
                    }

                    return index;
                }
                else
                {
                    index = fileController.Data.Count;
                }
            }

            return index;
        }

        public bool Record(int index) {

            string json = "";

            if (fileController.Data != null)
            {
                // use FileController to access the file and add the score data to the file
                fileController.Data.Add(new PlayerData(Player.Name, Player.TimeInSeconds, Player.Score));

                // User LINQ to sort by score
                fileController.Data = fileController.Data.OrderByDescending(x => x.Score).ToList();

                json = JsonConvert.SerializeObject(fileController.Data);
            } else
            {
                List<PlayerData> newData = new List<PlayerData>();

                newData.Add(new PlayerData(Player.Name, Player.TimeInSeconds, Player.Score));

                json = JsonConvert.SerializeObject(newData);
            }

            try
            {
                File.WriteAllText(@"highscore.json", json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return false;
        }
    }
}
