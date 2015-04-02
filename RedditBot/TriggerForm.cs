﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedditBot
{
    public partial class TriggerForm : Form
    {
        private Main parent;

        public TriggerForm(Main parent)
        {
            InitializeComponent();
            this.parent = parent;
            searchTextBox.Text = Properties.Settings.Default["trigger"].ToString();
            subredditTextBox.Text = Properties.Settings.Default["subreddit"].ToString();
            titleSearch.Checked = (bool)Properties.Settings.Default["searchTitles"];
            postSearch.Checked = (bool)Properties.Settings.Default["searchPosts"];
            commentSearch.Checked = (bool)Properties.Settings.Default["searchComments"];
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["trigger"] = searchTextBox.Text;
            Properties.Settings.Default["subreddit"] = subredditTextBox.Text;
            Properties.Settings.Default["searchPosts"] = postSearch.Checked;
            Properties.Settings.Default["searchComments"] = commentSearch.Checked;
            Properties.Settings.Default["searchTitles"] = titleSearch.Checked;
            Properties.Settings.Default.Save();
            parent.formConsole("Trigger settings successfully updated.");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            parent.formConsole("Trigger settings not saved.");
            this.Close();
        }

        private void advanced_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently in development.");
        }

        private void messageSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (messageSearch.Checked) { MessageBox.Show("Currently in development."); }
            messageSearch.Checked = false;
        }
    }
}
