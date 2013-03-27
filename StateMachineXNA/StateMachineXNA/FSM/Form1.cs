using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FSM_Puppies.Game;

namespace FSM_Puppies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateList()
        {
            listboxObjects.Items.Clear();
            listboxObjects.Items.AddRange(playingField.GameObjects.ToArray());
        }

        private void puppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Pets.Puppy puppy = new FSM_Puppies.Game.Pets.Puppy(playingField);
            playingField.AddGameObject(puppy);
            UpdateList();
        }

        private void ballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Toys.Ball ball = new FSM_Puppies.Game.Toys.Ball(playingField);
            playingField.AddGameObject(ball);
            UpdateList();
        }

        private void listboxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = listboxObjects.SelectedItem;
        }

        private void sleepingMatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Toys.SleepingMat mat = new FSM_Puppies.Game.Toys.SleepingMat(playingField);
            playingField.AddGameObject(mat);
            UpdateList();
        }
    }
}
