
namespace passGen
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.passLength_lbl = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.buttons_panel = new System.Windows.Forms.Panel();
            this.GenPass_btn = new System.Windows.Forms.Button();
            this.options_btn = new System.Windows.Forms.Button();
            this.generatedPass = new System.Windows.Forms.TextBox();
            this.options_panel = new System.Windows.Forms.Panel();
            this.Lower_check = new System.Windows.Forms.CheckBox();
            this.Upper_check = new System.Windows.Forms.CheckBox();
            this.Number_check = new System.Windows.Forms.CheckBox();
            this.Symbol_check = new System.Windows.Forms.CheckBox();
            this.Copy_btn = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.buttons_panel.SuspendLayout();
            this.options_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            resources.ApplyResources(this.MainTable, "MainTable");
            this.MainTable.Controls.Add(this.passLength_lbl, 0, 0);
            this.MainTable.Controls.Add(this.trackBar, 0, 1);
            this.MainTable.Controls.Add(this.buttons_panel, 0, 2);
            this.MainTable.Controls.Add(this.generatedPass, 0, 4);
            this.MainTable.Controls.Add(this.options_panel, 0, 3);
            this.MainTable.Controls.Add(this.Copy_btn, 0, 5);
            this.MainTable.Name = "MainTable";
            // 
            // passLength_lbl
            // 
            resources.ApplyResources(this.passLength_lbl, "passLength_lbl");
            this.passLength_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.passLength_lbl.Name = "passLength_lbl";
            // 
            // trackBar
            // 
            resources.ApplyResources(this.trackBar, "trackBar");
            this.trackBar.Maximum = 72;
            this.trackBar.Minimum = 6;
            this.trackBar.Name = "trackBar";
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 6;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // buttons_panel
            // 
            this.buttons_panel.Controls.Add(this.GenPass_btn);
            this.buttons_panel.Controls.Add(this.options_btn);
            resources.ApplyResources(this.buttons_panel, "buttons_panel");
            this.buttons_panel.Name = "buttons_panel";
            // 
            // GenPass_btn
            // 
            resources.ApplyResources(this.GenPass_btn, "GenPass_btn");
            this.GenPass_btn.FlatAppearance.BorderSize = 0;
            this.GenPass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.GenPass_btn.Name = "GenPass_btn";
            this.GenPass_btn.UseVisualStyleBackColor = true;
            this.GenPass_btn.Click += new System.EventHandler(this.GenPass_btn_Click);
            // 
            // options_btn
            // 
            resources.ApplyResources(this.options_btn, "options_btn");
            this.options_btn.FlatAppearance.BorderSize = 0;
            this.options_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.options_btn.Name = "options_btn";
            this.options_btn.UseVisualStyleBackColor = true;
            this.options_btn.Click += new System.EventHandler(this.options_btn_Click);
            // 
            // generatedPass
            // 
            resources.ApplyResources(this.generatedPass, "generatedPass");
            this.generatedPass.Name = "generatedPass";
            // 
            // options_panel
            // 
            this.options_panel.Controls.Add(this.Lower_check);
            this.options_panel.Controls.Add(this.Upper_check);
            this.options_panel.Controls.Add(this.Number_check);
            this.options_panel.Controls.Add(this.Symbol_check);
            resources.ApplyResources(this.options_panel, "options_panel");
            this.options_panel.Name = "options_panel";
            // 
            // Lower_check
            // 
            resources.ApplyResources(this.Lower_check, "Lower_check");
            this.Lower_check.Checked = true;
            this.Lower_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lower_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Lower_check.Name = "Lower_check";
            this.Lower_check.UseVisualStyleBackColor = true;
            // 
            // Upper_check
            // 
            resources.ApplyResources(this.Upper_check, "Upper_check");
            this.Upper_check.Checked = true;
            this.Upper_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Upper_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Upper_check.Name = "Upper_check";
            this.Upper_check.UseVisualStyleBackColor = true;
            // 
            // Number_check
            // 
            resources.ApplyResources(this.Number_check, "Number_check");
            this.Number_check.Checked = true;
            this.Number_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Number_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Number_check.Name = "Number_check";
            this.Number_check.UseVisualStyleBackColor = true;
            // 
            // Symbol_check
            // 
            resources.ApplyResources(this.Symbol_check, "Symbol_check");
            this.Symbol_check.Checked = true;
            this.Symbol_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Symbol_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Symbol_check.Name = "Symbol_check";
            this.Symbol_check.UseVisualStyleBackColor = true;
            // 
            // Copy_btn
            // 
            this.Copy_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Copy_btn, "Copy_btn");
            this.Copy_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Copy_btn.Image = global::passGen.Properties.Resources.copy;
            this.Copy_btn.Name = "Copy_btn";
            this.Copy_btn.UseVisualStyleBackColor = true;
            this.Copy_btn.Click += new System.EventHandler(this.Copy_btn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.MainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.buttons_panel.ResumeLayout(false);
            this.options_panel.ResumeLayout(false);
            this.options_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Label passLength_lbl;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button options_btn;
        private System.Windows.Forms.Panel buttons_panel;
        private System.Windows.Forms.Button GenPass_btn;
        private System.Windows.Forms.TextBox generatedPass;
        private System.Windows.Forms.Panel options_panel;
        private System.Windows.Forms.CheckBox Lower_check;
        private System.Windows.Forms.CheckBox Upper_check;
        private System.Windows.Forms.CheckBox Number_check;
        private System.Windows.Forms.CheckBox Symbol_check;
        private System.Windows.Forms.Button Copy_btn;
    }
}

