namespace AccountingOtomation
{
    partial class AccountingOtomation
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
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.ComboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.dgvPeriodList = new System.Windows.Forms.DataGridView();
            this.dgvDonem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxDateTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsd = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvExcelDocument = new System.Windows.Forms.DataGridView();
            this.txtGetDocument = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileExcented = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPrice.Location = new System.Drawing.Point(102, 215);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(321, 45);
            this.btnGetPrice.TabIndex = 2;
            this.btnGetPrice.Text = "Getir";
            this.btnGetPrice.UseVisualStyleBackColor = true;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // ComboBoxPeriod
            // 
            this.ComboBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPeriod.FormattingEnabled = true;
            this.ComboBoxPeriod.Location = new System.Drawing.Point(102, 185);
            this.ComboBoxPeriod.Name = "ComboBoxPeriod";
            this.ComboBoxPeriod.Size = new System.Drawing.Size(321, 24);
            this.ComboBoxPeriod.TabIndex = 3;
            // 
            // dgvPeriodList
            // 
            this.dgvPeriodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDonem,
            this.dgvUSD,
            this.dgvTL});
            this.dgvPeriodList.Location = new System.Drawing.Point(46, 334);
            this.dgvPeriodList.Name = "dgvPeriodList";
            this.dgvPeriodList.Size = new System.Drawing.Size(338, 161);
            this.dgvPeriodList.TabIndex = 4;
            // 
            // dgvDonem
            // 
            this.dgvDonem.HeaderText = "DÖNEM";
            this.dgvDonem.Name = "dgvDonem";
            // 
            // dgvUSD
            // 
            this.dgvUSD.HeaderText = "USD";
            this.dgvUSD.Name = "dgvUSD";
            // 
            // dgvTL
            // 
            this.dgvTL.HeaderText = "TL";
            this.dgvTL.Name = "dgvTL";
            // 
            // ComboBoxDateTime
            // 
            this.ComboBoxDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDateTime.FormattingEnabled = true;
            this.ComboBoxDateTime.Location = new System.Drawing.Point(102, 158);
            this.ComboBoxDateTime.Name = "ComboBoxDateTime";
            this.ComboBoxDateTime.Size = new System.Drawing.Size(321, 24);
            this.ComboBoxDateTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dönem :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "USD :";
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsd.Location = new System.Drawing.Point(169, 275);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(15, 16);
            this.lblUsd.TabIndex = 9;
            this.lblUsd.Text = "0";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(169, 306);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(15, 16);
            this.lblTL.TabIndex = 11;
            this.lblTL.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "TL :";
            // 
            // dgvExcelDocument
            // 
            this.dgvExcelDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelDocument.Location = new System.Drawing.Point(448, 12);
            this.dgvExcelDocument.Name = "dgvExcelDocument";
            this.dgvExcelDocument.Size = new System.Drawing.Size(964, 506);
            this.dgvExcelDocument.TabIndex = 12;
            // 
            // txtGetDocument
            // 
            this.txtGetDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetDocument.Location = new System.Drawing.Point(102, 128);
            this.txtGetDocument.Name = "txtGetDocument";
            this.txtGetDocument.Size = new System.Drawing.Size(321, 24);
            this.txtGetDocument.TabIndex = 13;
            this.txtGetDocument.Text = "Getir";
            this.txtGetDocument.UseVisualStyleBackColor = true;
            this.txtGetDocument.Click += new System.EventHandler(this.txtGetDocument_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dosya Seç :";
            // 
            // txtFileExcented
            // 
            this.txtFileExcented.Location = new System.Drawing.Point(100, 63);
            this.txtFileExcented.Name = "txtFileExcented";
            this.txtFileExcented.Size = new System.Drawing.Size(323, 59);
            this.txtFileExcented.TabIndex = 16;
            this.txtFileExcented.Text = "";
            // 
            // AccountingOtomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 561);
            this.Controls.Add(this.txtFileExcented);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGetDocument);
            this.Controls.Add(this.dgvExcelDocument);
            this.Controls.Add(this.lblTL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUsd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxDateTime);
            this.Controls.Add(this.dgvPeriodList);
            this.Controls.Add(this.ComboBoxPeriod);
            this.Controls.Add(this.btnGetPrice);
            this.Name = "AccountingOtomation";
            this.Text = "Muhasebe Otomasyonu";
            this.Load += new System.EventHandler(this.AccountingOtomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDocument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.ComboBox ComboBoxPeriod;
        private System.Windows.Forms.DataGridView dgvPeriodList;
        private System.Windows.Forms.ComboBox ComboBoxDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDonem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTL;
        private System.Windows.Forms.DataGridView dgvExcelDocument;
        private System.Windows.Forms.Button txtGetDocument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtFileExcented;
    }
}

