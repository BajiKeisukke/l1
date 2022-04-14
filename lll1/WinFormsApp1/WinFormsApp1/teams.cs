using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class teams : Form
    {
        Team1[] team1 = new Team1[5];



        public teams()
        {
            InitializeComponent();
            team1[0] = new Team1();
            team1[0].set("1", "Miami Heat", "MIA", "1.jpg");

            team1[1] = new Team1();
            team1[1].set("2", "Orlando Magic", "ORL", "2.jpg");

            team1[2] = new Team1();
            team1[2].set("3", "Atlanta Hawks", "ATL", "3.jpg");

            team1[3] = new Team1();
            team1[3].set("4", "Washington Wizards", "WSH", "4.jpg");

            team1[4] = new Team1();
            team1[4].set("5", "Charlotte Hornets", "CHA", "5.jpg");

            button1.Text = team1[0].name;

            for (int i = 0; i < 5; i++)
            tabControl1.Controls["tabPage1"].Controls["button" + (1 + i)].Text = team1[i].name;
            {
               
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Team = new Team();
            Team.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button121_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

        }

        

       
        


        
 
  
    
   
   

    
