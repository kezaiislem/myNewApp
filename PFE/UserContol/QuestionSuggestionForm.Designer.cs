namespace PFE.UserContol
{
    partial class QuestionSuggestionForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroButtonImport = new MetroFramework.Controls.MetroButton();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxTechnologyName = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSearch = new MetroFramework.Controls.MetroButton();
            this.gridResult = new MetroFramework.Controls.MetroGrid();
            this.textBoxTechnologyField = new MetroFramework.Controls.MetroTextBox();
            this.textBoxEvaluationContext = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBoxFacor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonImport
            // 
            this.metroButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonImport.ForeColor = System.Drawing.Color.White;
            this.metroButtonImport.Location = new System.Drawing.Point(382, 383);
            this.metroButtonImport.Name = "metroButtonImport";
            this.metroButtonImport.Size = new System.Drawing.Size(75, 23);
            this.metroButtonImport.TabIndex = 12;
            this.metroButtonImport.Text = "Import";
            this.metroButtonImport.UseCustomBackColor = true;
            this.metroButtonImport.UseCustomForeColor = true;
            this.metroButtonImport.UseSelectable = true;
            this.metroButtonImport.Click += new System.EventHandler(this.metroButtonImport_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(301, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseCustomBackColor = true;
            this.buttonCancel.UseCustomForeColor = true;
            this.buttonCancel.UseSelectable = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(22, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Import Section";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(33, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Technology name";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(33, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Field";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // textBoxTechnologyName
            // 
            this.textBoxTechnologyName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxTechnologyName.CustomButton.Image = null;
            this.textBoxTechnologyName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.textBoxTechnologyName.CustomButton.Name = "";
            this.textBoxTechnologyName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxTechnologyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTechnologyName.CustomButton.TabIndex = 1;
            this.textBoxTechnologyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTechnologyName.CustomButton.UseSelectable = true;
            this.textBoxTechnologyName.CustomButton.Visible = false;
            this.textBoxTechnologyName.ForeColor = System.Drawing.Color.Black;
            this.textBoxTechnologyName.Lines = new string[0];
            this.textBoxTechnologyName.Location = new System.Drawing.Point(167, 59);
            this.textBoxTechnologyName.MaxLength = 32767;
            this.textBoxTechnologyName.Name = "textBoxTechnologyName";
            this.textBoxTechnologyName.PasswordChar = '\0';
            this.textBoxTechnologyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTechnologyName.SelectedText = "";
            this.textBoxTechnologyName.SelectionLength = 0;
            this.textBoxTechnologyName.SelectionStart = 0;
            this.textBoxTechnologyName.ShortcutsEnabled = true;
            this.textBoxTechnologyName.Size = new System.Drawing.Size(190, 25);
            this.textBoxTechnologyName.TabIndex = 17;
            this.textBoxTechnologyName.UseCustomBackColor = true;
            this.textBoxTechnologyName.UseCustomForeColor = true;
            this.textBoxTechnologyName.UseSelectable = true;
            this.textBoxTechnologyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTechnologyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSearch
            // 
            this.metroButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonSearch.ForeColor = System.Drawing.Color.White;
            this.metroButtonSearch.Location = new System.Drawing.Point(382, 152);
            this.metroButtonSearch.Name = "metroButtonSearch";
            this.metroButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSearch.TabIndex = 20;
            this.metroButtonSearch.Text = "Search";
            this.metroButtonSearch.UseCustomBackColor = true;
            this.metroButtonSearch.UseCustomForeColor = true;
            this.metroButtonSearch.UseSelectable = true;
            this.metroButtonSearch.Click += new System.EventHandler(this.metroButtonSearch_Click);
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToResizeRows = false;
            this.gridResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResult.AutoGenerateColumns = false;
            this.gridResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn});
            this.gridResult.DataSource = this.questionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridResult.EnableHeadersVisualStyles = false;
            this.gridResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridResult.Location = new System.Drawing.Point(33, 198);
            this.gridResult.MultiSelect = false;
            this.gridResult.Name = "gridResult";
            this.gridResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResult.Size = new System.Drawing.Size(424, 169);
            this.gridResult.TabIndex = 22;
            // 
            // textBoxTechnologyField
            // 
            this.textBoxTechnologyField.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxTechnologyField.CustomButton.Image = null;
            this.textBoxTechnologyField.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.textBoxTechnologyField.CustomButton.Name = "";
            this.textBoxTechnologyField.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxTechnologyField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTechnologyField.CustomButton.TabIndex = 1;
            this.textBoxTechnologyField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTechnologyField.CustomButton.UseSelectable = true;
            this.textBoxTechnologyField.CustomButton.Visible = false;
            this.textBoxTechnologyField.ForeColor = System.Drawing.Color.Black;
            this.textBoxTechnologyField.Lines = new string[0];
            this.textBoxTechnologyField.Location = new System.Drawing.Point(167, 90);
            this.textBoxTechnologyField.MaxLength = 32767;
            this.textBoxTechnologyField.Name = "textBoxTechnologyField";
            this.textBoxTechnologyField.PasswordChar = '\0';
            this.textBoxTechnologyField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTechnologyField.SelectedText = "";
            this.textBoxTechnologyField.SelectionLength = 0;
            this.textBoxTechnologyField.SelectionStart = 0;
            this.textBoxTechnologyField.ShortcutsEnabled = true;
            this.textBoxTechnologyField.Size = new System.Drawing.Size(190, 25);
            this.textBoxTechnologyField.TabIndex = 23;
            this.textBoxTechnologyField.UseCustomBackColor = true;
            this.textBoxTechnologyField.UseCustomForeColor = true;
            this.textBoxTechnologyField.UseSelectable = true;
            this.textBoxTechnologyField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTechnologyField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxEvaluationContext
            // 
            this.textBoxEvaluationContext.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxEvaluationContext.CustomButton.Image = null;
            this.textBoxEvaluationContext.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.textBoxEvaluationContext.CustomButton.Name = "";
            this.textBoxEvaluationContext.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxEvaluationContext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxEvaluationContext.CustomButton.TabIndex = 1;
            this.textBoxEvaluationContext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxEvaluationContext.CustomButton.UseSelectable = true;
            this.textBoxEvaluationContext.CustomButton.Visible = false;
            this.textBoxEvaluationContext.ForeColor = System.Drawing.Color.Black;
            this.textBoxEvaluationContext.Lines = new string[0];
            this.textBoxEvaluationContext.Location = new System.Drawing.Point(167, 121);
            this.textBoxEvaluationContext.MaxLength = 32767;
            this.textBoxEvaluationContext.Name = "textBoxEvaluationContext";
            this.textBoxEvaluationContext.PasswordChar = '\0';
            this.textBoxEvaluationContext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEvaluationContext.SelectedText = "";
            this.textBoxEvaluationContext.SelectionLength = 0;
            this.textBoxEvaluationContext.SelectionStart = 0;
            this.textBoxEvaluationContext.ShortcutsEnabled = true;
            this.textBoxEvaluationContext.Size = new System.Drawing.Size(190, 25);
            this.textBoxEvaluationContext.TabIndex = 25;
            this.textBoxEvaluationContext.UseCustomBackColor = true;
            this.textBoxEvaluationContext.UseCustomForeColor = true;
            this.textBoxEvaluationContext.UseSelectable = true;
            this.textBoxEvaluationContext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxEvaluationContext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(33, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Evaluation Context";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // textBoxFacor
            // 
            this.textBoxFacor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textBoxFacor.CustomButton.Image = null;
            this.textBoxFacor.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.textBoxFacor.CustomButton.Name = "";
            this.textBoxFacor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textBoxFacor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxFacor.CustomButton.TabIndex = 1;
            this.textBoxFacor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxFacor.CustomButton.UseSelectable = true;
            this.textBoxFacor.CustomButton.Visible = false;
            this.textBoxFacor.ForeColor = System.Drawing.Color.Black;
            this.textBoxFacor.Lines = new string[0];
            this.textBoxFacor.Location = new System.Drawing.Point(167, 152);
            this.textBoxFacor.MaxLength = 32767;
            this.textBoxFacor.Name = "textBoxFacor";
            this.textBoxFacor.PasswordChar = '\0';
            this.textBoxFacor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxFacor.SelectedText = "";
            this.textBoxFacor.SelectionLength = 0;
            this.textBoxFacor.SelectionStart = 0;
            this.textBoxFacor.ShortcutsEnabled = true;
            this.textBoxFacor.Size = new System.Drawing.Size(190, 25);
            this.textBoxFacor.TabIndex = 27;
            this.textBoxFacor.UseCustomBackColor = true;
            this.textBoxFacor.UseCustomForeColor = true;
            this.textBoxFacor.UseSelectable = true;
            this.textBoxFacor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxFacor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(33, 157);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Factor";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(PFE.Model.Question);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Question";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 383;
            // 
            // QuestionSuggestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(485, 425);
            this.Controls.Add(this.textBoxFacor);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.textBoxEvaluationContext);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.textBoxTechnologyField);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.metroButtonSearch);
            this.Controls.Add(this.textBoxTechnologyName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonImport);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionSuggestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionSugesstionForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonImport;
        private MetroFramework.Controls.MetroButton buttonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textBoxTechnologyName;
        private MetroFramework.Controls.MetroButton metroButtonSearch;
        private MetroFramework.Controls.MetroGrid gridResult;
        private MetroFramework.Controls.MetroTextBox textBoxTechnologyField;
        private MetroFramework.Controls.MetroTextBox textBoxEvaluationContext;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textBoxFacor;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionBindingSource;
    }
}