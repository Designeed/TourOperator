
namespace TourOperator.Forms.AllCarrierServiceForm
{
    partial class EditeCarrierServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditeCarrierServiceForm));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnEditeService = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(224, 387);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(52, 37);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 54;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnEditeService
            // 
            this.btnEditeService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditeService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditeService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEditeService.Location = new System.Drawing.Point(23, 387);
            this.btnEditeService.Name = "btnEditeService";
            this.btnEditeService.Size = new System.Drawing.Size(195, 37);
            this.btnEditeService.TabIndex = 3;
            this.btnEditeService.Text = "Редактировать";
            this.btnEditeService.UseVisualStyleBackColor = false;
            this.btnEditeService.Click += new System.EventHandler(this.btnEditeService_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxDescription.Location = new System.Drawing.Point(23, 109);
            this.txtBoxDescription.MaxLength = 50;
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(253, 203);
            this.txtBoxDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Описание:";
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxCost.Location = new System.Drawing.Point(23, 342);
            this.txtBoxCost.MaxLength = 50;
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(253, 26);
            this.txtBoxCost.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(23, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Стоимость:";
            // 
            // txtBoxService
            // 
            this.txtBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxService.Location = new System.Drawing.Point(23, 50);
            this.txtBoxService.MaxLength = 50;
            this.txtBoxService.Name = "txtBoxService";
            this.txtBoxService.Size = new System.Drawing.Size(253, 26);
            this.txtBoxService.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Название услуги:";
            // 
            // EditeCarrierServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnEditeService);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxService);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditeCarrierServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование сервиса";
            this.Load += new System.EventHandler(this.EditeCarrierServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnEditeService;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxService;
        private System.Windows.Forms.Label label1;
    }
}