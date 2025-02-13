namespace CSharpCamp601
{
    partial class FrmDepartment
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
            this.btnGetId = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerCreate = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetId
            // 
            this.btnGetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetId.Location = new System.Drawing.Point(173, 344);
            this.btnGetId.Name = "btnGetId";
            this.btnGetId.Size = new System.Drawing.Size(182, 42);
            this.btnGetId.TabIndex = 66;
            this.btnGetId.Text = "Id\'ye Göre Getir";
            this.btnGetId.UseVisualStyleBackColor = true;
            // 
            // dataGrid1
            // 
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(373, 37);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(396, 349);
            this.dataGrid1.TabIndex = 65;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerUpdate.Location = new System.Drawing.Point(173, 296);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerUpdate.TabIndex = 64;
            this.btnCustomerUpdate.Text = "Güncelle";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(173, 248);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerDelete.TabIndex = 63;
            this.btnCustomerDelete.Text = "Sil";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerCreate.Location = new System.Drawing.Point(173, 200);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerCreate.TabIndex = 62;
            this.btnCustomerCreate.Text = "Ekle";
            this.btnCustomerCreate.UseVisualStyleBackColor = true;
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerList.Location = new System.Drawing.Point(173, 152);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerList.TabIndex = 61;
            this.btnCustomerList.Text = "Listele";
            this.btnCustomerList.UseVisualStyleBackColor = true;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(173, 115);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerCity.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Personel Departman:";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(173, 89);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerSurname.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Personel Maaş:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(173, 63);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerName.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Personel Adı:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(173, 37);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerId.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Personel Id:";
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 477);
            this.Controls.Add(this.btnGetId);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerCreate);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.txtCustomerCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.Name = "FrmDepartment";
            this.Text = "FrmDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetId;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerCreate;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
    }
}