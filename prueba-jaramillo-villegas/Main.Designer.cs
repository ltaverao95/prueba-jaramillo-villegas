namespace prueba_jaramillo_villegas
{
    partial class Main
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
            this.btn_init_con = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.lbl_con_result = new System.Windows.Forms.Label();
            this.btn_stop_connection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_init_con
            // 
            this.btn_init_con.Location = new System.Drawing.Point(13, 13);
            this.btn_init_con.Name = "btn_init_con";
            this.btn_init_con.Size = new System.Drawing.Size(75, 23);
            this.btn_init_con.TabIndex = 0;
            this.btn_init_con.Text = "Iniciar";
            this.btn_init_con.UseVisualStyleBackColor = true;
            this.btn_init_con.Click += new System.EventHandler(this.btn_init_con_Click);
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToAddRows = false;
            this.dataGridResults.AllowUserToDeleteRows = false;
            this.dataGridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Location = new System.Drawing.Point(13, 67);
            this.dataGridResults.MultiSelect = false;
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.ReadOnly = true;
            this.dataGridResults.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridResults.Size = new System.Drawing.Size(288, 197);
            this.dataGridResults.TabIndex = 1;
            // 
            // lbl_con_result
            // 
            this.lbl_con_result.AutoSize = true;
            this.lbl_con_result.Location = new System.Drawing.Point(13, 43);
            this.lbl_con_result.Name = "lbl_con_result";
            this.lbl_con_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_con_result.TabIndex = 2;
            // 
            // btn_stop_connection
            // 
            this.btn_stop_connection.Location = new System.Drawing.Point(95, 12);
            this.btn_stop_connection.Name = "btn_stop_connection";
            this.btn_stop_connection.Size = new System.Drawing.Size(75, 23);
            this.btn_stop_connection.TabIndex = 3;
            this.btn_stop_connection.Text = "Detener";
            this.btn_stop_connection.UseVisualStyleBackColor = true;
            this.btn_stop_connection.Click += new System.EventHandler(this.btn_stop_connection_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(313, 276);
            this.Controls.Add(this.btn_stop_connection);
            this.Controls.Add(this.lbl_con_result);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.btn_init_con);
            this.Name = "Main";
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_init_con;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Label lbl_con_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_stop_connection;
    }
}

