namespace WikiFormTwo
{
    partial class WikiFormTwo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WikiFormTwo));
            toolStrip1 = new ToolStrip();
            statusStrip = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            saveAsButton = new ToolStripButton();
            loadButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            addButton = new ToolStripButton();
            editButton = new ToolStripButton();
            removeButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            settingsDropdown = new ToolStripDropDownButton();
            darkModeToggle = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            categoryComboBox = new ComboBox();
            structureGroupBox = new GroupBox();
            nonLinearButton = new RadioButton();
            linearButton = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            recordBox = new ListView();
            nameColumn = new ColumnHeader();
            categoryColumn = new ColumnHeader();
            label5 = new Label();
            searchButton = new Button();
            nameTextBox = new TextBox();
            searchTextBox = new TextBox();
            definitionTextBox = new TextBox();
            toolTip1 = new ToolTip(components);
            toolStrip1.SuspendLayout();
            structureGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { statusStrip, toolStripSeparator1, saveAsButton, loadButton, toolStripSeparator2, addButton, editButton, removeButton, toolStripSeparator3, settingsDropdown });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(728, 34);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = SystemColors.ControlLightLight;
            statusStrip.BorderStyle = BorderStyle.None;
            statusStrip.Margin = new Padding(2, 5, 2, 5);
            statusStrip.Name = "statusStrip";
            statusStrip.ReadOnly = true;
            statusStrip.Size = new Size(200, 24);
            statusStrip.ToolTipText = "Status Strip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // saveAsButton
            // 
            saveAsButton.BackColor = SystemColors.ControlLightLight;
            saveAsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveAsButton.Image = (Image)resources.GetObject("saveAsButton.Image");
            saveAsButton.ImageTransparentColor = Color.Magenta;
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(78, 29);
            saveAsButton.Text = "Save As";
            saveAsButton.ToolTipText = "Save the wiki";
            saveAsButton.Click += saveAsButton_Click;
            // 
            // loadButton
            // 
            loadButton.BackColor = SystemColors.ControlLightLight;
            loadButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            loadButton.Image = (Image)resources.GetObject("loadButton.Image");
            loadButton.ImageTransparentColor = Color.Magenta;
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(55, 29);
            loadButton.Text = "Load";
            loadButton.ToolTipText = "Load a wiki";
            loadButton.Click += loadButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = SystemColors.ControlLightLight;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 34);
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ControlLightLight;
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Size = new Size(50, 29);
            addButton.Text = "Add";
            addButton.ToolTipText = "Add a new record";
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.ControlLightLight;
            editButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editButton.Enabled = false;
            editButton.Image = (Image)resources.GetObject("editButton.Image");
            editButton.ImageTransparentColor = Color.Magenta;
            editButton.Name = "editButton";
            editButton.Size = new Size(46, 29);
            editButton.Text = "Edit";
            editButton.ToolTipText = "Edit a record";
            editButton.Click += editButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = SystemColors.ControlLightLight;
            removeButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            removeButton.Enabled = false;
            removeButton.Image = (Image)resources.GetObject("removeButton.Image");
            removeButton.ImageTransparentColor = Color.Magenta;
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(80, 29);
            removeButton.Text = "Remove";
            removeButton.ToolTipText = "Remove a record";
            removeButton.Click += removeButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.BackColor = SystemColors.ControlLightLight;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 34);
            // 
            // settingsDropdown
            // 
            settingsDropdown.BackColor = SystemColors.ControlLightLight;
            settingsDropdown.DisplayStyle = ToolStripItemDisplayStyle.Text;
            settingsDropdown.DropDownItems.AddRange(new ToolStripItem[] { darkModeToggle });
            settingsDropdown.Image = (Image)resources.GetObject("settingsDropdown.Image");
            settingsDropdown.ImageTransparentColor = Color.Magenta;
            settingsDropdown.Name = "settingsDropdown";
            settingsDropdown.Size = new Size(94, 29);
            settingsDropdown.Text = "Settings";
            // 
            // darkModeToggle
            // 
            darkModeToggle.Name = "darkModeToggle";
            darkModeToggle.Size = new Size(203, 34);
            darkModeToggle.Text = "Dark Mode";
            darkModeToggle.ToolTipText = "Toggle dark mode";
            darkModeToggle.Click += darkModeToggle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = SystemColors.ControlLight;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 147);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(250, 33);
            categoryComboBox.Sorted = true;
            categoryComboBox.TabIndex = 4;
            toolTip1.SetToolTip(categoryComboBox, "Select a category");
            categoryComboBox.KeyPress += categoryComboBox_KeyPress;
            // 
            // structureGroupBox
            // 
            structureGroupBox.BackColor = SystemColors.ControlLight;
            structureGroupBox.Controls.Add(nonLinearButton);
            structureGroupBox.Controls.Add(linearButton);
            structureGroupBox.FlatStyle = FlatStyle.Flat;
            structureGroupBox.Location = new Point(12, 223);
            structureGroupBox.Name = "structureGroupBox";
            structureGroupBox.Size = new Size(250, 33);
            structureGroupBox.TabIndex = 5;
            structureGroupBox.TabStop = false;
            // 
            // nonLinearButton
            // 
            nonLinearButton.AutoSize = true;
            nonLinearButton.BackColor = SystemColors.ControlLight;
            nonLinearButton.Location = new Point(126, 0);
            nonLinearButton.Name = "nonLinearButton";
            nonLinearButton.Size = new Size(124, 29);
            nonLinearButton.TabIndex = 8;
            nonLinearButton.TabStop = true;
            nonLinearButton.Text = "Non-Linear";
            toolTip1.SetToolTip(nonLinearButton, "Change the structure");
            nonLinearButton.UseVisualStyleBackColor = false;
            // 
            // linearButton
            // 
            linearButton.AutoSize = true;
            linearButton.BackColor = SystemColors.ControlLight;
            linearButton.Location = new Point(6, 0);
            linearButton.Name = "linearButton";
            linearButton.Size = new Size(83, 29);
            linearButton.TabIndex = 7;
            linearButton.TabStop = true;
            linearButton.Text = "Linear";
            toolTip1.SetToolTip(linearButton, "Change the structure");
            linearButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 6;
            label3.Text = "Structure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 259);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 7;
            label4.Text = "Definition";
            // 
            // recordBox
            // 
            recordBox.BackColor = SystemColors.ControlLight;
            recordBox.Columns.AddRange(new ColumnHeader[] { nameColumn, categoryColumn });
            recordBox.FullRowSelect = true;
            recordBox.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            recordBox.Location = new Point(268, 122);
            recordBox.MultiSelect = false;
            recordBox.Name = "recordBox";
            recordBox.Size = new Size(448, 309);
            recordBox.TabIndex = 9;
            toolTip1.SetToolTip(recordBox, "Select a record to edit");
            recordBox.UseCompatibleStateImageBehavior = false;
            recordBox.View = View.Details;
            recordBox.SelectedIndexChanged += recordBox_SelectedIndexChanged;
            // 
            // nameColumn
            // 
            nameColumn.Name = "nameColumn";
            nameColumn.Text = "Name";
            nameColumn.Width = 200;
            // 
            // categoryColumn
            // 
            categoryColumn.Text = "Category";
            categoryColumn.Width = 200;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 55);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 11;
            label5.Text = "Search";
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.ControlLight;
            searchButton.FlatStyle = FlatStyle.System;
            searchButton.Location = new Point(616, 81);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 35);
            searchButton.TabIndex = 12;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.ControlLight;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Location = new Point(12, 85);
            nameTextBox.MaxLength = 25;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 24);
            nameTextBox.TabIndex = 13;
            toolTip1.SetToolTip(nameTextBox, "Record name (Double click to clear all)");
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            nameTextBox.MouseDoubleClick += nameTextBox_MouseDoubleClick;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = SystemColors.ControlLight;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Location = new Point(268, 86);
            searchTextBox.MaxLength = 25;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(342, 24);
            searchTextBox.TabIndex = 14;
            // 
            // definitionTextBox
            // 
            definitionTextBox.BackColor = SystemColors.ControlLight;
            definitionTextBox.BorderStyle = BorderStyle.None;
            definitionTextBox.Location = new Point(12, 287);
            definitionTextBox.MaxLength = 25;
            definitionTextBox.Multiline = true;
            definitionTextBox.Name = "definitionTextBox";
            definitionTextBox.Size = new Size(250, 144);
            definitionTextBox.TabIndex = 15;
            toolTip1.SetToolTip(definitionTextBox, "Record definition");
            definitionTextBox.KeyPress += definitionTextBox_KeyPress;
            // 
            // WikiFormTwo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(728, 444);
            Controls.Add(definitionTextBox);
            Controls.Add(searchTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(searchButton);
            Controls.Add(label5);
            Controls.Add(recordBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(structureGroupBox);
            Controls.Add(categoryComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WikiFormTwo";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Structure Wiki";
            FormClosing += WikiFormTwo_FormClosing;
            Load += WikiFormTwo_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            structureGroupBox.ResumeLayout(false);
            structureGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox statusStrip;
        private ToolStripSeparator toolStripSeparator1;
        private Label label1;
        private ToolStripButton saveAsButton;
        private ToolStripButton loadButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton addButton;
        private ToolStripButton editButton;
        private ToolStripButton removeButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton settingsDropdown;
        private ToolStripMenuItem darkModeToggle;
        private Label label2;
        private ComboBox categoryComboBox;
        private GroupBox structureGroupBox;
        private RadioButton linearButton;
        private Label label3;
        private RadioButton nonLinearButton;
        private Label label4;
        private ListView recordBox;
        private Label label5;
        private Button searchButton;
        private ColumnHeader nameColumn;
        private ColumnHeader categoryColumn;
        private TextBox nameTextBox;
        private TextBox searchTextBox;
        private TextBox definitionTextBox;
        private ToolTip toolTip1;
    }
}