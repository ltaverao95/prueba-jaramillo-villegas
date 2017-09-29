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
            this.components = new System.ComponentModel.Container();
            this.btn_init_con = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.lbl_con_result = new System.Windows.Forms.Label();
            this.btn_stop_connection = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back_main = new System.Windows.Forms.Button();
            this.dataGridResultQuery = new System.Windows.Forms.DataGridView();
            this.variableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basculaDataSet = new prueba_jaramillo_villegas.BasculaDataSet();
            this.variableTableAdapter = new prueba_jaramillo_villegas.BasculaDataSetTableAdapters.VariableTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_duplicados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).BeginInit();
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
            this.dataGridResults.Location = new System.Drawing.Point(12, 43);
            this.dataGridResults.MultiSelect = false;
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.ReadOnly = true;
            this.dataGridResults.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridResults.Size = new System.Drawing.Size(434, 197);
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
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(13, 257);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Reporte";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back_main);
            this.panel1.Controls.Add(this.dataGridResultQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 291);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // btn_back_main
            // 
            this.btn_back_main.Location = new System.Drawing.Point(12, 244);
            this.btn_back_main.Name = "btn_back_main";
            this.btn_back_main.Size = new System.Drawing.Size(75, 23);
            this.btn_back_main.TabIndex = 1;
            this.btn_back_main.Text = "Volver";
            this.btn_back_main.UseVisualStyleBackColor = true;
            this.btn_back_main.Click += new System.EventHandler(this.btn_back_main_Click);
            // 
            // dataGridResultQuery
            // 
            this.dataGridResultQuery.AllowUserToAddRows = false;
            this.dataGridResultQuery.AllowUserToDeleteRows = false;
            this.dataGridResultQuery.AutoGenerateColumns = false;
            this.dataGridResultQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.variableSent,
            this.dateSent,
            this.cantidad_duplicados});
            this.dataGridResultQuery.DataSource = this.variableBindingSource;
            this.dataGridResultQuery.Location = new System.Drawing.Point(12, 12);
            this.dataGridResultQuery.MultiSelect = false;
            this.dataGridResultQuery.Name = "dataGridResultQuery";
            this.dataGridResultQuery.ReadOnly = true;
            this.dataGridResultQuery.Size = new System.Drawing.Size(444, 226);
            this.dataGridResultQuery.TabIndex = 0;
            this.dataGridResultQuery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResultQuery_CellContentClick);
            // 
            // variableBindingSource
            // 
            this.variableBindingSource.DataMember = "Variable";
            this.variableBindingSource.DataSource = this.basculaDataSet;
            // 
            // basculaDataSet
            // 
            this.basculaDataSet.DataSetName = "BasculaDataSet";
            this.basculaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // variableTableAdapter
            // 
            this.variableTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // variableSent
            // 
            this.variableSent.DataPropertyName = "variableSent";
            this.variableSent.HeaderText = "variableSent";
            this.variableSent.Name = "variableSent";
            this.variableSent.ReadOnly = true;
            // 
            // dateSent
            // 
            this.dateSent.DataPropertyName = "dateSent";
            this.dateSent.HeaderText = "dateSent";
            this.dateSent.Name = "dateSent";
            this.dateSent.ReadOnly = true;
            // 
            // cantidad_duplicados
            // 
            this.cantidad_duplicados.DataPropertyName = "cantidad_duplicados";
            this.cantidad_duplicados.HeaderText = "cantidad_duplicados";
            this.cantidad_duplicados.Name = "cantidad_duplicados";
            this.cantidad_duplicados.ReadOnly = true;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(470, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_stop_connection);
            this.Controls.Add(this.lbl_con_result);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.btn_init_con);
            this.Name = "Main";
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basculaDataSet)).EndInit();
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
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back_main;
        private System.Windows.Forms.DataGridView dataGridResultQuery;
        private BasculaDataSet basculaDataSet;
        private System.Windows.Forms.BindingSource variableBindingSource;
        private BasculaDataSetTableAdapters.VariableTableAdapter variableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_duplicados;
    }
}

