
namespace EWSMoveMails
{
    partial class FormMain
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
            this.groupBox_Onprem = new System.Windows.Forms.GroupBox();
            this.txt_OnpremPwd = new System.Windows.Forms.TextBox();
            this.txt_OnpremUser = new System.Windows.Forms.TextBox();
            this.txt_OnpremDomain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_OnpremEWSUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Run = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ImpersonatedUserSMTP = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.pb_Progress = new System.Windows.Forms.ProgressBar();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.lbl_AlertMailbox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_SourceFolder = new System.Windows.Forms.DataGridView();
            this.folderDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderDS = new EWSMoveMails.FolderDS();
            this.dgv_TargetFolder = new System.Windows.Forms.DataGridView();
            this.folderDTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.folderNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Onprem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SourceFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TargetFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderDTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Onprem
            // 
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremPwd);
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremUser);
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremDomain);
            this.groupBox_Onprem.Controls.Add(this.label5);
            this.groupBox_Onprem.Controls.Add(this.label4);
            this.groupBox_Onprem.Controls.Add(this.label3);
            this.groupBox_Onprem.Controls.Add(this.label2);
            this.groupBox_Onprem.Controls.Add(this.txt_OnpremEWSUrl);
            this.groupBox_Onprem.Controls.Add(this.label1);
            this.groupBox_Onprem.Location = new System.Drawing.Point(15, 33);
            this.groupBox_Onprem.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Onprem.Name = "groupBox_Onprem";
            this.groupBox_Onprem.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Onprem.Size = new System.Drawing.Size(362, 129);
            this.groupBox_Onprem.TabIndex = 0;
            this.groupBox_Onprem.TabStop = false;
            // 
            // txt_OnpremPwd
            // 
            this.txt_OnpremPwd.Location = new System.Drawing.Point(88, 62);
            this.txt_OnpremPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txt_OnpremPwd.Name = "txt_OnpremPwd";
            this.txt_OnpremPwd.PasswordChar = '*';
            this.txt_OnpremPwd.Size = new System.Drawing.Size(267, 20);
            this.txt_OnpremPwd.TabIndex = 5;
            // 
            // txt_OnpremUser
            // 
            this.txt_OnpremUser.Location = new System.Drawing.Point(88, 40);
            this.txt_OnpremUser.Margin = new System.Windows.Forms.Padding(2);
            this.txt_OnpremUser.Name = "txt_OnpremUser";
            this.txt_OnpremUser.Size = new System.Drawing.Size(267, 20);
            this.txt_OnpremUser.TabIndex = 5;
            // 
            // txt_OnpremDomain
            // 
            this.txt_OnpremDomain.Location = new System.Drawing.Point(88, 17);
            this.txt_OnpremDomain.Margin = new System.Windows.Forms.Padding(2);
            this.txt_OnpremDomain.Name = "txt_OnpremDomain";
            this.txt_OnpremDomain.Size = new System.Drawing.Size(267, 20);
            this.txt_OnpremDomain.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "User or SMTP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domain: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Esp: https://ex1601.contoso.com/EWS/Exchange.asmx";
            // 
            // txt_OnpremEWSUrl
            // 
            this.txt_OnpremEWSUrl.Location = new System.Drawing.Point(63, 85);
            this.txt_OnpremEWSUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_OnpremEWSUrl.Name = "txt_OnpremEWSUrl";
            this.txt_OnpremEWSUrl.Size = new System.Drawing.Size(292, 20);
            this.txt_OnpremEWSUrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EWS Url: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(315, 563);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(183, 30);
            this.btn_Run.TabIndex = 7;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_ImpersonatedUserSMTP);
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Location = new System.Drawing.Point(1, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 158);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Impersonated User SMTP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Admin Signin";
            // 
            // txt_ImpersonatedUserSMTP
            // 
            this.txt_ImpersonatedUserSMTP.Location = new System.Drawing.Point(404, 45);
            this.txt_ImpersonatedUserSMTP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ImpersonatedUserSMTP.Name = "txt_ImpersonatedUserSMTP";
            this.txt_ImpersonatedUserSMTP.Size = new System.Drawing.Size(267, 20);
            this.txt_ImpersonatedUserSMTP.TabIndex = 5;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(451, 90);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(183, 30);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // pb_Progress
            // 
            this.pb_Progress.Location = new System.Drawing.Point(15, 555);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(775, 5);
            this.pb_Progress.TabIndex = 11;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Location = new System.Drawing.Point(790, 550);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(21, 13);
            this.lbl_Progress.TabIndex = 12;
            this.lbl_Progress.Text = "0%";
            // 
            // lbl_AlertMailbox
            // 
            this.lbl_AlertMailbox.AutoSize = true;
            this.lbl_AlertMailbox.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlertMailbox.Location = new System.Drawing.Point(134, 273);
            this.lbl_AlertMailbox.Name = "lbl_AlertMailbox";
            this.lbl_AlertMailbox.Size = new System.Drawing.Size(10, 13);
            this.lbl_AlertMailbox.TabIndex = 13;
            this.lbl_AlertMailbox.Text = "!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Source Folder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Target Folder";
            // 
            // dgv_SourceFolder
            // 
            this.dgv_SourceFolder.AllowUserToAddRows = false;
            this.dgv_SourceFolder.AllowUserToDeleteRows = false;
            this.dgv_SourceFolder.AutoGenerateColumns = false;
            this.dgv_SourceFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SourceFolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folderNameDataGridViewTextBoxColumn,
            this.FolderId,
            this.ItemsCount});
            this.dgv_SourceFolder.DataSource = this.folderDTBindingSource;
            this.dgv_SourceFolder.Location = new System.Drawing.Point(15, 186);
            this.dgv_SourceFolder.Name = "dgv_SourceFolder";
            this.dgv_SourceFolder.ReadOnly = true;
            this.dgv_SourceFolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SourceFolder.Size = new System.Drawing.Size(376, 363);
            this.dgv_SourceFolder.TabIndex = 16;
            // 
            // folderDTBindingSource
            // 
            this.folderDTBindingSource.DataMember = "FolderDT";
            this.folderDTBindingSource.DataSource = this.folderDS;
            // 
            // folderDS
            // 
            this.folderDS.DataSetName = "FolderDS";
            this.folderDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_TargetFolder
            // 
            this.dgv_TargetFolder.AllowUserToAddRows = false;
            this.dgv_TargetFolder.AllowUserToDeleteRows = false;
            this.dgv_TargetFolder.AutoGenerateColumns = false;
            this.dgv_TargetFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TargetFolder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folderNameColumn,
            this.FolderIdColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgv_TargetFolder.DataSource = this.folderDTBindingSource1;
            this.dgv_TargetFolder.Location = new System.Drawing.Point(416, 186);
            this.dgv_TargetFolder.Name = "dgv_TargetFolder";
            this.dgv_TargetFolder.ReadOnly = true;
            this.dgv_TargetFolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TargetFolder.Size = new System.Drawing.Size(376, 363);
            this.dgv_TargetFolder.TabIndex = 16;
            // 
            // folderDTBindingSource1
            // 
            this.folderDTBindingSource1.DataMember = "FolderDT";
            this.folderDTBindingSource1.DataSource = this.folderDS;
            // 
            // folderNameColumn
            // 
            this.folderNameColumn.DataPropertyName = "FolderName";
            this.folderNameColumn.FillWeight = 270F;
            this.folderNameColumn.HeaderText = "FolderName";
            this.folderNameColumn.Name = "folderNameColumn";
            this.folderNameColumn.ReadOnly = true;
            this.folderNameColumn.Width = 270;
            // 
            // FolderIdColumn
            // 
            this.FolderIdColumn.DataPropertyName = "FolderId";
            this.FolderIdColumn.HeaderText = "FolderId";
            this.FolderIdColumn.Name = "FolderIdColumn";
            this.FolderIdColumn.ReadOnly = true;
            this.FolderIdColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemsCount";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemsCount";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // folderNameDataGridViewTextBoxColumn
            // 
            this.folderNameDataGridViewTextBoxColumn.DataPropertyName = "FolderName";
            this.folderNameDataGridViewTextBoxColumn.FillWeight = 270F;
            this.folderNameDataGridViewTextBoxColumn.HeaderText = "FolderName";
            this.folderNameDataGridViewTextBoxColumn.Name = "folderNameDataGridViewTextBoxColumn";
            this.folderNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.folderNameDataGridViewTextBoxColumn.Width = 260;
            // 
            // FolderId
            // 
            this.FolderId.DataPropertyName = "FolderId";
            this.FolderId.HeaderText = "FolderId";
            this.FolderId.Name = "FolderId";
            this.FolderId.ReadOnly = true;
            this.FolderId.Visible = false;
            // 
            // ItemsCount
            // 
            this.ItemsCount.DataPropertyName = "ItemsCount";
            this.ItemsCount.HeaderText = "ItemsCount";
            this.ItemsCount.Name = "ItemsCount";
            this.ItemsCount.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 603);
            this.Controls.Add(this.dgv_TargetFolder);
            this.Controls.Add(this.dgv_SourceFolder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_AlertMailbox);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.pb_Progress);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.groupBox_Onprem);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "EWSMoveMails";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_Onprem.ResumeLayout(false);
            this.groupBox_Onprem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SourceFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TargetFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderDTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Onprem;
        private System.Windows.Forms.TextBox txt_OnpremPwd;
        private System.Windows.Forms.TextBox txt_OnpremUser;
        private System.Windows.Forms.TextBox txt_OnpremDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_OnpremEWSUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pb_Progress;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.Label lbl_AlertMailbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ImpersonatedUserSMTP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.DataGridView dgv_SourceFolder;
        private System.Windows.Forms.DataGridView dgv_TargetFolder;
        private System.Windows.Forms.BindingSource folderDTBindingSource;
        private FolderDS folderDS;
        private System.Windows.Forms.BindingSource folderDTBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

