namespace MyFormsApp
{
    partial class StudentForm
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
            this.lSID = new System.Windows.Forms.Label();
            this.tbSID = new System.Windows.Forms.TextBox();
            this.lSName = new System.Windows.Forms.Label();
            this.tbSName = new System.Windows.Forms.TextBox();
            this.lSAddress = new System.Windows.Forms.Label();
            this.tbSAddress = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.pAdd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.pData = new System.Windows.Forms.Panel();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.bList = new System.Windows.Forms.Button();
            this.pAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lSID
            // 
            this.lSID.AutoSize = true;
            this.lSID.ForeColor = System.Drawing.SystemColors.Window;
            this.lSID.Location = new System.Drawing.Point(5, 14);
            this.lSID.Name = "lSID";
            this.lSID.Size = new System.Drawing.Size(58, 13);
            this.lSID.TabIndex = 0;
            this.lSID.Text = "Student ID";
            // 
            // tbSID
            // 
            this.tbSID.Location = new System.Drawing.Point(8, 30);
            this.tbSID.Name = "tbSID";
            this.tbSID.Size = new System.Drawing.Size(100, 20);
            this.tbSID.TabIndex = 1;
            // 
            // lSName
            // 
            this.lSName.AutoSize = true;
            this.lSName.ForeColor = System.Drawing.SystemColors.Window;
            this.lSName.Location = new System.Drawing.Point(5, 84);
            this.lSName.Name = "lSName";
            this.lSName.Size = new System.Drawing.Size(73, 13);
            this.lSName.TabIndex = 2;
            this.lSName.Text = "Student name";
            // 
            // tbSName
            // 
            this.tbSName.Location = new System.Drawing.Point(8, 100);
            this.tbSName.Name = "tbSName";
            this.tbSName.Size = new System.Drawing.Size(100, 20);
            this.tbSName.TabIndex = 3;
            // 
            // lSAddress
            // 
            this.lSAddress.AutoSize = true;
            this.lSAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.lSAddress.Location = new System.Drawing.Point(5, 154);
            this.lSAddress.Name = "lSAddress";
            this.lSAddress.Size = new System.Drawing.Size(84, 13);
            this.lSAddress.TabIndex = 4;
            this.lSAddress.Text = "Student address";
            // 
            // tbSAddress
            // 
            this.tbSAddress.Location = new System.Drawing.Point(8, 170);
            this.tbSAddress.Name = "tbSAddress";
            this.tbSAddress.Size = new System.Drawing.Size(100, 20);
            this.tbSAddress.TabIndex = 5;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(24, 240);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Save";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // pAdd
            // 
            this.pAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.pAdd.Controls.Add(this.bAdd);
            this.pAdd.Controls.Add(this.tbSAddress);
            this.pAdd.Controls.Add(this.lSAddress);
            this.pAdd.Controls.Add(this.tbSName);
            this.pAdd.Controls.Add(this.lSName);
            this.pAdd.Controls.Add(this.tbSID);
            this.pAdd.Controls.Add(this.lSID);
            this.pAdd.Location = new System.Drawing.Point(7, 9);
            this.pAdd.Name = "pAdd";
            this.pAdd.Size = new System.Drawing.Size(120, 276);
            this.pAdd.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.bList);
            this.panel1.Controls.Add(this.bUpdate);
            this.panel1.Controls.Add(this.bSearch);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Location = new System.Drawing.Point(145, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 276);
            this.panel1.TabIndex = 10;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(22, 240);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(22, 100);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 9;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(22, 170);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 10;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // pData
            // 
            this.pData.BackColor = System.Drawing.SystemColors.Highlight;
            this.pData.Controls.Add(this.dgvData);
            this.pData.Controls.Add(this.rtbData);
            this.pData.Location = new System.Drawing.Point(281, 9);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(539, 276);
            this.pData.TabIndex = 11;
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(16, 14);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(508, 249);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(30, 30);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(480, 222);
            this.dgvData.TabIndex = 1;
            // 
            // bList
            // 
            this.bList.Location = new System.Drawing.Point(22, 30);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(75, 23);
            this.bList.TabIndex = 9;
            this.bList.Text = "List";
            this.bList.UseVisualStyleBackColor = true;
            this.bList.Click += new System.EventHandler(this.bList_Click_1);
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(832, 293);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pAdd);
            this.Name = "StudentForm";
            this.pAdd.ResumeLayout(false);
            this.pAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSID;
        private System.Windows.Forms.TextBox tbSID;
        private System.Windows.Forms.Label lSName;
        private System.Windows.Forms.TextBox tbSName;
        private System.Windows.Forms.Label lSAddress;
        private System.Windows.Forms.TextBox tbSAddress;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Panel pAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button bList;
    }
}

