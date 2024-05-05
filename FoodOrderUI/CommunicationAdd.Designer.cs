namespace FoodOrderUI
{
    partial class CommunicationAdd
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
            lblCommType = new Label();
            lblCommDetail = new Label();
            txtCommDetail = new TextBox();
            btnCommAdd = new Button();
            cbCommTypes = new ComboBox();
            SuspendLayout();
            // 
            // lblCommType
            // 
            lblCommType.AutoSize = true;
            lblCommType.Location = new Point(73, 50);
            lblCommType.Name = "lblCommType";
            lblCommType.Size = new Size(86, 20);
            lblCommType.TabIndex = 0;
            lblCommType.Text = "İletişim Tipi";
            // 
            // lblCommDetail
            // 
            lblCommDetail.AutoSize = true;
            lblCommDetail.Location = new Point(73, 153);
            lblCommDetail.Name = "lblCommDetail";
            lblCommDetail.Size = new Size(101, 20);
            lblCommDetail.TabIndex = 1;
            lblCommDetail.Text = "İletişim Bilgisi";
            // 
            // txtCommDetail
            // 
            txtCommDetail.Location = new Point(186, 146);
            txtCommDetail.Name = "txtCommDetail";
            txtCommDetail.Size = new Size(125, 27);
            txtCommDetail.TabIndex = 3;
            // 
            // btnCommAdd
            // 
            btnCommAdd.Location = new Point(178, 224);
            btnCommAdd.Name = "btnCommAdd";
            btnCommAdd.Size = new Size(108, 55);
            btnCommAdd.TabIndex = 4;
            btnCommAdd.Text = "Kaydet";
            btnCommAdd.UseVisualStyleBackColor = true;
            btnCommAdd.Click += btnCommAdd_Click;
            // 
            // cbCommTypes
            // 
            cbCommTypes.FormattingEnabled = true;
            cbCommTypes.Location = new Point(178, 52);
            cbCommTypes.Name = "cbCommTypes";
            cbCommTypes.Size = new Size(133, 28);
            cbCommTypes.TabIndex = 5;
            // 
            // CommunicationAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 323);
            Controls.Add(cbCommTypes);
            Controls.Add(btnCommAdd);
            Controls.Add(txtCommDetail);
            Controls.Add(lblCommDetail);
            Controls.Add(lblCommType);
            Name = "CommunicationAdd";
            Text = "CommunicationAdd";
            Load += CommunicationAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCommType;
        private Label lblCommDetail;
        private TextBox txtCommDetail;
        private Button btnCommAdd;
        private ComboBox cbCommTypes;
    }
}