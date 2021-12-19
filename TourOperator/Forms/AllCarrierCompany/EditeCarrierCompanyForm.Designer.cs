
namespace TourOperator.Forms.AllCarrierCompany
{
    partial class EditeCarrierCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditeCarrierCompanyForm));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnEditeComp = new System.Windows.Forms.Button();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNameComp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(224, 328);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(52, 37);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 52;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnEditeComp
            // 
            this.btnEditeComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditeComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditeComp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditeComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEditeComp.Location = new System.Drawing.Point(23, 328);
            this.btnEditeComp.Name = "btnEditeComp";
            this.btnEditeComp.Size = new System.Drawing.Size(195, 37);
            this.btnEditeComp.TabIndex = 53;
            this.btnEditeComp.Text = "Редактировать";
            this.btnEditeComp.UseVisualStyleBackColor = false;
            this.btnEditeComp.Click += new System.EventHandler(this.btnEditeComp_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxDescription.Location = new System.Drawing.Point(23, 105);
            this.txtBoxDescription.MaxLength = 50;
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(253, 203);
            this.txtBoxDescription.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Описание:";
            // 
            // txtBoxNameComp
            // 
            this.txtBoxNameComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBoxNameComp.Location = new System.Drawing.Point(23, 46);
            this.txtBoxNameComp.MaxLength = 50;
            this.txtBoxNameComp.Name = "txtBoxNameComp";
            this.txtBoxNameComp.Size = new System.Drawing.Size(253, 26);
            this.txtBoxNameComp.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Название:";
            // 
            // EditeCarrierCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 389);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnEditeComp);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNameComp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditeCarrierCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование перевозчиков";
            this.Load += new System.EventHandler(this.EditeCarrierCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnEditeComp;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNameComp;
        private System.Windows.Forms.Label label1;
    }
}