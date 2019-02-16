﻿namespace Pokemon_Genesis_Save_Manager
{
	partial class Form1
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.saveListView = new System.Windows.Forms.ListView();
			this.SaveName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuSaves = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button4 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenuSaves.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(12, 50);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(290, 30);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 86);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(290, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "Load";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 14);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(290, 30);
			this.button3.TabIndex = 0;
			this.button3.Text = "New";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// saveListView
			// 
			this.saveListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.saveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaveName,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.saveListView.ContextMenuStrip = this.contextMenuSaves;
			this.saveListView.FullRowSelect = true;
			this.saveListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.saveListView.HideSelection = false;
			this.saveListView.LabelWrap = false;
			this.saveListView.Location = new System.Drawing.Point(308, 12);
			this.saveListView.MultiSelect = false;
			this.saveListView.Name = "saveListView";
			this.saveListView.Size = new System.Drawing.Size(507, 372);
			this.saveListView.TabIndex = 5;
			this.saveListView.UseCompatibleStateImageBehavior = false;
			this.saveListView.View = System.Windows.Forms.View.Details;
			// 
			// SaveName
			// 
			this.SaveName.Text = "Save Name";
			this.SaveName.Width = 260;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "#1";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "#2";
			this.columnHeader2.Width = 40;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "#3";
			this.columnHeader3.Width = 40;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "#4";
			this.columnHeader4.Width = 40;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "#5";
			this.columnHeader5.Width = 40;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "#6";
			this.columnHeader6.Width = 40;
			// 
			// contextMenuSaves
			// 
			this.contextMenuSaves.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.contextMenuSaves.Name = "contextMenuSaves";
			this.contextMenuSaves.Size = new System.Drawing.Size(118, 48);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 122);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(290, 30);
			this.button4.TabIndex = 3;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(13, 159);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(137, 17);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Auto save on load/new";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(13, 347);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richTextBox1.Size = new System.Drawing.Size(289, 37);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "Please ensure your game is not open when loading/creating save files, as you will" +
    " very likely lose your progress.\n";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 396);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.saveListView);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Pokemon Genesis Save Manager";
			this.contextMenuSaves.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListView saveListView;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ColumnHeader SaveName;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuSaves;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

