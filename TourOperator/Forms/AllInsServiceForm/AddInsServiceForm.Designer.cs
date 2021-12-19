
namespace TourOperator.Forms.AllInsServiceForm
{
    partial class AddInsServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInsServiceForm));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(224, 383);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(52, 37);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 46;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAddService.Location = new System.Drawing.Point(23, 383);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(195, 37);
            this.btnAddService.TabIndex = 47;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxDescription.Location = new System.Drawing.Point(23, 105);
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
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Описание:";
            // 
            // txtBoxService
            // 
            this.txtBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxService.Location = new System.Drawing.Point(23, 46);
            this.txtBoxService.MaxLength = 50;
            this.txtBoxService.Name = "txtBoxService";
            this.txtBoxService.Size = new System.Drawing.Size(253, 26);
            this.txtBoxService.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Название услуги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(23, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Стоимость:";
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxCost.Location = new System.Drawing.Point(23, 338);
            this.txtBoxCost.MaxLength = 50;
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(253, 26);
            this.txtBoxCost.TabIndex = 2;
            // 
            // AddInsServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxService);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddInsServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сервиса";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCost;
    }
}