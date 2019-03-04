using System;
using System.Drawing;
using System.Windows.Forms;

namespace PacmanSimulator
{
    class PacmanModule
    {
        private int xPos;
        private int yPos;
        private String direction;
        private Image icon;
        private const int UPPER_BOUNDARY = 5;
        private const int LOWER_BOUNDARY = 0;
        private readonly String[] DIRECTION = { "NORTH", "SOUTH", "WEST", "EAST" };
	
	    public PacmanModule()
        {
            xPos = 0;
            yPos = 3;
            direction = "EAST";
            icon = Properties.Resources.pac_east;
        }

        public void setIcon(string direction)
        {
            switch (direction)
            {
                case "NORTH": icon = Properties.Resources.pac_north; break;
                case "WEST": icon = Properties.Resources.pac_west; break;
                case "SOUTH": icon = Properties.Resources.pac_south; break;
                case "EAST": icon = Properties.Resources.pac_east; break;
            }
        }

        public Image getIcon()
        {
            return icon;
        }

        public int getXPos()
        {
            return xPos;
        }

        public int getYPos()
        {
            return yPos;
        }

        public String getDirection()
        {
            return direction;
        }

        public void setXPos(int newX)
        {
            xPos = newX;
        }

        public void setYPos(int newY)
        {
            yPos = newY;
        }

        public void setDirection(String newDirect)
        {
            direction = newDirect;
            setIcon(newDirect);
        }

        /**
         * @return if the movement is valid
         */
        public bool moveCheck(int newX, int newY)
        {
            if (newX < LOWER_BOUNDARY || newX >= UPPER_BOUNDARY)
            {
                MessageBox.Show("Out of boundary");
                return false;
            }
            if (newY < LOWER_BOUNDARY || newY >= UPPER_BOUNDARY)
            {
                MessageBox.Show("Out of boundary");
                return false;
            }
            return true;
        }

        /**
         * @return if the direction is valid
         */
        public bool directionCheck(String newDirect)
        {
            if (newDirect == null || String.IsNullOrEmpty(newDirect.Trim())) // check if input is empty
            {
                return false;
            }
            foreach (String dir in DIRECTION)
            {
                if (String.Equals(dir, newDirect.Trim().ToUpper()))
                    return true;
            }

            return false;
        }

        /**
         * @return if the input of a place is valid
         */
        public bool placeCheck(int x, int y, String d)
        {
            if (!moveCheck(x, y)) // check if the position is inside the matrix
            {
                return false;
            }
            if (!directionCheck(d.Trim())) // check if the direction is valid
            {
                return false;
            }

            return true;
        }

        /**
         * @return whether the input string is 
         * a valid number
         */
        public bool numberInputCheck(String input)
        {
            if (input == null || String.IsNullOrEmpty(input.Trim())) // check if input is empty
            {
                MessageBox.Show("Error, invalid input");
                return false;
            }
            input = input.Trim();
            for (int i = 0; i < input.Length; i++) // check if input is numeric
            {
                if (input[i] < '0' || input[i] > '9')
                {
                    MessageBox.Show("Error, invalid input");
                    return false;
                }
            }
            return true;
        }

        /**
         * Move 1 unit towards current direction
         */
        public void move()
        {
            int currentX = getXPos();
            int currentY = getYPos();
            switch (getDirection())
            {
                case "NORTH": currentY += 1; break;
                case "WEST": currentX -= 1; break;
                case "SOUTH": currentY -= 1; break;
                case "EAST": currentX += 1; break;
            }
            if (moveCheck(currentX, currentY))
            {
                setXPos(currentX);
                setYPos(currentY);
            }

        }

        /**
         * Rotate 90 degree to left
         */
        public void left()
        {
            switch (getDirection())
            {
                case "NORTH": setDirection("WEST"); break;
                case "WEST": setDirection("SOUTH"); break;
                case "SOUTH": setDirection("EAST"); break;
                case "EAST": setDirection("NORTH"); break;
            }
        }

        /**
         * Rotate 90 degree to right
         */
        public void right()
        {
            switch (getDirection())
            {
                case "NORTH": setDirection("EAST"); break;
                case "WEST": setDirection("NORTH"); break;
                case "SOUTH": setDirection("WEST"); break;
                case "EAST": setDirection("SOUTH"); break;
            }
        }

        /**
         * Display current position and direction
         */
        public void report()
        {
            String output = getXPos() + ", " + getYPos() + ", " + getDirection();
            MessageBox.Show(output);
        }


    }
}
