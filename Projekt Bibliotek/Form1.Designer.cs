namespace Projekt_Bibliotek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMedia = new Label();
            dvgMedia = new DataGridView();
            colTitle = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colCopies = new DataGridViewTextBoxColumn();
            btnDetails = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            pnlDetails = new Panel();
            btnBack = new Button();
            lblDetails = new Label();
            lblDetailsTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgMedia).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblMedia
            // 
            lblMedia.Location = new Point(424, 12);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(501, 180);
            lblMedia.TabIndex = 0;
            lblMedia.Text = "Library Media";
            // 
            // dvgMedia
            // 
            dvgMedia.AllowUserToAddRows = false;
            dvgMedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMedia.Columns.AddRange(new DataGridViewColumn[] { colTitle, colType, colCopies });
            dvgMedia.Location = new Point(14, 88);
            dvgMedia.Margin = new Padding(3, 4, 3, 4);
            dvgMedia.MultiSelect = false;
            dvgMedia.Name = "dvgMedia";
            dvgMedia.ReadOnly = true;
            dvgMedia.RowHeadersWidth = 51;
            dvgMedia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMedia.Size = new Size(914, 400);
            dvgMedia.TabIndex = 1;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colType
            // 
            colType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colCopies
            // 
            colCopies.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCopies.HeaderText = "Copies";
            colCopies.MinimumWidth = 6;
            colCopies.Name = "colCopies";
            colCopies.ReadOnly = true;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(75, 537);
            btnDetails.Margin = new Padding(3, 4, 3, 4);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(128, 31);
            btnDetails.TabIndex = 2;
            btnDetails.Text = "View Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(306, 537);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Media";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(547, 537);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 31);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Media";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(767, 537);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 31);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove Media";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.White;
            pnlDetails.Controls.Add(btnBack);
            pnlDetails.Controls.Add(lblDetails);
            pnlDetails.Controls.Add(lblDetailsTitle);
            pnlDetails.Location = new Point(11, 67);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(800, 300);
            pnlDetails.TabIndex = 6;
            pnlDetails.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(97, 187);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblDetails
            // 
            lblDetails.Location = new Point(63, 97);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(501, 180);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "lblDetails";
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDetailsTitle.Location = new Point(63, 47);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(194, 37);
            lblDetailsTitle.TabIndex = 0;
            lblDetailsTitle.Text = "Media Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1010, 615);
            Controls.Add(pnlDetails);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnDetails);
            Controls.Add(dvgMedia);
            Controls.Add(lblMedia);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = " ";
            Text = "Library";
            ((System.ComponentModel.ISupportInitialize)dvgMedia).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMedia;
        private DataGridView dvgMedia;
        private Button btnDetails;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colCopies;
        private Panel pnlDetails;
        private Label lblDetails;
        private Label lblDetailsTitle;
        private Button btnBack;
    }
}
