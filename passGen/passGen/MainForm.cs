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
        bussinessLogicLayer _bussinessLogicLayer = new bussinessLogicLayer();
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

        private void GenPass_btn_Click(object sender, EventArgs e) => genPass();

        private void Copy_btn_Click(object sender, EventArgs e) => copy();

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

        private void genPass()
        {
            string pass;
            pass = _bussinessLogicLayer.genPass(trackBar.Value);

            generatedPass.Text = pass;
        }

        #endregion

        #region copyButton

        private void copy()
        {
            string pass = generatedPass.Text;
            Clipboard.SetText(pass);
        }

        #endregion

        #endregion

        
    }
}
