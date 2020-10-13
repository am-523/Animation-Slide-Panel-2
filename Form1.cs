using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//width = 205
//width = 63
namespace Animation_Slide_Panel_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool enumExpended = false;
        private void DetectMouse_Tick(object sender, EventArgs e)
        {
            if (!guna2Transition1.IsCompleted) return;
            if(pn_menu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!enumExpended)
                {
                    enumExpended = true;
                    pn_menu.Width = 205 ;
                }
            }
            else
            {
                if (enumExpended)
                {
                    enumExpended = false;
                    pn_menu.Visible = false;
                    pn_menu.Width = 63;
                    guna2Transition1.Show(pn_menu);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tabl1.Visible = false;
            tab1.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tabl1.Visible = true;
            tab1.Visible = false;
        }
    }
}
