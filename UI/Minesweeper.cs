using Minesweeper.Layer;
using Minesweeper.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    internal partial class Minesweeper : Form
    {
        private ArenaView arenaView;

        public Minesweeper()
        {
            InitializeComponent();
            ArenaView arenaView = new ArenaView();
            this.Controls.Add(arenaView);
        }
   }
}
