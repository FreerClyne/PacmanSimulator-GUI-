using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanSimulator
{
    public partial class GameUI : Form
    {
        PacmanModule pac = new PacmanModule();

        public GameUI()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int currentX = pac.getXPos();
            int currentY = pac.getYPos();
            switch (pac.getDirection())
            {
                case "NORTH": currentY += 1; break;
                case "WEST": currentX -= 1; break;
                case "SOUTH": currentY -= 1; break;
                case "EAST": currentX += 1; break;
            }

            if (pac.moveCheck(currentX, currentY))
            {
                pac.setXPos(currentX);
                pac.setYPos(currentY);
                switch (pac.getDirection())
                {
                    case "NORTH": picPackman.Top -= 99; break;
                    case "SOUTH": picPackman.Top += 99; break;
                    case "EAST": picPackman.Left += 99; break;
                    case "WEST": picPackman.Left -= 99; break;
                }
            }
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            //panel2.Controls.Add(picPackman);
            setControl(false);
        }


        // control buttons' status at initial stage
        private void setControl(bool status)
        {
            picPackman.Visible = status;
            btnLeft.Enabled = status;
            btnRight.Enabled = status;
            btnMove.Enabled = status;
            btnReport.Enabled = status;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            pac.left();
            picPackman.BackgroundImage = pac.getIcon();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            pac.right();
            picPackman.BackgroundImage = pac.getIcon();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (pac.numberInputCheck(tbX.Text) && pac.numberInputCheck(tbY.Text))
            {
                int x = Int32.Parse(tbX.Text.Trim());
                int y = Int32.Parse(tbY.Text.Trim());
                String d = cbDirection.Text;
                if (pac.placeCheck(x, y, d)) // check if the place is valid
                {
                    pac.setXPos(x);
                    pac.setYPos(y);
                    pac.setDirection(d);

                    picPackman.Left = 26 + x * 99;
                    picPackman.Top = 24 + (2 + (2 - y)) * 99;
                    picPackman.BackgroundImage = pac.getIcon();

                    setControl(true);
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pac.report();
        }
    }
}
