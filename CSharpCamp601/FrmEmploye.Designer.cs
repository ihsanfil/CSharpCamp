namespace CSharpCamp601
{
    partial class FrmEmploye
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
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtEmpDep = new System.Windows.Forms.Label();
            this.txtEmpMaas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetId
            // 
            this.btnGetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetId.Location = new System.Drawing.Point(183, 382);
            this.btnGetId.Name = "btnGetId";
            this.btnGetId.Size = new System.Drawing.Size(182, 42);
            this.btnGetId.TabIndex = 80;
            this.btnGetId.Text = "Id\'ye Göre Getir";
            this.btnGetId.UseVisualStyleBackColor = true;
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.Location = new System.Drawing.Point(383, 41);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.Size = new System.Drawing.Size(396, 383);
            this.dataGridEmp.TabIndex = 79;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(183, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 42);
            this.btnUpdate.TabIndex = 78;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(183, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 42);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(183, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 42);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(183, 190);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(182, 42);
            this.btnList.TabIndex = 75;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtEmpDep
            // 
            this.txtEmpDep.AutoSize = true;
            this.txtEmpDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmpDep.Location = new System.Drawing.Point(16, 146);
            this.txtEmpDep.Name = "txtEmpDep";
            this.txtEmpDep.Size = new System.Drawing.Size(161, 17);
            this.txtEmpDep.TabIndex = 73;
            this.txtEmpDep.Text = "Personel Departman:";
            // 
            // txtEmpMaas
            // 
            this.txtEmpMaas.Location = new System.Drawing.Point(183, 119);
            this.txtEmpMaas.Name = "txtEmpMaas";
            this.txtEmpMaas.Size = new System.Drawing.Size(182, 20);
            this.txtEmpMaas.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Personel Maaş:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(183, 67);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(182, 20);
            this.txtEmpName.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Personel Adı:";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(183, 41);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(182, 20);
            this.txtEmpId.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Personel Id:";
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtEmpSurname.Location = new System.Drawing.Point(183, 93);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(182, 20);
            this.txtEmpSurname.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Personel Soyadı:";
            // 
            // cmbEmpDepartment
            // 
            this.cmbEmpDepartment.FormattingEnabled = true;
            this.cmbEmpDepartment.Location = new System.Drawing.Point(184, 146);
            this.cmbEmpDepartment.Name = "cmbEmpDepartment";
            this.cmbEmpDepartment.Size = new System.Drawing.Size(181, 21);
            this.cmbEmpDepartment.TabIndex = 83;
            // 
            // FrmEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEmpDepartment);
            this.Controls.Add(this.txtEmpSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetId);
            this.Controls.Add(this.dataGridEmp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtEmpDep);
            this.Controls.Add(this.txtEmpMaas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmploye";
            this.Text = "FrmEmploye";
            this.Load += new System.EventHandler(this.FrmEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetId;
        private System.Windows.Forms.DataGridView dataGridEmp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label txtEmpDep;
        private System.Windows.Forms.TextBox txtEmpMaas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpDepartment;
    }
}