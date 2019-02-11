using MilestoneFour.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneFour.Controllers
{
    /// <summary>
    /// FileController class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The FileController class handles reading and writing files
    ///             for high scores using the PlayerData model.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/31/19
    /// Version:    1.0
    /// </remarks>
    public class FileController
    {
        public List<PlayerData> Data { get; set; }

        public FileController()
        {
            UpdateData();
        }

        public void UpdateData()
        {
            Data = new List<PlayerData>();

            using (StreamReader reader = new StreamReader("highscore.json"))
            {
                string json = reader.ReadToEnd();

                Data = JsonConvert.DeserializeObject<List<PlayerData>>(json);

                if (Data != null)
                {
                    // Use LINQ to sort by score
                    Data = Data.OrderByDescending(x => x.Score).ToList();
                }
            }
        }
    }
}
