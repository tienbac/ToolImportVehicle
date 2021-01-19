namespace ToolImportVehicle
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblTotalTitel = new System.Windows.Forms.Label();
            this.lblTotalVehicle = new System.Windows.Forms.Label();
            this.rtbSaveResult = new System.Windows.Forms.RichTextBox();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.lblSaveFail = new System.Windows.Forms.Label();
            this.txtPlateCheck = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddPlate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(103, 40);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Chọn file ...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(148, 18);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(390, 26);
            this.txtFileName.TabIndex = 2;
            // 
            // lblTotalTitel
            // 
            this.lblTotalTitel.AutoSize = true;
            this.lblTotalTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitel.Location = new System.Drawing.Point(144, 88);
            this.lblTotalTitel.Name = "lblTotalTitel";
            this.lblTotalTitel.Size = new System.Drawing.Size(94, 20);
            this.lblTotalTitel.TabIndex = 3;
            this.lblTotalTitel.Text = "Tổng số xe :";
            // 
            // lblTotalVehicle
            // 
            this.lblTotalVehicle.AutoSize = true;
            this.lblTotalVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVehicle.Location = new System.Drawing.Point(244, 88);
            this.lblTotalVehicle.Name = "lblTotalVehicle";
            this.lblTotalVehicle.Size = new System.Drawing.Size(18, 20);
            this.lblTotalVehicle.TabIndex = 4;
            this.lblTotalVehicle.Text = "0";
            // 
            // rtbSaveResult
            // 
            this.rtbSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSaveResult.Location = new System.Drawing.Point(12, 124);
            this.rtbSaveResult.Name = "rtbSaveResult";
            this.rtbSaveResult.Size = new System.Drawing.Size(985, 375);
            this.rtbSaveResult.TabIndex = 5;
            this.rtbSaveResult.Text = "";
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.CausesValidation = false;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSaveStatus.Location = new System.Drawing.Point(357, 87);
            this.lblSaveStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(300, 22);
            this.lblSaveStatus.TabIndex = 6;
            this.lblSaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaveFail
            // 
            this.lblSaveFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveFail.ForeColor = System.Drawing.Color.Red;
            this.lblSaveFail.Location = new System.Drawing.Point(663, 87);
            this.lblSaveFail.Name = "lblSaveFail";
            this.lblSaveFail.Size = new System.Drawing.Size(150, 22);
            this.lblSaveFail.TabIndex = 7;
            this.lblSaveFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlateCheck
            // 
            this.txtPlateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateCheck.Location = new System.Drawing.Point(604, 19);
            this.txtPlateCheck.Name = "txtPlateCheck";
            this.txtPlateCheck.Size = new System.Drawing.Size(146, 26);
            this.txtPlateCheck.TabIndex = 8;
            this.txtPlateCheck.Text = "Nhập biển số . . .";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(768, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddPlate
            // 
            this.btnAddPlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlate.ForeColor = System.Drawing.Color.White;
            this.btnAddPlate.Location = new System.Drawing.Point(894, 12);
            this.btnAddPlate.Name = "btnAddPlate";
            this.btnAddPlate.Size = new System.Drawing.Size(103, 40);
            this.btnAddPlate.TabIndex = 10;
            this.btnAddPlate.Text = "Thêm mới";
            this.btnAddPlate.UseMnemonic = false;
            this.btnAddPlate.UseVisualStyleBackColor = false;
            this.btnAddPlate.Click += new System.EventHandler(this.btnAddPlate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 511);
            this.Controls.Add(this.btnAddPlate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPlateCheck);
            this.Controls.Add(this.lblSaveFail);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.rtbSaveResult);
            this.Controls.Add(this.lblTotalVehicle);
            this.Controls.Add(this.lblTotalTitel);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NHẬP XE MIỄN PHÍ - ƯU TIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblTotalTitel;
        private System.Windows.Forms.Label lblTotalVehicle;
        private System.Windows.Forms.RichTextBox rtbSaveResult;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Label lblSaveFail;
        private System.Windows.Forms.TextBox txtPlateCheck;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPlate;
    }
}

