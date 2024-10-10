using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SquareGameApp
{
    public partial class frmSquare : Form
    {
        enum TurnEnum { X, O };
        TurnEnum currentturn = TurnEnum.X;

        enum GameStatusEnum { NotStarted, Playing, Winner, Tie }
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;

        List<Label> lstlines;
        List<Label> lstboxfill;
        List<List<Label>> lstcompleteboxes;
        List<List<Label>> lstTemp;

        int scorex = 0;
        int scoreo = 0;

        public frmSquare()
        {
            InitializeComponent();
            lstlines = new() { lblLine1, lblLine2, lblLine3, lblLine4, lblLine5, lblLine6, lblLine7, lblLine8, lblLine9, lblLine10, lblLine11, lblLine12, lblLine13, lblLine14, lblLine15, lblLine16, lblLine17, lblLine18, lblLine19, lblLine20, lblLine21, lblLine22, lblLine23, lblLine24 };

            lstlines.ForEach(lbl => lbl.Click += LineClick_Click);
            lstboxfill = new() { lblBoxFill1, lblBoxFill2, lblBoxFill3, lblBoxFill4, lblBoxFill5, lblBoxFill6, lblBoxFill7, lblBoxFill8, lblBoxFill9 };
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
            DisplayGameStatus();

        }
        
        private void StartGame()
        {
            ResetListsAndScore();
            lstboxfill.ForEach(lbl => lbl.Text = "");
            gamestatus = GameStatusEnum.Playing;
            currentturn = TurnEnum.X;
            lstlines.ForEach(lbl => lbl.BackColor = Color.Gainsboro);
            DisplayGameStatus();

        }

        private void DoTurn(Label clickedlabel)
        {
            if (clickedlabel.BackColor == Color.Gainsboro && gamestatus == GameStatusEnum.Playing)
            {
                clickedlabel.BackColor = Color.Black;
                DetectCompleteBox(clickedlabel);
                DetectWinner();
                if (gamestatus == GameStatusEnum.Playing)
                {
                    if (currentturn == TurnEnum.X)
                    {
                        currentturn = TurnEnum.O;
                    }
                    else
                    {
                        currentturn = TurnEnum.X;
                    }
                }
            }
            DisplayGameStatus();
        }
        private void DetectWinner()
        {
            if (lstlines.Count(lbl => lbl.BackColor == Color.Black) == lstlines.Count())
            {
                gamestatus = GameStatusEnum.Winner;
            }
        }
        private void UpdateScore()
        {
            switch (currentturn)
            {
                case TurnEnum.X:
                    scorex = scorex + 1;
                    break;
                case TurnEnum.O:
                    scoreo = scoreo + 1;
                    break;
            }
        }

        private void FullBoxIf(int lstcompleteboxindex, Label boxfilllabel)
        {
            if (lstcompleteboxes[lstcompleteboxindex].Count(lbl => lbl.BackColor == Color.Black) == 4)
            {
                boxfilllabel.Text = currentturn.ToString();
                UpdateScore();
            }
        }

        private void FullBoxElseIf(int lstcompleteboxindex1, Label boxfilllabel1, int lstcompleteboxindex2, Label boxfilllabel2)
        {
            if (lstcompleteboxes[lstcompleteboxindex1].Count(lbl => lbl.BackColor == Color.Black) == 4)
            {
                if (lstcompleteboxes[lstcompleteboxindex2].Count(lbl => lbl.BackColor == Color.Black) == 4)
                {
                    boxfilllabel1.Text = currentturn.ToString();
                    UpdateScore();
                    boxfilllabel2.Text = currentturn.ToString();
                    UpdateScore();
                }
                else
                {
                    boxfilllabel1.Text = currentturn.ToString();
                    UpdateScore();
                }
            }
            else if (lstcompleteboxes[lstcompleteboxindex2].Count(lbl => lbl.BackColor == Color.Black) == 4)
            {
                boxfilllabel2.Text = currentturn.ToString();
                UpdateScore();
            }
        }
        private void DetectCompleteBox(Label clickedlabel)
        {
            if (clickedlabel == lblLine1)
            {
                FullBoxIf(0, lblBoxFill1);
            }
            else if (clickedlabel == lblLine2)
            {
                FullBoxIf(1, lblBoxFill2);
            }
            else if (clickedlabel == lblLine3)
            {
                FullBoxIf(2, lblBoxFill3);
            }
            else if (clickedlabel == lblLine4)
            {
                FullBoxIf(0, lblBoxFill1);
            }
            else if (clickedlabel == lblLine5)
            {
                FullBoxElseIf(0, lblBoxFill1, 1, lblBoxFill2);
            }
            else if (clickedlabel == lblLine6)
            {
                FullBoxElseIf(1, lblBoxFill2, 2, lblBoxFill3);
            }
            else if (clickedlabel == lblLine7)
            {
                FullBoxIf(2, lblBoxFill3);
            }
            else if (clickedlabel == lblLine8)
            {
                FullBoxElseIf(0, lblBoxFill1, 3, lblBoxFill4);
            }
            else if (clickedlabel == lblLine9)
            {
                FullBoxElseIf(1, lblBoxFill2, 4, lblBoxFill5);
            }
            else if (clickedlabel == lblLine10)
            {
                FullBoxElseIf(2, lblBoxFill3, 5, lblBoxFill6);
            }
            else if (clickedlabel == lblLine11)
            {
                FullBoxIf(3, lblBoxFill4);
            }
            else if (clickedlabel == lblLine12)
            {
                FullBoxElseIf(3, lblBoxFill4, 4, lblBoxFill5);
            }
            else if (clickedlabel == lblLine13)
            {
                FullBoxElseIf(4, lblBoxFill5, 5, lblBoxFill6);
            }
            else if (clickedlabel == lblLine14)
            {
                FullBoxIf(5, lblBoxFill6);
            }
            else if (clickedlabel == lblLine15)
            {
                FullBoxElseIf(3, lblBoxFill4, 6, lblBoxFill7);
            }
            else if (clickedlabel == lblLine16)
            {
                FullBoxElseIf(4, lblBoxFill5, 7, lblBoxFill8);
            }
            else if (clickedlabel == lblLine17)
            {
                FullBoxElseIf(5, lblBoxFill6, 8, lblBoxFill9);
            }
            else if (clickedlabel == lblLine18)
            {
                FullBoxIf(6, lblBoxFill7);
            }
            else if (clickedlabel == lblLine19)
            {
                FullBoxElseIf(6, lblBoxFill7, 7, lblBoxFill8);
            }
            else if (clickedlabel == lblLine20)
            {
                FullBoxElseIf(7, lblBoxFill8, 8, lblBoxFill9);
            }
            else if (clickedlabel == lblLine21)
            {
                FullBoxIf(8, lblBoxFill9);
            }
            else if (clickedlabel == lblLine22)
            {
                FullBoxIf(6, lblBoxFill7);
            }
            else if (clickedlabel == lblLine23)
            {
                FullBoxIf(7, lblBoxFill8);
            }
            else if (clickedlabel == lblLine24)
            {
                FullBoxIf(8, lblBoxFill9);
            }

            //if (isFound == true)
            //{
            //    int listnum = lstTemp.FindIndex(fb => lst.Count(lbl => lbl.BackColor == Color.Black) == 4);
            //    string boxclaim = currentturn.ToString();
            //    lstboxfill[listnum].Text = boxclaim;
            //    lstboxfill.RemoveAt(listnum);
            //    lstcompleteboxes.RemoveAt(listnum);
            //    if (currentturn == TurnEnum.X)
            //    {
            //        scorex = scorex + 1;
            //    }
            //    else
            //    {
            //        scoreo = scoreo + 1;
            //    }
            //}
            //else
            //{
            //    lblStatus.Text = "This is not working";
            //}
        }
        private void DisplayGameStatus()
        {
            string msg = "Click Start to begin game";

            switch (gamestatus)
            {
                case GameStatusEnum.Playing:
                    msg = "Current turn: " + currentturn.ToString();
                    break;
                case GameStatusEnum.Tie:
                    msg = "Box Complete!";
                    break;
                case GameStatusEnum.Winner:
                    msg = "Winner is: " + (scorex > scoreo ? "X" : "O");
                    break;
                default:
                    msg = "Click Start to begin game";
                    break;
            }
            lblStatus.Text = msg;
        }

        private void ResetListsAndScore()
        {
            lstboxfill = new() { lblBoxFill1, lblBoxFill2, lblBoxFill3, lblBoxFill4, lblBoxFill5, lblBoxFill6, lblBoxFill7, lblBoxFill8, lblBoxFill9 };
            lstTemp = new()
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
            scorex = 0;
            scoreo = 0;

        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }

        private void LineClick_Click(object? sender, EventArgs e)
        {
            if(sender is Label) 
            { 
                DoTurn((Label)sender); 
            }
            
        }
    }
}
