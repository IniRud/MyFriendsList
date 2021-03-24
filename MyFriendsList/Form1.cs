using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendsList
{
    public partial class Form1 : Form
    {
        List<string> myFriends = new List<string>();
        // bindingsource is an intermidiate link between a list and a listbox
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        private void btn_addFiend_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(txt_newFriend.Text);
            myFriends.Add(txt_newFriend.Text);
            // DataSource is an intermidiate step to pass information from list(myFriends) to listbox  
            //listBox1.DataSource = myFriends;
            listBox1.DataSource = bs;
            // update using the current version of the friends list
            bs.ResetBindings(false);
        }

        private void btn_addFive_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = bs;
            myFriends.Add("Lola");
            myFriends.Add("Mark");
            myFriends.Add("John");
            myFriends.Add("Frank");
            myFriends.Add("Eric");
            bs.ResetBindings(false);
        }

        private void btn_sortAsc_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
        }

        private void btn_sortDesc_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_newFriend.Clear();
            myFriends.Clear();
            bs.ResetBindings(false);
        }
    }
}
