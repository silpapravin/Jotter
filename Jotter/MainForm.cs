using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jotter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Note noteobj = new Note();
        List<Note> notelist = new List<Note>();
        ListBox lb = new ListBox();
        private void buttonaddnote_Click(object sender, EventArgs e)
        {
             // MessageBox.Show("Adding new Note","TODO",MessageBoxButtons.OK,MessageBoxIcon.Information);

           
            
            noteobj.Title = txttitle.Text;
            noteobj.NoteText = txtnote.Text;
            notelist.Add(noteobj);
            int count = notelist.Count;
            lblnount.Text = count.ToString();
            lb.Items.Add(txtnote.Text);
            foreach (var item in notelist)
            {
                txtnote.Text = item.NoteText;
                
            }
        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Event Raised",$"Text changed: {e.ToString()}",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
