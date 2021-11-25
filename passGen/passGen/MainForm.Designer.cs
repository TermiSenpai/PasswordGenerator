
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
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.passLength_lbl, 0, 0);
            this.MainTable.Controls.Add(this.trackBar, 0, 1);
            this.MainTable.Controls.Add(this.buttons_panel, 0, 2);
            this.MainTable.Controls.Add(this.generatedPass, 0, 4);
            this.MainTable.Controls.Add(this.options_panel, 0, 3);
            this.MainTable.Controls.Add(this.Copy_btn, 0, 5);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 6;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainTable.Size = new System.Drawing.Size(284, 251);
            this.MainTable.TabIndex = 0;
            // 
            // passLength_lbl
            // 
            this.passLength_lbl.AutoSize = true;
            this.passLength_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLength_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.passLength_lbl.Location = new System.Drawing.Point(5, 10);
            this.passLength_lbl.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.passLength_lbl.Name = "passLength_lbl";
            this.passLength_lbl.Size = new System.Drawing.Size(198, 29);
            this.passLength_lbl.TabIndex = 0;
            this.passLength_lbl.Text = "Password length:";
            this.passLength_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar.Location = new System.Drawing.Point(5, 55);
            this.trackBar.Margin = new System.Windows.Forms.Padding(5);
            this.trackBar.Maximum = 72;
            this.trackBar.Minimum = 6;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(274, 20);
            this.trackBar.TabIndex = 1;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 6;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // buttons_panel
            // 
            this.buttons_panel.Controls.Add(this.GenPass_btn);
            this.buttons_panel.Controls.Add(this.options_btn);
            this.buttons_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons_panel.Location = new System.Drawing.Point(3, 83);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.Size = new System.Drawing.Size(278, 31);
            this.buttons_panel.TabIndex = 4;
            // 
            // GenPass_btn
            // 
            this.GenPass_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.GenPass_btn.FlatAppearance.BorderSize = 0;
            this.GenPass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenPass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenPass_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.GenPass_btn.Location = new System.Drawing.Point(150, 0);
            this.GenPass_btn.Margin = new System.Windows.Forms.Padding(10);
            this.GenPass_btn.Name = "GenPass_btn";
            this.GenPass_btn.Size = new System.Drawing.Size(128, 31);
            this.GenPass_btn.TabIndex = 3;
            this.GenPass_btn.Text = "Generar";
            this.GenPass_btn.UseVisualStyleBackColor = true;
            this.GenPass_btn.Click += new System.EventHandler(this.GenPass_btn_Click);
            // 
            // options_btn
            // 
            this.options_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.options_btn.FlatAppearance.BorderSize = 0;
            this.options_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.options_btn.Location = new System.Drawing.Point(0, 0);
            this.options_btn.Margin = new System.Windows.Forms.Padding(10);
            this.options_btn.Name = "options_btn";
            this.options_btn.Size = new System.Drawing.Size(150, 31);
            this.options_btn.TabIndex = 2;
            this.options_btn.Text = "Options";
            this.options_btn.UseVisualStyleBackColor = true;
            this.options_btn.Click += new System.EventHandler(this.options_btn_Click);
            // 
            // generatedPass
            // 
            this.generatedPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.generatedPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPass.Location = new System.Drawing.Point(3, 226);
            this.generatedPass.Name = "generatedPass";
            this.generatedPass.Size = new System.Drawing.Size(278, 26);
            this.generatedPass.TabIndex = 5;
            // 
            // options_panel
            // 
            this.options_panel.Controls.Add(this.Lower_check);
            this.options_panel.Controls.Add(this.Upper_check);
            this.options_panel.Controls.Add(this.Number_check);
            this.options_panel.Controls.Add(this.Symbol_check);
            this.options_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.options_panel.Location = new System.Drawing.Point(3, 120);
            this.options_panel.Name = "options_panel";
            this.options_panel.Size = new System.Drawing.Size(278, 100);
            this.options_panel.TabIndex = 6;
            // 
            // Lower_check
            // 
            this.Lower_check.AutoSize = true;
            this.Lower_check.Checked = true;
            this.Lower_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Lower_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lower_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Lower_check.Location = new System.Drawing.Point(0, 63);
            this.Lower_check.Name = "Lower_check";
            this.Lower_check.Size = new System.Drawing.Size(278, 21);
            this.Lower_check.TabIndex = 3;
            this.Lower_check.Text = "LoweCase";
            this.Lower_check.UseVisualStyleBackColor = true;
            // 
            // Upper_check
            // 
            this.Upper_check.AutoSize = true;
            this.Upper_check.Checked = true;
            this.Upper_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Upper_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.Upper_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Upper_check.Location = new System.Drawing.Point(0, 42);
            this.Upper_check.Name = "Upper_check";
            this.Upper_check.Size = new System.Drawing.Size(278, 21);
            this.Upper_check.TabIndex = 2;
            this.Upper_check.Text = "UpperCase";
            this.Upper_check.UseVisualStyleBackColor = true;
            // 
            // Number_check
            // 
            this.Number_check.AutoSize = true;
            this.Number_check.Checked = true;
            this.Number_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Number_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.Number_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Number_check.Location = new System.Drawing.Point(0, 21);
            this.Number_check.Name = "Number_check";
            this.Number_check.Size = new System.Drawing.Size(278, 21);
            this.Number_check.TabIndex = 1;
            this.Number_check.Text = "Numbers";
            this.Number_check.UseVisualStyleBackColor = true;
            // 
            // Symbol_check
            // 
            this.Symbol_check.AutoSize = true;
            this.Symbol_check.Checked = true;
            this.Symbol_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Symbol_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.Symbol_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Symbol_check.Location = new System.Drawing.Point(0, 0);
            this.Symbol_check.Name = "Symbol_check";
            this.Symbol_check.Size = new System.Drawing.Size(278, 21);
            this.Symbol_check.TabIndex = 0;
            this.Symbol_check.Text = "Symbols";
            this.Symbol_check.UseVisualStyleBackColor = true;
            // 
            // Copy_btn
            // 
            this.Copy_btn.FlatAppearance.BorderSize = 0;
            this.Copy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Copy_btn.Image = global::passGen.Properties.Resources.copy;
            this.Copy_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Copy_btn.Location = new System.Drawing.Point(3, 258);
            this.Copy_btn.Name = "Copy_btn";
            this.Copy_btn.Size = new System.Drawing.Size(90, 44);
            this.Copy_btn.TabIndex = 7;
            this.Copy_btn.Text = "Copy";
            this.Copy_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Copy_btn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(284, 251);
            this.Controls.Add(this.MainTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
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

