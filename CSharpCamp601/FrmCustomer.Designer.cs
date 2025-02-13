namespace CSharpCamp601
{
    partial class FrmCustomer
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
            this.btnGetId.Location = new System.Drawing.Point(145, 330);
            this.btnGetId.Name = "btnGetId";
            this.btnGetId.Size = new System.Drawing.Size(182, 42);
            this.btnGetId.TabIndex = 52;
            this.btnGetId.Text = "Id\'ye Göre Getir";
            this.btnGetId.UseVisualStyleBackColor = true;
            // 
            // dataGrid1
            // 
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(345, 23);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(806, 356);
            this.dataGrid1.TabIndex = 51;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerUpdate.Location = new System.Drawing.Point(145, 282);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerUpdate.TabIndex = 50;
            this.btnCustomerUpdate.Text = "Güncelle";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(145, 234);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerDelete.TabIndex = 49;
            this.btnCustomerDelete.Text = "Sil";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerCreate.Location = new System.Drawing.Point(145, 186);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerCreate.TabIndex = 48;
            this.btnCustomerCreate.Text = "Ekle";
            this.btnCustomerCreate.UseVisualStyleBackColor = true;
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerList.Location = new System.Drawing.Point(145, 138);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(182, 42);
            this.btnCustomerList.TabIndex = 47;
            this.btnCustomerList.Text = "Listele";
            this.btnCustomerList.UseVisualStyleBackColor = true;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(145, 101);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerCity.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Müşteri Şehir:";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(145, 75);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerSurname.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(145, 49);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Müşteri Adı:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(145, 23);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(182, 20);
            this.txtCustomerId.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Müşteri Id:";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 531);
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
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
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