using RockSiccorPaperGames.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraPrinting.Native;

namespace RockSiccorPaperGames
{
    public partial class Form1 : Form
    {


        enum enGame { Rock = 0, Paper , Siccoer  }
        enum enGameRounds { ZeroRound = 0 , One = 1  , Tow = 2  , Three = 3 }
        enGameRounds GameRound; 

        struct stGameOption
        {
            public string  PlayerChooice;
            public sbyte PlayerWinPoint;
            public string  Computerchooice;
            public sbyte CmoputerWinPoint;
            public sbyte DrawingPointes; 
        };
        stGameOption GameOption; 

        int Counter = 0;
        int Count = 0;
        SoundPlayer soundPlayer;
        FrmFinnalResult frmFinnalResult = new FrmFinnalResult();

        public Form1()
        {
            InitializeComponent();
           
        }


        void ChangePicture(RadioButton radioButton)
        {
            
           if(radioButton.Tag.ToString() == "Rock" && radioButton.Checked)
           {
               
                pb_player.Image = Resources.Rock;
                GameOption.PlayerChooice = "Rock";
                return;
           }

            if (radioButton.Tag.ToString() == "Siccoer" && radioButton.Checked)
            {
               
                pb_player.Image = Resources.stone;
                GameOption.PlayerChooice = "Siccoer"; 

                return;
            }

            if (radioButton.Tag.ToString() == "Paper" && radioButton.Checked)
            {
               
                pb_player.Image = Resources.Paper;
                GameOption.PlayerChooice = "Paper";

                return;
            }
        }

        void ComputerChooices()
        {
            Random random = new Random();

            enGame enChooice = (enGame)random.Next(0,3-1); ; 

            switch (enChooice)
            {
                case enGame.Paper:
                    pb_computer.Image = Resources.Paper;
                    GameOption.Computerchooice = "Paper";
                    break;

                case enGame.Siccoer:
                    pb_computer.Image = Resources.stone;
                    GameOption.Computerchooice = "Siccoer";

                    break;

                case enGame.Rock:
                   pb_computer.Image = Resources.Rock;
                    GameOption.Computerchooice = "Rock";

                    break;
            }

        }

        void ChickWinner()
        {

          
            if(GameOption.PlayerChooice ==  GameOption.Computerchooice)
            {
                // Game Draw do Something
                lblDrawGame.Text = "Draw No Winner";
                GameOption.DrawingPointes++; 
                return;
            }
            if(GameOption.PlayerChooice == "Rock" && GameOption.Computerchooice == "Siccoer")
            {
                // Player Win do Something
                LablePlayerWin.Text = "Player Win";
                GameOption.PlayerWinPoint++;
                return;

            }
            if (GameOption.PlayerChooice == "Siccoer" && GameOption.Computerchooice == "Paper")
            {
                
                LablePlayerWin.Text = "Player Win";
                GameOption.PlayerWinPoint++;
                return;

            }
            if (GameOption.PlayerChooice == "Paper" && GameOption.Computerchooice == "Rock")
            {
               
                LablePlayerWin.Text = "Player Win";
                GameOption.PlayerWinPoint++;
                return;

            }
            else
            {
                // Computer do Something
                labeComputerWin.Text = "Computer Win";
                GameOption.CmoputerWinPoint++;
                return;

            }
        }

        public void UserInfo(string UserRound , string UserName)
        {
            labelPlayerName.Text = UserName;
            lblRouunds.Text = " ";
            if (UserRound  == enGameRounds.One.ToString())
            {
                lblRouunds.Text += " " + enGameRounds.One.ToString() + " Round";
                GameRound = enGameRounds.One;
                return;
            }

            if (UserRound == enGameRounds.Tow.ToString())
            {
                lblRouunds.Text += " " + enGameRounds.Tow.ToString() + " Rounds";
                GameRound = enGameRounds.Tow;
                return;
            }

            if (UserRound == enGameRounds.Three.ToString())
            {
                lblRouunds.Text += " " + enGameRounds.Three.ToString() + " Rounds";
                GameRound = enGameRounds.Three;
                return;
            }

        }

        public void ResetGame()
        {
         
            labeComputerWin.Text = " ";
            LablePlayerWin.Text = " ";
            lblDrawGame.Text = " ";
            
        }

        void CheckGameRounds()
        {
            lblRouunds.Text = " ";
            if (GameRound == enGameRounds.One)
            {
                GameRound = enGameRounds.ZeroRound;
                
            }

            if(GameRound == enGameRounds.Tow)
            {
                GameRound = enGameRounds.One;
                lblRouunds.Text += " " + enGameRounds.One.ToString() + " Round";
                return;
            }

            if(GameRound == enGameRounds.Three)
            {
                lblRouunds.Text += " " + enGameRounds.Tow.ToString() + " Rounds";
                GameRound = enGameRounds.Tow;
                return;
            }

            if (enGameRounds.ZeroRound == GameRound)
            {
                // game Over 
                lblRouunds.Text = "[ No Round ]";
                PnlGame.Enabled = false;
                return;
            }

        }

        void FinnalResult()
        {
            if(enGameRounds.ZeroRound == GameRound)
            {
              frmFinnalResult.FinnalResultPointes(GameOption.PlayerWinPoint, GameOption.CmoputerWinPoint, GameOption.DrawingPointes);
              frmFinnalResult.ShowDialog();
              tmrChangeImage.Stop();
              return;
            }
        }

        bool btnrdioEnabled(bool Enable = true)
        {
            btnStart.Enabled = Enable;
            rdi_Rock.Enabled = Enable;
            rdi_Paper.Enabled = Enable;
            rdi_Siccer.Enabled = Enable;
            return true;
        }

        void RadiobntEnabled(bool Enabled = true )
        {
            rdi_Paper.Enabled = Enabled;
            rdi_Rock.Enabled = Enabled;
            rdi_Siccer.Enabled = Enabled;
            btnStart.Enabled = Enabled; 
        }
        void ResetGamePoints()
        {
            GameOption.CmoputerWinPoint = 0;
            GameOption.PlayerWinPoint = 0;
            GameOption.DrawingPointes = 0;
        }
        private void Radio_Change(object sender, EventArgs e)
        {


            ChangePicture((RadioButton)sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadiobntEnabled(false);
            ResetGame();
            tmrChangeImage.Enabled = true;
            soundPlayer = new SoundPlayer(@"C:\\Users\\chmik\\Desktop\\programing advices projects\\mind.wav");
            soundPlayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pb_computer.Image = imgList.Images[Counter];
            Counter++;

            if (Counter > 2)
            {
                Counter = 0;
                Count++;
            }

            if (Count == 3 )
            {
                Counter = 0;
                Count = 0;
                ComputerChooices();
                ChickWinner();
                soundPlayer.Stop();
                tmrChangeImage.Stop();
                RadiobntEnabled(true);
                CheckGameRounds();
                FinnalResult();
                return;
            }

        }

        private void rdi_Paper_MouseClick(object sender, MouseEventArgs e)
        {
            soundPlayer = new SoundPlayer(@"C:\Users\chmik\Desktop\programing advices projects\click.wav");
            soundPlayer.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrChangeImage.Enabled = false;
            PnlGame.Enabled = true;
            ResetGamePoints();
            RadiobntEnabled(true);
            ResetGame();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
