using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RockSiccorPaperGames
{
    public partial class MainFrm : Form
    {
        Form1 frmGame = new Form1();

        public MainFrm()
        {
            InitializeComponent();
        }


        bool IsRadioChecked(RadioButton radioButton)
        {

            if (radioButton.Checked == true)
            {
                frmGame.UserInfo(radioButton.Text , txtbxName.Text);
            }

            return radioButton.Checked;
        }

        bool RadiobntEnabled(bool Enable = true)
        {
            radioButton1.Enabled = Enable;
            radioButton2.Enabled = Enable;
            radioButton3.Enabled = Enable;
            return Enable;
        }
        bool RadiobtnChecked(bool Checked = false)
        {
            radioButton1.Checked = Checked;
            radioButton2.Checked = Checked;
            radioButton3.Checked = Checked;
            return Checked; 
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            RadiobtnChecked();

        }

        private void txtbxName_KeyDown(object sender, KeyEventArgs e)
        {
             if( e.KeyData == Keys.Enter && txtbxName.Text!= " ") { 
              
                if(!IsRadioChecked(radioButton1) && !IsRadioChecked(radioButton2) && !IsRadioChecked(radioButton3))
                {
                    MessageBox.Show("Please Check Your GameRound ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RadiobntEnabled(false);
                    frmGame.ShowDialog();
                }

                   if (!frmGame.CanSelect)
                   {
                       txtbxName.Text = " "; 
                       RadiobntEnabled();
                       RadiobtnChecked();
                   }

             }


        }
    }
}
