﻿using D3MemDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeeThreeComptroller
{
    public partial class MonitorScreen : Form
    {
        private ObjectManagerMemContainer data;

        public MonitorScreen()
        {
            InitializeComponent();
        }

        public MonitorScreen(ObjectManagerMemContainer data) 
        {
            InitializeComponent();
            this.data = data;
        }

        private void RefreshAllButton_Click(object sender, EventArgs e)
        {
            this.CharacterNameTextBox.Text = this.data.Player.CharacterName;
            this.ClassTextBox.Text = this.data.Player.CharacterClass.ToString();
            this.LevelAreaTextBox.Text = this.data.Player.LevelArea.DisplayName;
            this.ACDCountTextBox.Text = this.data.ACDs.ACDCount.ToString();

            this.ACDListBox.Items.Clear();
            foreach (var acd in this.data.ACDs.ACDList)
            {
                this.ACDListBox.Items.Add(acd);
            }
        }
    }
}