namespace FSM_Puppies
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listboxObjects = new System.Windows.Forms.ListBox();
            this.playingField = new FSM_Puppies.Game.PlayingField();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puppyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepingMatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listboxObjects);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.playingField);
            this.splitContainer1.Size = new System.Drawing.Size(910, 644);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 0;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(10, 165);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(251, 475);
            this.propertyGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Objects:";
            // 
            // listboxObjects
            // 
            this.listboxObjects.FormattingEnabled = true;
            this.listboxObjects.Location = new System.Drawing.Point(12, 20);
            this.listboxObjects.Name = "listboxObjects";
            this.listboxObjects.Size = new System.Drawing.Size(249, 121);
            this.listboxObjects.TabIndex = 0;
            this.listboxObjects.SelectedIndexChanged += new System.EventHandler(this.listboxObjects_SelectedIndexChanged);
            // 
            // playingField
            // 
            this.playingField.BackColor = System.Drawing.Color.ForestGreen;
            this.playingField.Location = new System.Drawing.Point(0, 0);
            this.playingField.Name = "playingField";
            this.playingField.Size = new System.Drawing.Size(640, 640);
            this.playingField.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(10, 165);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(270, 475);
            this.propertyGrid1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addObjectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addObjectsToolStripMenuItem
            // 
            this.addObjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puppyToolStripMenuItem,
            this.toolStripSeparator1,
            this.ballToolStripMenuItem,
            this.sleepingMatToolStripMenuItem});
            this.addObjectsToolStripMenuItem.Name = "addObjectsToolStripMenuItem";
            this.addObjectsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addObjectsToolStripMenuItem.Text = "Add Objects";
            // 
            // puppyToolStripMenuItem
            // 
            this.puppyToolStripMenuItem.Name = "puppyToolStripMenuItem";
            this.puppyToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.puppyToolStripMenuItem.Text = "Puppy";
            this.puppyToolStripMenuItem.Click += new System.EventHandler(this.puppyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // ballToolStripMenuItem
            // 
            this.ballToolStripMenuItem.Name = "ballToolStripMenuItem";
            this.ballToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ballToolStripMenuItem.Text = "Ball";
            this.ballToolStripMenuItem.Click += new System.EventHandler(this.ballToolStripMenuItem_Click);
            // 
            // sleepingMatToolStripMenuItem
            // 
            this.sleepingMatToolStripMenuItem.Name = "sleepingMatToolStripMenuItem";
            this.sleepingMatToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sleepingMatToolStripMenuItem.Text = "Sleeping Mat";
            this.sleepingMatToolStripMenuItem.Click += new System.EventHandler(this.sleepingMatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 668);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FSM Puppies Example";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FSM_Puppies.Game.PlayingField playingField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxObjects;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puppyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepingMatToolStripMenuItem;

    }
}

