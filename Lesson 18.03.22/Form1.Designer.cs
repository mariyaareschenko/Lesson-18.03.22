
namespace Lesson_18._03._22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Christian = new System.Windows.Forms.TabPage();
            this.ChristianTable = new System.Windows.Forms.DataGridView();
            this.Muslim = new System.Windows.Forms.TabPage();
            this.MuslimTable = new System.Windows.Forms.DataGridView();
            this.Security = new System.Windows.Forms.TabPage();
            this.SecurityTable = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Christian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChristianTable)).BeginInit();
            this.Muslim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuslimTable)).BeginInit();
            this.Security.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Christian);
            this.tabControl1.Controls.Add(this.Muslim);
            this.tabControl1.Controls.Add(this.Security);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Christian
            // 
            this.Christian.Controls.Add(this.ChristianTable);
            this.Christian.Location = new System.Drawing.Point(4, 29);
            this.Christian.Name = "Christian";
            this.Christian.Padding = new System.Windows.Forms.Padding(3);
            this.Christian.Size = new System.Drawing.Size(792, 417);
            this.Christian.TabIndex = 0;
            this.Christian.Text = "Христианские кладбища";
            this.Christian.UseVisualStyleBackColor = true;
            // 
            // ChristianTable
            // 
            this.ChristianTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChristianTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChristianTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChristianTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChristianTable.Location = new System.Drawing.Point(3, 3);
            this.ChristianTable.Name = "ChristianTable";
            this.ChristianTable.RowHeadersWidth = 51;
            this.ChristianTable.RowTemplate.Height = 29;
            this.ChristianTable.Size = new System.Drawing.Size(786, 411);
            this.ChristianTable.TabIndex = 0;
            // 
            // Muslim
            // 
            this.Muslim.Controls.Add(this.MuslimTable);
            this.Muslim.Location = new System.Drawing.Point(4, 29);
            this.Muslim.Name = "Muslim";
            this.Muslim.Padding = new System.Windows.Forms.Padding(3);
            this.Muslim.Size = new System.Drawing.Size(792, 417);
            this.Muslim.TabIndex = 1;
            this.Muslim.Text = "Мусульманские кладбища";
            this.Muslim.UseVisualStyleBackColor = true;
            // 
            // MuslimTable
            // 
            this.MuslimTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MuslimTable.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.MuslimTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MuslimTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MuslimTable.Location = new System.Drawing.Point(3, 3);
            this.MuslimTable.Name = "MuslimTable";
            this.MuslimTable.RowHeadersWidth = 51;
            this.MuslimTable.RowTemplate.Height = 29;
            this.MuslimTable.Size = new System.Drawing.Size(786, 411);
            this.MuslimTable.TabIndex = 0;
            // 
            // Security
            // 
            this.Security.Controls.Add(this.SecurityTable);
            this.Security.Location = new System.Drawing.Point(4, 29);
            this.Security.Name = "Security";
            this.Security.Size = new System.Drawing.Size(792, 417);
            this.Security.TabIndex = 2;
            this.Security.Text = "Охранники";
            this.Security.UseVisualStyleBackColor = true;
            // 
            // SecurityTable
            // 
            this.SecurityTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SecurityTable.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.SecurityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecurityTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecurityTable.Location = new System.Drawing.Point(0, 0);
            this.SecurityTable.Name = "SecurityTable";
            this.SecurityTable.RowHeadersWidth = 51;
            this.SecurityTable.RowTemplate.Height = 29;
            this.SecurityTable.Size = new System.Drawing.Size(792, 417);
            this.SecurityTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Christian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChristianTable)).EndInit();
            this.Muslim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MuslimTable)).EndInit();
            this.Security.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecurityTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Christian;
        private System.Windows.Forms.DataGridView ChristianTable;
        private System.Windows.Forms.TabPage Muslim;
        private System.Windows.Forms.TabPage Security;
        private System.Windows.Forms.DataGridView MuslimTable;
        private System.Windows.Forms.DataGridView SecurityTable;
    }
}

