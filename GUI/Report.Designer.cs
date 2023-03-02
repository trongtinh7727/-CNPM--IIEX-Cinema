using System.Windows.Forms;

namespace GUI
{
    partial class frm_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.cbb_city_picker = new System.Windows.Forms.ComboBox();
            this.lbl_baocao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(23, 116);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(90, 25);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeight = 36;
            this.dgv_user.Location = new System.Drawing.Point(12, 170);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.Size = new System.Drawing.Size(1051, 257);
            this.dgv_user.TabIndex = 1;
            // 
            // cbb_city_picker
            // 
            this.cbb_city_picker.DropDownWidth = 158;
            this.cbb_city_picker.IntegralHeight = false;
            this.cbb_city_picker.Location = new System.Drawing.Point(775, 116);
            this.cbb_city_picker.Name = "cbb_city_picker";
            this.cbb_city_picker.Size = new System.Drawing.Size(158, 24);
            this.cbb_city_picker.TabIndex = 2;
            this.cbb_city_picker.SelectedIndexChanged += new System.EventHandler(this.cbb_city_picker_SelectedIndexChanged);
            // 
            // lbl_baocao
            // 
            this.lbl_baocao.AutoSize = true;
            this.lbl_baocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baocao.Location = new System.Drawing.Point(465, 22);
            this.lbl_baocao.Name = "lbl_baocao";
            this.lbl_baocao.Size = new System.Drawing.Size(151, 38);
            this.lbl_baocao.TabIndex = 3;
            this.lbl_baocao.Text = "Báo Cáo";
            this.lbl_baocao.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 468);
            this.Controls.Add(this.lbl_baocao);
            this.Controls.Add(this.cbb_city_picker);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.btn_load);
            this.Name = "frm_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frm_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_load;
        private DataGridView dgv_user;
        private ComboBox cbb_city_picker;
        private Label lbl_baocao;
    }
}