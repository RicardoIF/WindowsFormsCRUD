
namespace WindowsFormsCRUD
{
    partial class Form3
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
            this.pnlFormContactType = new System.Windows.Forms.Panel();
            this.lblDateContactType = new System.Windows.Forms.Label();
            this.lblContactTypeDescription = new System.Windows.Forms.Label();
            this.lblContactTypeName = new System.Windows.Forms.Label();
            this.chkStatusContactType = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactTypeDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContactType = new System.Windows.Forms.DataGridView();
            this.lblDateContactTypeUpp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDeleteContactType = new System.Windows.Forms.Button();
            this.btUpdateContactType = new System.Windows.Forms.Button();
            this.btCancelContactType = new System.Windows.Forms.Button();
            this.btSaveContactType = new System.Windows.Forms.Button();
            this.btAddContactType = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormContactType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactType)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormContactType
            // 
            this.pnlFormContactType.Controls.Add(this.lblDateContactType);
            this.pnlFormContactType.Controls.Add(this.lblContactTypeDescription);
            this.pnlFormContactType.Controls.Add(this.lblContactTypeName);
            this.pnlFormContactType.Controls.Add(this.chkStatusContactType);
            this.pnlFormContactType.Controls.Add(this.label7);
            this.pnlFormContactType.Controls.Add(this.label5);
            this.pnlFormContactType.Controls.Add(this.txtContactTypeDescription);
            this.pnlFormContactType.Controls.Add(this.label4);
            this.pnlFormContactType.Controls.Add(this.txtContactTypeName);
            this.pnlFormContactType.Controls.Add(this.label2);
            this.pnlFormContactType.Enabled = false;
            this.pnlFormContactType.Location = new System.Drawing.Point(11, 233);
            this.pnlFormContactType.Name = "pnlFormContactType";
            this.pnlFormContactType.Size = new System.Drawing.Size(514, 117);
            this.pnlFormContactType.TabIndex = 65;
            // 
            // lblDateContactType
            // 
            this.lblDateContactType.AutoSize = true;
            this.lblDateContactType.Location = new System.Drawing.Point(111, 91);
            this.lblDateContactType.Name = "lblDateContactType";
            this.lblDateContactType.Size = new System.Drawing.Size(28, 13);
            this.lblDateContactType.TabIndex = 59;
            this.lblDateContactType.Text = "-------";
            // 
            // lblContactTypeDescription
            // 
            this.lblContactTypeDescription.AutoSize = true;
            this.lblContactTypeDescription.ForeColor = System.Drawing.Color.Red;
            this.lblContactTypeDescription.Location = new System.Drawing.Point(257, 44);
            this.lblContactTypeDescription.Name = "lblContactTypeDescription";
            this.lblContactTypeDescription.Size = new System.Drawing.Size(17, 13);
            this.lblContactTypeDescription.TabIndex = 58;
            this.lblContactTypeDescription.Text = "(*)";
            this.lblContactTypeDescription.Visible = false;
            // 
            // lblContactTypeName
            // 
            this.lblContactTypeName.AutoSize = true;
            this.lblContactTypeName.ForeColor = System.Drawing.Color.Red;
            this.lblContactTypeName.Location = new System.Drawing.Point(257, 15);
            this.lblContactTypeName.Name = "lblContactTypeName";
            this.lblContactTypeName.Size = new System.Drawing.Size(17, 13);
            this.lblContactTypeName.TabIndex = 57;
            this.lblContactTypeName.Text = "(*)";
            this.lblContactTypeName.Visible = false;
            // 
            // chkStatusContactType
            // 
            this.chkStatusContactType.AutoSize = true;
            this.chkStatusContactType.Location = new System.Drawing.Point(114, 65);
            this.chkStatusContactType.Margin = new System.Windows.Forms.Padding(2);
            this.chkStatusContactType.Name = "chkStatusContactType";
            this.chkStatusContactType.Size = new System.Drawing.Size(40, 17);
            this.chkStatusContactType.TabIndex = 55;
            this.chkStatusContactType.Text = "No";
            this.chkStatusContactType.UseVisualStyleBackColor = true;
            this.chkStatusContactType.CheckedChanged += new System.EventHandler(this.chkStatusContactType_CheckedChanged);
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
            // txtContactTypeDescription
            // 
            this.txtContactTypeDescription.Location = new System.Drawing.Point(114, 37);
            this.txtContactTypeDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactTypeDescription.Name = "txtContactTypeDescription";
            this.txtContactTypeDescription.Size = new System.Drawing.Size(137, 20);
            this.txtContactTypeDescription.TabIndex = 43;
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
            // txtContactTypeName
            // 
            this.txtContactTypeName.Location = new System.Drawing.Point(114, 12);
            this.txtContactTypeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactTypeName.Name = "txtContactTypeName";
            this.txtContactTypeName.Size = new System.Drawing.Size(137, 20);
            this.txtContactTypeName.TabIndex = 39;
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
            // dgvContactType
            // 
            this.dgvContactType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactType.Location = new System.Drawing.Point(11, 69);
            this.dgvContactType.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContactType.Name = "dgvContactType";
            this.dgvContactType.RowHeadersWidth = 72;
            this.dgvContactType.RowTemplate.Height = 31;
            this.dgvContactType.Size = new System.Drawing.Size(514, 108);
            this.dgvContactType.TabIndex = 64;
            this.dgvContactType.Click += new System.EventHandler(this.dgvContactType_Click);
            // 
            // lblDateContactTypeUpp
            // 
            this.lblDateContactTypeUpp.AutoSize = true;
            this.lblDateContactTypeUpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateContactTypeUpp.Location = new System.Drawing.Point(101, 52);
            this.lblDateContactTypeUpp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateContactTypeUpp.Name = "lblDateContactTypeUpp";
            this.lblDateContactTypeUpp.Size = new System.Drawing.Size(11, 13);
            this.lblDateContactTypeUpp.TabIndex = 63;
            this.lblDateContactTypeUpp.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(11, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 36);
            this.panel1.TabIndex = 62;
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
            this.label1.Location = new System.Drawing.Point(97, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "CRUD-CREATE-READ-UPDATE-DELETE";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDeleteContactType);
            this.panel3.Controls.Add(this.btUpdateContactType);
            this.panel3.Controls.Add(this.btCancelContactType);
            this.panel3.Controls.Add(this.btSaveContactType);
            this.panel3.Controls.Add(this.btAddContactType);
            this.panel3.Location = new System.Drawing.Point(11, 355);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 36);
            this.panel3.TabIndex = 66;
            // 
            // btDeleteContactType
            // 
            this.btDeleteContactType.BackColor = System.Drawing.Color.Red;
            this.btDeleteContactType.ForeColor = System.Drawing.Color.Black;
            this.btDeleteContactType.Location = new System.Drawing.Point(425, 7);
            this.btDeleteContactType.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteContactType.Name = "btDeleteContactType";
            this.btDeleteContactType.Size = new System.Drawing.Size(81, 22);
            this.btDeleteContactType.TabIndex = 4;
            this.btDeleteContactType.Text = "Delete";
            this.btDeleteContactType.UseVisualStyleBackColor = false;
            this.btDeleteContactType.Visible = false;
            this.btDeleteContactType.Click += new System.EventHandler(this.btDeleteContactType_Click);
            // 
            // btUpdateContactType
            // 
            this.btUpdateContactType.BackColor = System.Drawing.Color.Green;
            this.btUpdateContactType.Location = new System.Drawing.Point(323, 7);
            this.btUpdateContactType.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdateContactType.Name = "btUpdateContactType";
            this.btUpdateContactType.Size = new System.Drawing.Size(81, 22);
            this.btUpdateContactType.TabIndex = 3;
            this.btUpdateContactType.Text = "Update";
            this.btUpdateContactType.UseVisualStyleBackColor = false;
            this.btUpdateContactType.Visible = false;
            this.btUpdateContactType.Click += new System.EventHandler(this.btUpdateContactType_Click);
            // 
            // btCancelContactType
            // 
            this.btCancelContactType.Enabled = false;
            this.btCancelContactType.Location = new System.Drawing.Point(227, 7);
            this.btCancelContactType.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelContactType.Name = "btCancelContactType";
            this.btCancelContactType.Size = new System.Drawing.Size(81, 22);
            this.btCancelContactType.TabIndex = 2;
            this.btCancelContactType.Text = "Cancel";
            this.btCancelContactType.UseVisualStyleBackColor = true;
            this.btCancelContactType.Click += new System.EventHandler(this.btCancelContactType_Click);
            // 
            // btSaveContactType
            // 
            this.btSaveContactType.Enabled = false;
            this.btSaveContactType.Location = new System.Drawing.Point(119, 7);
            this.btSaveContactType.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveContactType.Name = "btSaveContactType";
            this.btSaveContactType.Size = new System.Drawing.Size(81, 22);
            this.btSaveContactType.TabIndex = 1;
            this.btSaveContactType.Text = "Save";
            this.btSaveContactType.UseVisualStyleBackColor = true;
            this.btSaveContactType.Click += new System.EventHandler(this.btSaveContactType_Click);
            // 
            // btAddContactType
            // 
            this.btAddContactType.Location = new System.Drawing.Point(7, 7);
            this.btAddContactType.Margin = new System.Windows.Forms.Padding(2);
            this.btAddContactType.Name = "btAddContactType";
            this.btAddContactType.Size = new System.Drawing.Size(81, 22);
            this.btAddContactType.TabIndex = 0;
            this.btAddContactType.Text = "Add";
            this.btAddContactType.UseVisualStyleBackColor = true;
            this.btAddContactType.Click += new System.EventHandler(this.btAddContactType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsCRUD.Properties.Resources.logo_intec;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 399);
            this.Controls.Add(this.pnlFormContactType);
            this.Controls.Add(this.dgvContactType);
            this.Controls.Add(this.lblDateContactTypeUpp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlFormContactType.ResumeLayout(false);
            this.pnlFormContactType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormContactType;
        private System.Windows.Forms.Label lblDateContactType;
        private System.Windows.Forms.Label lblContactTypeDescription;
        private System.Windows.Forms.Label lblContactTypeName;
        private System.Windows.Forms.CheckBox chkStatusContactType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactTypeDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvContactType;
        private System.Windows.Forms.Label lblDateContactTypeUpp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btDeleteContactType;
        private System.Windows.Forms.Button btUpdateContactType;
        private System.Windows.Forms.Button btCancelContactType;
        private System.Windows.Forms.Button btSaveContactType;
        private System.Windows.Forms.Button btAddContactType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}