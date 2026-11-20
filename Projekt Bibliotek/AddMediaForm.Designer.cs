namespace Projekt_Bibliotek
{
    partial class AddMediaForm
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
            lblMediaType = new Label();
            cmbMediaType = new ComboBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblCopies = new Label();
            txtCopies = new TextBox();
            lblExtra1 = new Label();
            txtExtra1 = new TextBox();
            lblExtra2 = new Label();
            txtExtra2 = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMediaType
            // 
            lblMediaType.AutoSize = true;
            lblMediaType.Location = new Point(288, 15);
            lblMediaType.Name = "lblMediaType";
            lblMediaType.Size = new Size(86, 20);
            lblMediaType.TabIndex = 0;
            lblMediaType.Text = "Media Type";
            // 
            // cmbMediaType
            // 
            cmbMediaType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMediaType.FormattingEnabled = true;
            cmbMediaType.Location = new Point(12, 12);
            cmbMediaType.Name = "cmbMediaType";
            cmbMediaType.Size = new Size(151, 28);
            cmbMediaType.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(288, 78);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 71);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 3;
            // 
            // lblCopies
            // 
            lblCopies.AutoSize = true;
            lblCopies.Location = new Point(288, 146);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(54, 20);
            lblCopies.TabIndex = 4;
            lblCopies.Text = "Copies";
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(12, 139);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(125, 27);
            txtCopies.TabIndex = 5;
            // 
            // lblExtra1
            // 
            lblExtra1.AutoSize = true;
            lblExtra1.Location = new Point(288, 209);
            lblExtra1.Name = "lblExtra1";
            lblExtra1.Size = new Size(54, 20);
            lblExtra1.TabIndex = 6;
            lblExtra1.Text = "Author";
            // 
            // txtExtra1
            // 
            txtExtra1.Location = new Point(12, 202);
            txtExtra1.Name = "txtExtra1";
            txtExtra1.Size = new Size(125, 27);
            txtExtra1.TabIndex = 7;
            // 
            // lblExtra2
            // 
            lblExtra2.AutoSize = true;
            lblExtra2.Location = new Point(259, 281);
            lblExtra2.Name = "lblExtra2";
            lblExtra2.Size = new Size(115, 20);
            lblExtra2.TabIndex = 8;
            lblExtra2.Text = "Publication Year";
            // 
            // txtExtra2
            // 
            txtExtra2.Location = new Point(12, 274);
            txtExtra2.Name = "txtExtra2";
            txtExtra2.Size = new Size(125, 27);
            txtExtra2.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 332);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 367);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddMediaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 403);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtExtra2);
            Controls.Add(lblExtra2);
            Controls.Add(txtExtra1);
            Controls.Add(lblExtra1);
            Controls.Add(txtCopies);
            Controls.Add(lblCopies);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(cmbMediaType);
            Controls.Add(lblMediaType);
            Name = "AddMediaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New media";
            Load += AddMediaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMediaType;
        private ComboBox cmbMediaType;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblCopies;
        private TextBox txtCopies;
        private Label lblExtra1;
        private TextBox txtExtra1;
        private Label lblExtra2;
        private TextBox txtExtra2;
        private Button btnSave;
        private Button btnCancel;
    }
}