
namespace WindowsFormsCRUD
{
    partial class Form2
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
            this.pnlFormClientType = new System.Windows.Forms.Panel();
            this.lblDateClientType = new System.Windows.Forms.Label();
            this.lblClientTypeDescription = new System.Windows.Forms.Label();
            this.lblClientTypeName = new System.Windows.Forms.Label();
            this.chkStatusClientType = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientTypeDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientType = new System.Windows.Forms.DataGridView();
            this.lblDateClientTypeUpp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDeleteClientType = new System.Windows.Forms.Button();
            this.btUpdateClientType = new System.Windows.Forms.Button();
            this.btCancelClentType = new System.Windows.Forms.Button();
            this.btSaveClientType = new System.Windows.Forms.Button();
            this.btAddClientType = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormClientType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientType)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormClientType
            // 
            this.pnlFormClientType.Controls.Add(this.lblDateClientType);
            this.pnlFormClientType.Controls.Add(this.lblClientTypeDescription);
            this.pnlFormClientType.Controls.Add(this.lblClientTypeName);
            this.pnlFormClientType.Controls.Add(this.chkStatusClientType);
            this.pnlFormClientType.Controls.Add(this.label7);
            this.pnlFormClientType.Controls.Add(this.label5);
            this.pnlFormClientType.Controls.Add(this.txtClientTypeDescription);
            this.pnlFormClientType.Controls.Add(this.label4);
            this.pnlFormClientType.Controls.Add(this.txtClientTypeName);
            this.pnlFormClientType.Controls.Add(this.label2);
            this.pnlFormClientType.Enabled = false;
            this.pnlFormClientType.Location = new System.Drawing.Point(9, 230);
            this.pnlFormClientType.Name = "pnlFormClientType";
            this.pnlFormClientType.Size = new System.Drawing.Size(514, 117);
            this.pnlFormClientType.TabIndex = 58;
            // 
            // lblDateClientType
            // 
            this.lblDateClientType.AutoSize = true;
            this.lblDateClientType.Location = new System.Drawing.Point(111, 91);
            this.lblDateClientType.Name = "lblDateClientType";
            this.lblDateClientType.Size = new System.Drawing.Size(28, 13);
            this.lblDateClientType.TabIndex = 59;
            this.lblDateClientType.Text = "-------";
            // 
            // lblClientTypeDescription
            // 
            this.lblClientTypeDescription.AutoSize = true;
            this.lblClientTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblClientTypeDescription.Location = new System.Drawing.Point(257, 44);
            this.lblClientTypeDescription.Name = "lblClientTypeDescription";
            this.lblClientTypeDescription.Size = new System.Drawing.Size(17, 13);
            this.lblClientTypeDescription.TabIndex = 58;
            this.lblClientTypeDescription.Text = "(*)";
            this.lblClientTypeDescription.Visible = false;
            // 
            // lblClientTypeName
            // 
            this.lblClientTypeName.AutoSize = true;
            this.lblClientTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblClientTypeName.Location = new System.Drawing.Point(257, 15);
            this.lblClientTypeName.Name = "lblClientTypeName";
            this.lblClientTypeName.Size = new System.Drawing.Size(17, 13);
            this.lblClientTypeName.TabIndex = 57;
            this.lblClientTypeName.Text = "(*)";
            this.lblClientTypeName.Visible = false;
            // 
            // chkStatusClientType
            // 
            this.chkStatusClientType.AutoSize = true;
            this.chkStatusClientType.Location = new System.Drawing.Point(114, 65);
            this.chkStatusClientType.Margin = new System.Windows.Forms.Padding(2);
            this.chkStatusClientType.Name = "chkStatusClientType";
            this.chkStatusClientType.Size = new System.Drawing.Size(40, 17);
            this.chkStatusClientType.TabIndex = 55;
            this.chkStatusClientType.Text = "No";
            this.chkStatusClientType.UseVisualStyleBackColor = true;
            this.chkStatusClientType.CheckedChanged += new System.EventHandler(this.chkStatusClientType_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Date";
            // 
            // txtClientTypeDescription
            // 
            this.txtClientTypeDescription.Location = new System.Drawing.Point(114, 37);
            this.txtClientTypeDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientTypeDescription.Name = "txtClientTypeDescription";
            this.txtClientTypeDescription.Size = new System.Drawing.Size(137, 20);
            this.txtClientTypeDescription.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Description ";
            // 
            // txtClientTypeName
            // 
            this.txtClientTypeName.Location = new System.Drawing.Point(114, 12);
            this.txtClientTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientTypeName.Name = "txtClientTypeName";
            this.txtClientTypeName.Size = new System.Drawing.Size(137, 20);
            this.txtClientTypeName.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Client type name";
            // 
            // dgvClientType
            // 
            this.dgvClientType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientType.Location = new System.Drawing.Point(9, 66);
            this.dgvClientType.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientType.Name = "dgvClientType";
            this.dgvClientType.RowHeadersWidth = 72;
            this.dgvClientType.RowTemplate.Height = 31;
            this.dgvClientType.Size = new System.Drawing.Size(514, 108);
            this.dgvClientType.TabIndex = 57;
            this.dgvClientType.Click += new System.EventHandler(this.dgvClientType_Click);
            // 
            // lblDateClientTypeUpp
            // 
            this.lblDateClientTypeUpp.AutoSize = true;
            this.lblDateClientTypeUpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateClientTypeUpp.Location = new System.Drawing.Point(99, 49);
            this.lblDateClientTypeUpp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateClientTypeUpp.Name = "lblDateClientTypeUpp";
            this.lblDateClientTypeUpp.Size = new System.Drawing.Size(11, 13);
            this.lblDateClientTypeUpp.TabIndex = 56;
            this.lblDateClientTypeUpp.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(9, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 36);
            this.panel1.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Client Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "CRUD-CREATE-READ-UPDATE-DELETE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDeleteClientType);
            this.panel3.Controls.Add(this.btUpdateClientType);
            this.panel3.Controls.Add(this.btCancelClentType);
            this.panel3.Controls.Add(this.btSaveClientType);
            this.panel3.Controls.Add(this.btAddClientType);
            this.panel3.Location = new System.Drawing.Point(9, 352);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 36);
            this.panel3.TabIndex = 59;
            // 
            // btDeleteClientType
            // 
            this.btDeleteClientType.BackColor = System.Drawing.Color.Red;
            this.btDeleteClientType.ForeColor = System.Drawing.Color.Black;
            this.btDeleteClientType.Location = new System.Drawing.Point(425, 7);
            this.btDeleteClientType.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteClientType.Name = "btDeleteClientType";
            this.btDeleteClientType.Size = new System.Drawing.Size(81, 22);
            this.btDeleteClientType.TabIndex = 4;
            this.btDeleteClientType.Text = "Delete";
            this.btDeleteClientType.UseVisualStyleBackColor = false;
            this.btDeleteClientType.Visible = false;
            this.btDeleteClientType.Click += new System.EventHandler(this.btDeleteClientType_Click);
            // 
            // btUpdateClientType
            // 
            this.btUpdateClientType.BackColor = System.Drawing.Color.Green;
            this.btUpdateClientType.Location = new System.Drawing.Point(323, 7);
            this.btUpdateClientType.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateClientType.Name = "btUpdateClientType";
            this.btUpdateClientType.Size = new System.Drawing.Size(81, 22);
            this.btUpdateClientType.TabIndex = 3;
            this.btUpdateClientType.Text = "Update";
            this.btUpdateClientType.UseVisualStyleBackColor = false;
            this.btUpdateClientType.Visible = false;
            this.btUpdateClientType.Click += new System.EventHandler(this.btUpdateClientType_Click);
            // 
            // btCancelClentType
            // 
            this.btCancelClentType.Enabled = false;
            this.btCancelClentType.Location = new System.Drawing.Point(227, 7);
            this.btCancelClentType.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelClentType.Name = "btCancelClentType";
            this.btCancelClentType.Size = new System.Drawing.Size(81, 22);
            this.btCancelClentType.TabIndex = 2;
            this.btCancelClentType.Text = "Cancel";
            this.btCancelClentType.UseVisualStyleBackColor = true;
            this.btCancelClentType.Click += new System.EventHandler(this.btCancelClentType_Click);
            // 
            // btSaveClientType
            // 
            this.btSaveClientType.Enabled = false;
            this.btSaveClientType.Location = new System.Drawing.Point(119, 7);
            this.btSaveClientType.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveClientType.Name = "btSaveClientType";
            this.btSaveClientType.Size = new System.Drawing.Size(81, 22);
            this.btSaveClientType.TabIndex = 1;
            this.btSaveClientType.Text = "Save";
            this.btSaveClientType.UseVisualStyleBackColor = true;
            this.btSaveClientType.Click += new System.EventHandler(this.btSaveClientType_Click);
            // 
            // btAddClientType
            // 
            this.btAddClientType.Location = new System.Drawing.Point(7, 7);
            this.btAddClientType.Margin = new System.Windows.Forms.Padding(2);
            this.btAddClientType.Name = "btAddClientType";
            this.btAddClientType.Size = new System.Drawing.Size(81, 22);
            this.btAddClientType.TabIndex = 0;
            this.btAddClientType.Text = "Add";
            this.btAddClientType.UseVisualStyleBackColor = true;
            this.btAddClientType.Click += new System.EventHandler(this.btAddClientType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsCRUD.Properties.Resources.logo_intec;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 390);
            this.Controls.Add(this.pnlFormClientType);
            this.Controls.Add(this.dgvClientType);
            this.Controls.Add(this.lblDateClientTypeUpp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlFormClientType.ResumeLayout(false);
            this.pnlFormClientType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormClientType;
        private System.Windows.Forms.Label lblClientTypeDescription;
        private System.Windows.Forms.Label lblClientTypeName;
        private System.Windows.Forms.CheckBox chkStatusClientType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientTypeDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientType;
        private System.Windows.Forms.Label lblDateClientTypeUpp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btDeleteClientType;
        private System.Windows.Forms.Button btUpdateClientType;
        private System.Windows.Forms.Button btCancelClentType;
        private System.Windows.Forms.Button btSaveClientType;
        private System.Windows.Forms.Button btAddClientType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDateClientType;
    }
}