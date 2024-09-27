namespace SquareGameApp
{
    public partial class frmSquare : Form
    {
        enum TurnEnum { X, O };
        TurnEnum currentturn = TurnEnum.X;

        enum GameStatusEnum { NotStarted, Playing, Winner }
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;

        List<Label> lstlines;
        List<List<Label>> lstcompleteboxes;

        public frmSquare()
        {
            InitializeComponent();
            lstlines = new() { lblLine1, lblLine2, lblLine3, lblLine4, lblLine5, lblLine6, lblLine7, lblLine8, lblLine9, lblLine10, lblLine11, lblLine12, lblLine13, lblLine14, lblLine15, lblLine16, lblLine17, lblLine18, lblLine19, lblLine20, lblLine21, lblLine22, lblLine23, lblLine24};

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
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
           
        }

        private void LineClick_Click(object? sender, EventArgs e)
        {

        }
    }
}
