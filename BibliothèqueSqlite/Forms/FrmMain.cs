using BibliothèqueSqlite.User_Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliothèqueSqlite.Forms
{
    public partial class FrmMain : Form
    {
        private Point mouseLocation;
        public static FrmMain _Instance;
        public static FrmMain Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new FrmMain();
                return _Instance;
            }
        }
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (P_MB.Width >= 160)
            {
                P_MB.Width = 40;
                label4.Visible = false;
            }
            else
            {
                P_MB.Width = 160;
                label4.Visible = true;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Button myBtn = ((Button)(Control)sender);
            P_Mark.Top = myBtn.Top;
            OpenForm(myBtn.Tag.ToString());
        }
        void OpenForm(string frmName)
        {
            Form frm;
            switch (frmName)
            {
                case "Home":
                    frm = new UserMain();
                    break;

                case "Books":
                    frm = new FrmListBooks();
                    break;

                case "Students":
                    frm = new FrmListStudents();
                    break;

                case "Borrow":
                    frm = new FrmListLoan();
                    break;

                case "User":
                    frm = new FrmLogin(false);
                    break;

                default:
                    frm = new UserMain();
                    break;
            }
            addPage(frm);
        }

        void addPage(Form frm)
        {
            foreach (TabPage page in tabContiner.TabPages)
            {
                if (page.Tag == frm.Tag)
                {
                    tabContiner.SelectTab(page);
                    return;
                }
            }
            TabPage newPage = new TabPage(frm.Text + new string(' ', 20 - frm.Text.Length) + "x");
            newPage.Tag = frm.Tag;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            newPage.Controls.Add(frm);
            frm.Show();

            tabContiner.TabPages.Add(newPage);
            tabContiner.SelectTab(newPage);
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState =  FormWindowState.Normal;
        }

        private void panelHeder_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            panelHeder.Cursor = Cursors.SizeAll;
        }

        private void panelHeder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void panelHeder_MouseUp(object sender, MouseEventArgs e)
        {
            panelHeder.Cursor = Cursors.Default;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmInfo frmInfo = new FrmInfo();
            frmInfo.ShowDialog();
        }

        private void panelHeder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void tabContiner_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabContiner.TabCount; i++)
            {
                Rectangle rect = tabContiner.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.X + rect.Width - 18, rect.Y, 18, rect.Height);

                if (imageRec.Contains(e.Location) && tabContiner.SelectedIndex != 0)
                {
                    tabContiner.TabPages.Remove(tabContiner.SelectedTab);
                    return;
                }
                else if(rect.Contains(e.Location))
                {
                    switch (tabContiner.SelectedTab.Tag)
                    {
                        case "Home":
                            P_Mark.Top = btnHome.Top;
                            break;

                        case "Books":
                            P_Mark.Top = btnBooks.Top;
                            break;

                        case "Students":
                            P_Mark.Top = btnStudents.Top;
                            break;

                        case "Borrow":
                            P_Mark.Top = btnBorrow.Top;
                            break;

                        case "User":
                            P_Mark.Top = btnUser.Top;
                            break;

                        default:
                            P_Mark.Top = btnHome.Top;
                            break;
                    }
                }
            }
        }
    }
}
