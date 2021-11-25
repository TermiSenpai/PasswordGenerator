using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passGen
{
    public partial class MainForm : Form
    {
        private int heightChange = 60;
        public MainForm()
        {
            InitializeComponent();
            closeOptions();
            changeLengthValue();
        }

        #region events

        private void options_btn_Click(object sender, EventArgs e) => optionsClick();

        private void trackBar_Scroll(object sender, EventArgs e) => changeLengthValue();

        #endregion

        #region private methods

        #region options
        private void optionsClick()
        {
            switch (options_panel.Visible)
            {
                case true:
                    closeOptions();
                    Height -= heightChange;
                    break;
                case false:
                    openOptions();
                    Height += heightChange;
                    break;
            }
        }

        private void closeOptions() => options_panel.Visible = false;

        private void openOptions() => options_panel.Visible = true;
        #endregion

        #region trackBar

        private void changeLengthValue()
        {
            passLength_lbl.Text = $"Password length: {trackBar.Value.ToString()}";
        }

        #endregion

        #region genButton

        #endregion

        #region copyButton

        #endregion

        #endregion


    }
}
