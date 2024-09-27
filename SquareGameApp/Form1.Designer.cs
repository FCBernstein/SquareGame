namespace SquareGameApp
{
    partial class frmSquare
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSquare));
            tblMain = new TableLayoutPanel();
            tblStartStatus = new TableLayoutPanel();
            btnStart = new Button();
            lblStatus = new Label();
            tblGrid = new TableLayoutPanel();
            lblDot1 = new Label();
            lblLine1 = new Label();
            lblDot2 = new Label();
            lblLine2 = new Label();
            lblDot3 = new Label();
            lblDot4 = new Label();
            lblLine3 = new Label();
            lblLine4 = new Label();
            lblLine5 = new Label();
            lblLine6 = new Label();
            lblLine7 = new Label();
            lblDot5 = new Label();
            lblLine8 = new Label();
            lblDot6 = new Label();
            lblLine9 = new Label();
            lblDot7 = new Label();
            lblDot8 = new Label();
            lblLine11 = new Label();
            lblLine12 = new Label();
            lblLine13 = new Label();
            lblLine14 = new Label();
            lblDot9 = new Label();
            lblLine15 = new Label();
            lblDot10 = new Label();
            lblLine16 = new Label();
            lblDot11 = new Label();
            lblLine17 = new Label();
            lblDot12 = new Label();
            lblLine18 = new Label();
            lblLine19 = new Label();
            lblLine20 = new Label();
            lblLine21 = new Label();
            lblDot13 = new Label();
            lblLine22 = new Label();
            lblDot14 = new Label();
            lblLine23 = new Label();
            lblDot15 = new Label();
            lblLine24 = new Label();
            lblDot16 = new Label();
            lblLine10 = new Label();
            tblMain.SuspendLayout();
            tblStartStatus.SuspendLayout();
            tblGrid.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblStartStatus, 0, 0);
            tblMain.Controls.Add(tblGrid, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tblMain.Size = new Size(701, 782);
            tblMain.TabIndex = 0;
            // 
            // tblStartStatus
            // 
            tblStartStatus.BackColor = Color.WhiteSmoke;
            tblStartStatus.ColumnCount = 2;
            tblStartStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.3830738F));
            tblStartStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.61693F));
            tblStartStatus.Controls.Add(btnStart, 0, 0);
            tblStartStatus.Controls.Add(lblStatus, 1, 0);
            tblStartStatus.Dock = DockStyle.Fill;
            tblStartStatus.Location = new Point(3, 3);
            tblStartStatus.Name = "tblStartStatus";
            tblStartStatus.RowCount = 1;
            tblStartStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStartStatus.Size = new Size(695, 72);
            tblStartStatus.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Right;
            btnStart.AutoSize = true;
            btnStart.BackColor = Color.LightGray;
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(4, 10);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(148, 52);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.BackColor = Color.White;
            lblStatus.Location = new Point(158, 11);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(534, 50);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblGrid
            // 
            tblGrid.ColumnCount = 9;
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblGrid.Controls.Add(lblDot1, 1, 1);
            tblGrid.Controls.Add(lblLine1, 2, 1);
            tblGrid.Controls.Add(lblDot2, 3, 1);
            tblGrid.Controls.Add(lblLine2, 4, 1);
            tblGrid.Controls.Add(lblDot3, 5, 1);
            tblGrid.Controls.Add(lblDot4, 7, 1);
            tblGrid.Controls.Add(lblLine3, 6, 1);
            tblGrid.Controls.Add(lblLine4, 1, 2);
            tblGrid.Controls.Add(lblLine5, 3, 2);
            tblGrid.Controls.Add(lblLine6, 5, 2);
            tblGrid.Controls.Add(lblLine7, 7, 2);
            tblGrid.Controls.Add(lblDot5, 1, 3);
            tblGrid.Controls.Add(lblLine8, 2, 3);
            tblGrid.Controls.Add(lblDot6, 3, 3);
            tblGrid.Controls.Add(lblLine9, 4, 3);
            tblGrid.Controls.Add(lblDot7, 5, 3);
            tblGrid.Controls.Add(lblDot8, 7, 3);
            tblGrid.Controls.Add(lblLine11, 1, 4);
            tblGrid.Controls.Add(lblLine12, 3, 4);
            tblGrid.Controls.Add(lblLine13, 5, 4);
            tblGrid.Controls.Add(lblLine14, 7, 4);
            tblGrid.Controls.Add(lblDot9, 1, 5);
            tblGrid.Controls.Add(lblLine15, 2, 5);
            tblGrid.Controls.Add(lblDot10, 3, 5);
            tblGrid.Controls.Add(lblLine16, 4, 5);
            tblGrid.Controls.Add(lblDot11, 5, 5);
            tblGrid.Controls.Add(lblLine17, 6, 5);
            tblGrid.Controls.Add(lblDot12, 7, 5);
            tblGrid.Controls.Add(lblLine18, 1, 6);
            tblGrid.Controls.Add(lblLine19, 3, 6);
            tblGrid.Controls.Add(lblLine20, 5, 6);
            tblGrid.Controls.Add(lblLine21, 7, 6);
            tblGrid.Controls.Add(lblDot13, 1, 7);
            tblGrid.Controls.Add(lblLine22, 2, 7);
            tblGrid.Controls.Add(lblDot14, 3, 7);
            tblGrid.Controls.Add(lblLine23, 4, 7);
            tblGrid.Controls.Add(lblDot15, 5, 7);
            tblGrid.Controls.Add(lblLine24, 6, 7);
            tblGrid.Controls.Add(lblDot16, 7, 7);
            tblGrid.Controls.Add(lblLine10, 6, 3);
            tblGrid.Dock = DockStyle.Fill;
            tblGrid.Location = new Point(0, 78);
            tblGrid.Margin = new Padding(0);
            tblGrid.Name = "tblGrid";
            tblGrid.RowCount = 9;
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblGrid.Size = new Size(701, 704);
            tblGrid.TabIndex = 0;
            // 
            // lblDot1
            // 
            lblDot1.AutoSize = true;
            lblDot1.BackColor = Color.Black;
            lblDot1.Dock = DockStyle.Fill;
            lblDot1.Location = new Point(116, 116);
            lblDot1.Margin = new Padding(0);
            lblDot1.Name = "lblDot1";
            lblDot1.Size = new Size(30, 30);
            lblDot1.TabIndex = 0;
            // 
            // lblLine1
            // 
            lblLine1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine1.BackColor = Color.Gainsboro;
            lblLine1.Location = new Point(146, 127);
            lblLine1.Margin = new Padding(0);
            lblLine1.Name = "lblLine1";
            lblLine1.Size = new Size(116, 8);
            lblLine1.TabIndex = 1;
            // 
            // lblDot2
            // 
            lblDot2.AutoSize = true;
            lblDot2.BackColor = Color.Black;
            lblDot2.Dock = DockStyle.Fill;
            lblDot2.Location = new Point(262, 116);
            lblDot2.Margin = new Padding(0);
            lblDot2.Name = "lblDot2";
            lblDot2.Size = new Size(30, 30);
            lblDot2.TabIndex = 2;
            // 
            // lblLine2
            // 
            lblLine2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine2.BackColor = Color.Gainsboro;
            lblLine2.Location = new Point(292, 127);
            lblLine2.Margin = new Padding(0);
            lblLine2.Name = "lblLine2";
            lblLine2.Size = new Size(116, 8);
            lblLine2.TabIndex = 3;
            // 
            // lblDot3
            // 
            lblDot3.AutoSize = true;
            lblDot3.BackColor = Color.Black;
            lblDot3.Dock = DockStyle.Fill;
            lblDot3.Location = new Point(408, 116);
            lblDot3.Margin = new Padding(0);
            lblDot3.Name = "lblDot3";
            lblDot3.Size = new Size(30, 30);
            lblDot3.TabIndex = 4;
            // 
            // lblDot4
            // 
            lblDot4.AutoSize = true;
            lblDot4.BackColor = Color.Black;
            lblDot4.Dock = DockStyle.Fill;
            lblDot4.Location = new Point(554, 116);
            lblDot4.Margin = new Padding(0);
            lblDot4.Name = "lblDot4";
            lblDot4.Size = new Size(30, 30);
            lblDot4.TabIndex = 6;
            // 
            // lblLine3
            // 
            lblLine3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine3.BackColor = Color.Gainsboro;
            lblLine3.Location = new Point(438, 127);
            lblLine3.Margin = new Padding(0);
            lblLine3.Name = "lblLine3";
            lblLine3.Size = new Size(116, 8);
            lblLine3.TabIndex = 5;
            // 
            // lblLine4
            // 
            lblLine4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine4.BackColor = Color.Gainsboro;
            lblLine4.Location = new Point(127, 146);
            lblLine4.Name = "lblLine4";
            lblLine4.Size = new Size(8, 116);
            lblLine4.TabIndex = 7;
            // 
            // lblLine5
            // 
            lblLine5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine5.BackColor = Color.Gainsboro;
            lblLine5.Location = new Point(273, 146);
            lblLine5.Name = "lblLine5";
            lblLine5.Size = new Size(8, 116);
            lblLine5.TabIndex = 8;
            // 
            // lblLine6
            // 
            lblLine6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine6.BackColor = Color.Gainsboro;
            lblLine6.Location = new Point(419, 146);
            lblLine6.Name = "lblLine6";
            lblLine6.Size = new Size(8, 116);
            lblLine6.TabIndex = 9;
            // 
            // lblLine7
            // 
            lblLine7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine7.BackColor = Color.Gainsboro;
            lblLine7.Location = new Point(565, 146);
            lblLine7.Name = "lblLine7";
            lblLine7.Size = new Size(8, 116);
            lblLine7.TabIndex = 10;
            // 
            // lblDot5
            // 
            lblDot5.AutoSize = true;
            lblDot5.BackColor = Color.Black;
            lblDot5.Dock = DockStyle.Fill;
            lblDot5.Location = new Point(116, 262);
            lblDot5.Margin = new Padding(0);
            lblDot5.Name = "lblDot5";
            lblDot5.Size = new Size(30, 30);
            lblDot5.TabIndex = 11;
            // 
            // lblLine8
            // 
            lblLine8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine8.BackColor = Color.Gainsboro;
            lblLine8.Location = new Point(146, 273);
            lblLine8.Margin = new Padding(0);
            lblLine8.Name = "lblLine8";
            lblLine8.Size = new Size(116, 8);
            lblLine8.TabIndex = 12;
            // 
            // lblDot6
            // 
            lblDot6.AutoSize = true;
            lblDot6.BackColor = Color.Black;
            lblDot6.Dock = DockStyle.Fill;
            lblDot6.Location = new Point(262, 262);
            lblDot6.Margin = new Padding(0);
            lblDot6.Name = "lblDot6";
            lblDot6.Size = new Size(30, 30);
            lblDot6.TabIndex = 13;
            // 
            // lblLine9
            // 
            lblLine9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine9.BackColor = Color.Gainsboro;
            lblLine9.Location = new Point(292, 273);
            lblLine9.Margin = new Padding(0);
            lblLine9.Name = "lblLine9";
            lblLine9.Size = new Size(116, 8);
            lblLine9.TabIndex = 14;
            // 
            // lblDot7
            // 
            lblDot7.AutoSize = true;
            lblDot7.BackColor = Color.Black;
            lblDot7.Dock = DockStyle.Fill;
            lblDot7.Location = new Point(408, 262);
            lblDot7.Margin = new Padding(0);
            lblDot7.Name = "lblDot7";
            lblDot7.Size = new Size(30, 30);
            lblDot7.TabIndex = 15;
            // 
            // lblDot8
            // 
            lblDot8.AutoSize = true;
            lblDot8.BackColor = Color.Black;
            lblDot8.Dock = DockStyle.Fill;
            lblDot8.Location = new Point(554, 262);
            lblDot8.Margin = new Padding(0);
            lblDot8.Name = "lblDot8";
            lblDot8.Size = new Size(30, 30);
            lblDot8.TabIndex = 17;
            // 
            // lblLine11
            // 
            lblLine11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine11.BackColor = Color.Gainsboro;
            lblLine11.Location = new Point(127, 292);
            lblLine11.Name = "lblLine11";
            lblLine11.Size = new Size(8, 116);
            lblLine11.TabIndex = 18;
            // 
            // lblLine12
            // 
            lblLine12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine12.BackColor = Color.Gainsboro;
            lblLine12.Location = new Point(273, 292);
            lblLine12.Name = "lblLine12";
            lblLine12.Size = new Size(8, 116);
            lblLine12.TabIndex = 19;
            // 
            // lblLine13
            // 
            lblLine13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine13.BackColor = Color.Gainsboro;
            lblLine13.Location = new Point(419, 292);
            lblLine13.Name = "lblLine13";
            lblLine13.Size = new Size(8, 116);
            lblLine13.TabIndex = 19;
            // 
            // lblLine14
            // 
            lblLine14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine14.BackColor = Color.Gainsboro;
            lblLine14.Location = new Point(565, 292);
            lblLine14.Name = "lblLine14";
            lblLine14.Size = new Size(8, 116);
            lblLine14.TabIndex = 20;
            // 
            // lblDot9
            // 
            lblDot9.AutoSize = true;
            lblDot9.BackColor = Color.Black;
            lblDot9.Dock = DockStyle.Fill;
            lblDot9.Location = new Point(116, 408);
            lblDot9.Margin = new Padding(0);
            lblDot9.Name = "lblDot9";
            lblDot9.Size = new Size(30, 30);
            lblDot9.TabIndex = 21;
            // 
            // lblLine15
            // 
            lblLine15.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine15.BackColor = Color.Gainsboro;
            lblLine15.Location = new Point(146, 419);
            lblLine15.Margin = new Padding(0);
            lblLine15.Name = "lblLine15";
            lblLine15.Size = new Size(116, 8);
            lblLine15.TabIndex = 22;
            // 
            // lblDot10
            // 
            lblDot10.AutoSize = true;
            lblDot10.BackColor = Color.Black;
            lblDot10.Dock = DockStyle.Fill;
            lblDot10.Location = new Point(262, 408);
            lblDot10.Margin = new Padding(0);
            lblDot10.Name = "lblDot10";
            lblDot10.Size = new Size(30, 30);
            lblDot10.TabIndex = 23;
            // 
            // lblLine16
            // 
            lblLine16.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine16.BackColor = Color.Gainsboro;
            lblLine16.Location = new Point(292, 419);
            lblLine16.Margin = new Padding(0);
            lblLine16.Name = "lblLine16";
            lblLine16.Size = new Size(116, 8);
            lblLine16.TabIndex = 24;
            // 
            // lblDot11
            // 
            lblDot11.AutoSize = true;
            lblDot11.BackColor = Color.Black;
            lblDot11.Dock = DockStyle.Fill;
            lblDot11.Location = new Point(408, 408);
            lblDot11.Margin = new Padding(0);
            lblDot11.Name = "lblDot11";
            lblDot11.Size = new Size(30, 30);
            lblDot11.TabIndex = 25;
            // 
            // lblLine17
            // 
            lblLine17.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine17.BackColor = Color.Gainsboro;
            lblLine17.Location = new Point(438, 419);
            lblLine17.Margin = new Padding(0);
            lblLine17.Name = "lblLine17";
            lblLine17.Size = new Size(116, 8);
            lblLine17.TabIndex = 26;
            // 
            // lblDot12
            // 
            lblDot12.AutoSize = true;
            lblDot12.BackColor = Color.Black;
            lblDot12.Dock = DockStyle.Fill;
            lblDot12.Location = new Point(554, 408);
            lblDot12.Margin = new Padding(0);
            lblDot12.Name = "lblDot12";
            lblDot12.Size = new Size(30, 30);
            lblDot12.TabIndex = 27;
            // 
            // lblLine18
            // 
            lblLine18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine18.BackColor = Color.Gainsboro;
            lblLine18.Location = new Point(127, 438);
            lblLine18.Name = "lblLine18";
            lblLine18.Size = new Size(8, 116);
            lblLine18.TabIndex = 28;
            // 
            // lblLine19
            // 
            lblLine19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine19.BackColor = Color.Gainsboro;
            lblLine19.Location = new Point(273, 438);
            lblLine19.Name = "lblLine19";
            lblLine19.Size = new Size(8, 116);
            lblLine19.TabIndex = 29;
            // 
            // lblLine20
            // 
            lblLine20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine20.BackColor = Color.Gainsboro;
            lblLine20.Location = new Point(419, 438);
            lblLine20.Name = "lblLine20";
            lblLine20.Size = new Size(8, 116);
            lblLine20.TabIndex = 30;
            // 
            // lblLine21
            // 
            lblLine21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLine21.BackColor = Color.Gainsboro;
            lblLine21.Location = new Point(565, 438);
            lblLine21.Name = "lblLine21";
            lblLine21.Size = new Size(8, 116);
            lblLine21.TabIndex = 31;
            // 
            // lblDot13
            // 
            lblDot13.AutoSize = true;
            lblDot13.BackColor = Color.Black;
            lblDot13.Dock = DockStyle.Fill;
            lblDot13.Location = new Point(116, 554);
            lblDot13.Margin = new Padding(0);
            lblDot13.Name = "lblDot13";
            lblDot13.Size = new Size(30, 30);
            lblDot13.TabIndex = 32;
            // 
            // lblLine22
            // 
            lblLine22.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine22.BackColor = Color.Gainsboro;
            lblLine22.Location = new Point(146, 565);
            lblLine22.Margin = new Padding(0);
            lblLine22.Name = "lblLine22";
            lblLine22.Size = new Size(116, 8);
            lblLine22.TabIndex = 33;
            // 
            // lblDot14
            // 
            lblDot14.AutoSize = true;
            lblDot14.BackColor = Color.Black;
            lblDot14.Dock = DockStyle.Fill;
            lblDot14.Location = new Point(262, 554);
            lblDot14.Margin = new Padding(0);
            lblDot14.Name = "lblDot14";
            lblDot14.Size = new Size(30, 30);
            lblDot14.TabIndex = 34;
            // 
            // lblLine23
            // 
            lblLine23.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine23.BackColor = Color.Gainsboro;
            lblLine23.Location = new Point(292, 565);
            lblLine23.Margin = new Padding(0);
            lblLine23.Name = "lblLine23";
            lblLine23.Size = new Size(116, 8);
            lblLine23.TabIndex = 35;
            // 
            // lblDot15
            // 
            lblDot15.AutoSize = true;
            lblDot15.BackColor = Color.Black;
            lblDot15.Dock = DockStyle.Fill;
            lblDot15.Location = new Point(408, 554);
            lblDot15.Margin = new Padding(0);
            lblDot15.Name = "lblDot15";
            lblDot15.Size = new Size(30, 30);
            lblDot15.TabIndex = 36;
            // 
            // lblLine24
            // 
            lblLine24.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine24.BackColor = Color.Gainsboro;
            lblLine24.Location = new Point(438, 565);
            lblLine24.Margin = new Padding(0);
            lblLine24.Name = "lblLine24";
            lblLine24.Size = new Size(116, 8);
            lblLine24.TabIndex = 37;
            // 
            // lblDot16
            // 
            lblDot16.AutoSize = true;
            lblDot16.BackColor = Color.Black;
            lblDot16.Dock = DockStyle.Fill;
            lblDot16.Location = new Point(554, 554);
            lblDot16.Margin = new Padding(0);
            lblDot16.Name = "lblDot16";
            lblDot16.Size = new Size(30, 30);
            lblDot16.TabIndex = 38;
            // 
            // lblLine10
            // 
            lblLine10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLine10.BackColor = Color.Gainsboro;
            lblLine10.Location = new Point(438, 273);
            lblLine10.Margin = new Padding(0);
            lblLine10.Name = "lblLine10";
            lblLine10.Size = new Size(116, 8);
            lblLine10.TabIndex = 16;
            // 
            // frmSquare
            // 
            AutoScaleDimensions = new SizeF(16F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 782);
            Controls.Add(tblMain);
            Font = new Font("Ravie", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 5, 7, 5);
            Name = "frmSquare";
            Text = "Square";
            tblMain.ResumeLayout(false);
            tblStartStatus.ResumeLayout(false);
            tblStartStatus.PerformLayout();
            tblGrid.ResumeLayout(false);
            tblGrid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblStartStatus;
        private Button btnStart;
        private Label lblStatus;
        private TableLayoutPanel tblGrid;
        private Label lblDot1;
        private Label lblLine1;
        private Label lblDot2;
        private Label lblLine2;
        private Label lblDot3;
        private Label lblDot4;
        private Label lblLine3;
        private Label lblLine4;
        private Label lblLine5;
        private Label lblLine6;
        private Label lblLine7;
        private Label lblDot5;
        private Label lblLine8;
        private Label lblDot6;
        private Label lblLine9;
        private Label lblDot7;
        private Label lblDot8;
        private Label lblLine11;
        private Label lblLine12;
        private Label lblLine13;
        private Label lblLine14;
        private Label lblDot9;
        private Label lblLine15;
        private Label lblDot10;
        private Label lblLine16;
        private Label lblDot11;
        private Label lblLine17;
        private Label lblDot12;
        private Label lblLine18;
        private Label lblLine19;
        private Label lblLine20;
        private Label lblLine21;
        private Label lblDot13;
        private Label lblLine22;
        private Label lblDot14;
        private Label lblLine23;
        private Label lblDot15;
        private Label lblLine24;
        private Label lblDot16;
        private Label lblLine10;
    }
}
