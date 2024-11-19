using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockSiccorPaperGames
{
    public partial class FrmFinnalResult : Form
    {
        public FrmFinnalResult()
        {
            InitializeComponent();
        }

        public void FinnalResultPointes(sbyte PlayerPoint , sbyte CompouterPoint , sbyte DrawNoWinnerPoint)
        {
            LableComputerPoints.Text = CompouterPoint.ToString();
            labelPlayerPoints.Text   = PlayerPoint.ToString();
            labelDrwaPoint.Text      = DrawNoWinnerPoint.ToString();
        }
    }
}
