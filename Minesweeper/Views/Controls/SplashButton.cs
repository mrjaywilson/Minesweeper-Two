using System.Windows.Forms;

namespace CST227_Minesweeper.Views.Controls
{
    /// <summary>
    /// SplashButton class.
    /// </summary>
    /// 
    /// <remarks>
    /// Descr.:     The class that handles the buttons for the splash view.
    /// 
    /// Author:     Jay Wilson
    /// Date:       01/27/19
    /// Version:    1.0
    /// </remarks>
    class SplashButton : Button
    {
        // Value property to be implemented in a future update to clean up the
        // code using a simpler eventhandling system along with the splash controller.
        public int Value { get; set; }
    }
}
