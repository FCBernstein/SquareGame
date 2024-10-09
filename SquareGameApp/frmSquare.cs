using System.Xml.Linq;

namespace SquareGameApp
{
    public partial class frmSquare : Form
    {
        private int counter = 0;
        private bool gameStarted = false; //game started or not
        enum TurnEnum { X, O };
        TurnEnum currentturn = TurnEnum.X;

        enum GameStatusEnum { NotStarted, Playing, Winner }
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;

        List<Label> lstlines;
        List<List<Label>> lstcompleteboxes;

        public frmSquare()
        {

            InitializeComponent();
            lstlines = new() { lblLine1, lblLine2, lblLine3, lblLine4, lblLine5, lblLine6, lblLine7, lblLine8, lblLine9, lblLine10, lblLine11, lblLine12, lblLine13, lblLine14, lblLine15, lblLine16, lblLine17, lblLine18, lblLine19, lblLine20, lblLine21, lblLine22, lblLine23, lblLine24 };

            lstlines.ForEach(lbl => lbl.Click += LineClick_Click);
            btnStart.Click += BtnStart_Click;


            lstcompleteboxes = new()
            {
                new(){lblLine1, lblLine4, lblLine5, lblLine8 },
                new(){lblLine2, lblLine5, lblLine6, lblLine9 },
                new(){lblLine3, lblLine6, lblLine7, lblLine10 },
                new(){lblLine8, lblLine11, lblLine12, lblLine15 },
                new(){lblLine9, lblLine12, lblLine13, lblLine16 },
                new(){lblLine10, lblLine13, lblLine14, lblLine17 },
                new(){lblLine15, lblLine18, lblLine19, lblLine22 },
                new(){lblLine16, lblLine19, lblLine20, lblLine23 },
                new(){lblLine17, lblLine20, lblLine21, lblLine24 }
            };
            lblStatus.Text = "Game not started yet"; // Update the status label if you have one
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            counter++;
            ResetBoard();
            gameStarted = true;  //setting the game on

            UpdateTurnDisplay();
        }
        private void ResetBoard()
        {
            string newLabelName;
            Label newLabel;
            string newBoxlName;
            Label newBox;
            for (int i = 1; i <= 24; i++)//reseting the lines
            {
                newLabelName = $"lblLine{i}";
                newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
                newLabel.BackColor = System.Drawing.Color.Gainsboro;
            }
            for (int i = 1; i <= 9; i++)// reseting the boxes
            {
                newBoxlName = $"lblBoxFill{i}";
                newBox = this.Controls.Find(newBoxlName, true).FirstOrDefault() as Label;
                newBox.BackColor = System.Drawing.Color.White;
                newBox.Text = "";
            }
            // Optionally, reset the game state
            currentturn = TurnEnum.X; // Reset to the starting player
            gameStarted = false; // Reset the game status
        }
        private void tblGrid_Paint(object? sender, EventArgs e)
        {

        }
        private void LineClick_Click(object? sender, EventArgs e)
        {
            bool row = false;
                if (gameStarted == false)  // if the game is not on you cant play
                {
                if(counter==0)
                    MessageBox.Show("Please start the game first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Please start a new game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                {
                    Label clickedLine = sender as Label;
                    if (currentturn == TurnEnum.X)
                    {
                        clickedLine.BackColor = System.Drawing.Color.Blue; // Set color of the line to Blue for X
                    }
                    else // currentTurn is O
                    {
                        clickedLine.BackColor = System.Drawing.Color.Red; // Set color of the line to Red for O
                    }
                    if (clickedLine.Tag.ToString() == "row")//did the user just clicked a line in a row or  a coll
                        row = true;
                    else
                        row = false;
                    CheckSquare(row, int.Parse(clickedLine.Name.Replace("lblLine", "")), clickedLine);// doing a check if the square is finished, and giving us the number
                    if (checkWin())
                    {
                        gameStarted = false;
                    }
                    else
                    {
                        ToggleTurn();
                    }
                }
        }
        private void ToggleTurn()
        {
            // Toggle the turn between X and O
            currentturn = currentturn == TurnEnum.X ? TurnEnum.O : TurnEnum.X;
            UpdateTurnDisplay(); // Update the TextBox with the new turn
        }
        private void UpdateTurnDisplay()
        {
            lblStatus.Text = $"{currentturn} Turn";// Set the TextBox to "X" or "O"
                                                   // Change the text color based on the current turn
            if (currentturn == TurnEnum.X)
            {
                lblStatus.ForeColor = System.Drawing.Color.Blue; // Set color to Blue for X
            }
            else // currentTurn is O
            {
                lblStatus.ForeColor = System.Drawing.Color.Red; // Set color to Red for O
            }
        }
        private void CheckSquare(bool RowOrNot, int lineNumber, Label clickedLine)
        {
            if (RowOrNot)
            {
                checkup(lineNumber, clickedLine);
                checkdown(lineNumber, clickedLine);
            }
            else 
            {
                checkRight(lineNumber, clickedLine);
                checkLeft(lineNumber, clickedLine);
            }
        }
        private int RedOrNot(Label newlabel) //checking which counter to add
        {
            if (newlabel == null)// for null and estetics 
                return 2;
            else if (newlabel.BackColor == Color.Red)
                return 1;
            else if (newlabel.BackColor == Color.Blue)
                return 0;
            else return 3;
        }
        private void checkup(int lineNumber, Label clickedLine) //chechking if the box above is filled
        {
            string newLabelName;
            Label newLabel;
            int redCounter = 0, blueCounter = 0;
            newLabelName = $"lblLine{lineNumber - 3}"; //checking the left wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber - 4}"; //checking the right wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber -7}"; //checking the upper wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (newLabel != null)
            {
                if (RedOrNot(newLabel) == 1)
                    redCounter++;
                else if (RedOrNot(newLabel) == 0)
                    blueCounter++;
            }
            newLabelName = $"lblLine{lineNumber}"; //checking the clicked line
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            if (redCounter + blueCounter == 4)//all the box is filled
            {
                string newBoxName="";
                Label newBox = null;
                Label newBoxLabel = null;
                if (lineNumber <= 10 && lineNumber >= 8)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 7}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 17 && lineNumber >= 15)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 11}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 24 && lineNumber >= 22)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 15}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                newBoxLabel = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                if (redCounter == blueCounter)
                    newBoxLabel.Text = "";
                else if (redCounter > blueCounter)
                {
                    newBoxLabel.Text = "O Turn";
                    newBoxLabel.ForeColor = Color.Red; // Set text color to red for O
                }
                else
                {
                    newBoxLabel.Text = "X Turn";
                    newBoxLabel.ForeColor = Color.Blue; // Set text color to red for O
                }
            }
        }
        private void checkdown(int lineNumber, Label clickedLine) //chechking if the box under is filled
        {
            string newLabelName;
            Label newLabel;
            int redCounter = 0, blueCounter = 0;
            newLabelName = $"lblLine{lineNumber + 3}"; //checking the left wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber + 4}"; //checking the right wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber + 7}"; //checking the upper wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (newLabel != null)
            {
                if (RedOrNot(newLabel) == 1)
                    redCounter++;
                else if (RedOrNot(newLabel) == 0)
                    blueCounter++;
            }
            newLabelName = $"lblLine{lineNumber}"; //checking the clicked line
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            if (redCounter + blueCounter == 4)//all the box is filled
            {
                string newBoxName="";
                Label newBox = null;
                Label newBoxLabel = null;
                if (lineNumber <= 3 && lineNumber >= 1)
                {
                    newBoxName = $"lblBoxFill{lineNumber}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 10 && lineNumber >= 8)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 4}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 17 && lineNumber >= 15)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 8}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                newBoxLabel = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                if (redCounter == blueCounter)
                    newBoxLabel.Text = "";
                else if (redCounter > blueCounter)
                {
                    newBoxLabel.Text = "O Turn";
                    newBoxLabel.ForeColor = Color.Red; // Set text color to red for O
                }
                else
                {
                    newBoxLabel.Text = "X Turn";
                    newBoxLabel.ForeColor = Color.Blue; // Set text color to red for O
                }
            }
        }
        private void checkLeft(int lineNumber, Label clickedLine) //chechking if the box to the left is filled
        {
            string newLabelName;
            Label newLabel;
            int redCounter = 0, blueCounter = 0;
            newLabelName = $"lblLine{lineNumber -4 }"; //checking the upper wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber + 3}"; //checking the bellow wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber - 1}"; //checking the upper wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (lineNumber!=4&&lineNumber!=11&&lineNumber!=18)//not going back to rows 
            {
                if (RedOrNot(newLabel) == 1)
                    redCounter++;
                else if (RedOrNot(newLabel) == 0)
                    blueCounter++;
            }
            newLabelName = $"lblLine{lineNumber}"; //checking the clicked line
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            if (redCounter + blueCounter == 4)//all the box is filled
            {
                string newBoxName="";
                Label newBox = null;
                Label newBoxLabel = null;
                if (lineNumber <= 7 && lineNumber >= 5)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 4}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 14 && lineNumber >= 12)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 8}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 21 && lineNumber >= 19)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 12}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                newBoxLabel = this.Controls.Find(newBoxName,true).FirstOrDefault()as Label;
                if (redCounter == blueCounter)
                    newBoxLabel.Text = "";
                else if (redCounter > blueCounter)
                {
                    newBoxLabel.Text = "O Turn";
                    newBoxLabel.ForeColor = Color.Red; // Set text color to red for O
                }
                else
                {
                    newBoxLabel.Text = "X Turn";
                    newBoxLabel.ForeColor = Color.Blue; // Set text color to red for O
                }
            }
        }
        private void checkRight(int lineNumber, Label clickedLine) //chechking if the box to the right is filled
        {
            string newLabelName;
            Label newLabel;
            int redCounter = 0, blueCounter = 0;
            newLabelName = $"lblLine{lineNumber - 3}"; //checking the upper wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber + 4}"; //checking the bellow wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            newLabelName = $"lblLine{lineNumber + 1}"; //checking the upper wall
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (lineNumber != 7 && lineNumber != 14 && lineNumber != 21)//not going back to rows 
            {
                if (RedOrNot(newLabel) == 1)
                    redCounter++;
                else if (RedOrNot(newLabel) == 0)
                    blueCounter++;
            }
            newLabelName = $"lblLine{lineNumber}"; //checking the clicked line
            newLabel = this.Controls.Find(newLabelName, true).FirstOrDefault() as Label;
            if (RedOrNot(newLabel) == 1)
                redCounter++;
            else if (RedOrNot(newLabel) == 0)
                blueCounter++;
            if (redCounter + blueCounter == 4)//all the box is filled
            {
                string newBoxName="";
                Label newBox = null;
                Label newBoxLabel = null;
                if (lineNumber <= 6 && lineNumber >= 4)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 3}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 13 && lineNumber >= 11)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 7}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                else if (lineNumber <= 20 && lineNumber >= 18)
                {
                    newBoxName = $"lblBoxFill{lineNumber - 11}"; // Adjusted for box naming convention
                    newBox = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                }
                newBoxLabel = this.Controls.Find(newBoxName, true).FirstOrDefault() as Label;
                if (redCounter == blueCounter)
                    newBoxLabel.Text = "";
                else if (redCounter > blueCounter)
                {
                    newBoxLabel.Text = "O Turn";
                    newBoxLabel.ForeColor = Color.Red; // Set text color to red for O
                }
                else
                {
                    newBoxLabel.Text = "X Turn";
                    newBoxLabel.ForeColor = Color.Blue; // Set text color to red for O
                }
            }
        }
        private bool checkWin() { 
            int[][] winningCombinations = new int[][]
                {
        new int[] { 1, 2, 3 }, // Row 1
        new int[] { 4, 5, 6 }, // Row 2
        new int[] { 7, 8, 9 }, // Row 3
        new int[] { 1, 4, 7 }, // Column 1
        new int[] { 2, 5, 8 }, // Column 2
        new int[] { 3, 6, 9 }, // Column 3
        new int[] { 1, 5, 9 }, // Diagonal \
        new int[] { 3, 5, 7 }  // Diagonal /
                };

            // Check each winning combination
            foreach (var combination in winningCombinations)
            {
                // Get the values in the boxes for the current combination
                string value1 = GetBoxValue(combination[0]);
                string value2 = GetBoxValue(combination[1]);
                string value3 = GetBoxValue(combination[2]);

                // Check if all three values are the same and not empty
                if (value1 == value2 && value2 == value3 && !string.IsNullOrEmpty(value1))
                {
                    if (value1=="X Turn")
                    MessageBox.Show($"X wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    MessageBox.Show($"O wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true; // There is a winner
                }
            }
            return false;
        }
        private string GetBoxValue(int boxNumber)
        {
            string boxName = $"lblBoxFill{boxNumber}";
            Label boxLabel = this.Controls.Find(boxName, true).FirstOrDefault() as Label;

            return boxLabel?.Text; // Return the text or null if not found
        }
        private void row1_Click(object sender, EventArgs e)
        {

        }

        private void row7_Click(object sender, EventArgs e)
        {

        }

        private void row8_Click(object sender, EventArgs e)
        {

        }

        private void row10_Click(object sender, EventArgs e)
        {

        }
    }
}
            
