using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YuZongzhi0113Project3CLSApp
{
    public partial class frmCreative : Form
    {
        private Icon m_info = new Icon(SystemIcons.Information, 40, 40);
        private Icon m_error = new Icon(SystemIcons.Error, 40, 40);

        private Icon m_ready = new Icon(SystemIcons.WinLogo, 40, 40);
        public frmCreative()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtProcessedFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabSource_Click(object sender, EventArgs e)
        {

        }

        private void frmCreative_Load_1(object sender, EventArgs e)
        {
            txtSource.Text = "F:\\Creative\\Source\\";
            txtProcessedFile.Text = "F:\\Creative\\Processed\\";
            txtDest.Text = "F:\\Creative\\Destination\\";
            optGenerateLog.Checked = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSource.Text))
            {
                errMessage.SetError(txtSource, "Invalid Source Directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtSource, "");
            if (!Directory.Exists(txtDest.Text))
            {
                errMessage.SetError(txtDest, "Invalid Destination Directory");
                txtDest.Focus();
                tabControl1.SelectedTab = tabDest;
                return;
            }
            else
                errMessage.SetError(txtDest, "");
            if (!Directory.Exists(txtProcessedFile.Text))
            {
                errMessage.SetError(txtProcessedFile, "Invalid Source Directory");
                txtProcessedFile.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtProcessedFile, "");
            //watch dir
            watchDir.EnableRaisingEvents = true;
            watchDir.Path = txtSource.Text;

            //notify
            icuNotify.Icon = m_ready;
            icuNotify.Visible = true;
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDest_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtDest.Text))
            {
                txtDest.BackColor = Color.White;
            }
            else
                txtDest.BackColor = Color.Pink;
        }

        private void txtSource_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtSource.Text))
            {
                txtSource.BackColor = Color.White;
            }
            else
                txtSource.BackColor = Color.Pink;
        }

        private void txtProcessedFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtProcessedFile.Text))
            {
                txtProcessedFile.BackColor = Color.White;
            }
            else
                txtProcessedFile.BackColor = Color.Pink;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnuConfigure_Click(object sender, EventArgs e)
        {
            icuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icuNotify_DoubleClick(object sender, EventArgs e)
        {
            icuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }
    } 
    }