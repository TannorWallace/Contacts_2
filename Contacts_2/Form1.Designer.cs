namespace Contacts_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label contactIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label legionLabel;
            System.Windows.Forms.Label voxFrequencyLabel;
            System.Windows.Forms.Label isLoyalLabel;
            System.Windows.Forms.Label lastTransmissionLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactsDBDataSet = new Contacts_2.ContactsDBDataSet();
            this.legionContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.legionContactsTableAdapter = new Contacts_2.ContactsDBDataSetTableAdapters.LegionContactsTableAdapter();
            this.tableAdapterManager = new Contacts_2.ContactsDBDataSetTableAdapters.TableAdapterManager();
            this.legionContactsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.legionContactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contactIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.legionTextBox = new System.Windows.Forms.TextBox();
            this.voxFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.isLoyalCheckBox = new System.Windows.Forms.CheckBox();
            this.lastTransmissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            contactIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            legionLabel = new System.Windows.Forms.Label();
            voxFrequencyLabel = new System.Windows.Forms.Label();
            isLoyalLabel = new System.Windows.Forms.Label();
            lastTransmissionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legionContactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legionContactsBindingNavigator)).BeginInit();
            this.legionContactsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(657, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contactsDBDataSet
            // 
            this.contactsDBDataSet.DataSetName = "ContactsDBDataSet";
            this.contactsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // legionContactsBindingSource
            // 
            this.legionContactsBindingSource.DataMember = "LegionContacts";
            this.legionContactsBindingSource.DataSource = this.contactsDBDataSet;
            // 
            // legionContactsTableAdapter
            // 
            this.legionContactsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LegionContactsTableAdapter = this.legionContactsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contacts_2.ContactsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // legionContactsBindingNavigator
            // 
            this.legionContactsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.legionContactsBindingNavigator.BindingSource = this.legionContactsBindingSource;
            this.legionContactsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.legionContactsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.legionContactsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.legionContactsBindingNavigatorSaveItem});
            this.legionContactsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.legionContactsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.legionContactsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.legionContactsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.legionContactsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.legionContactsBindingNavigator.Name = "legionContactsBindingNavigator";
            this.legionContactsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.legionContactsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.legionContactsBindingNavigator.Size = new System.Drawing.Size(1327, 25);
            this.legionContactsBindingNavigator.TabIndex = 1;
            this.legionContactsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(81, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // legionContactsBindingNavigatorSaveItem
            // 
            this.legionContactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.legionContactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("legionContactsBindingNavigatorSaveItem.Image")));
            this.legionContactsBindingNavigatorSaveItem.Name = "legionContactsBindingNavigatorSaveItem";
            this.legionContactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.legionContactsBindingNavigatorSaveItem.Text = "Save Data";
            this.legionContactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.legionContactsBindingNavigatorSaveItem_Click);
            // 
            // contactIDLabel
            // 
            contactIDLabel.AutoSize = true;
            contactIDLabel.Location = new System.Drawing.Point(63, 87);
            contactIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            contactIDLabel.Name = "contactIDLabel";
            contactIDLabel.Size = new System.Drawing.Size(97, 21);
            contactIDLabel.TabIndex = 2;
            contactIDLabel.Text = "Contact ID:";
            // 
            // contactIDTextBox
            // 
            this.contactIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.legionContactsBindingSource, "ContactID", true));
            this.contactIDTextBox.Location = new System.Drawing.Point(230, 82);
            this.contactIDTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.contactIDTextBox.Name = "contactIDTextBox";
            this.contactIDTextBox.Size = new System.Drawing.Size(331, 33);
            this.contactIDTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(63, 129);
            nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 21);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.legionContactsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(230, 124);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(331, 33);
            this.nameTextBox.TabIndex = 5;
            // 
            // legionLabel
            // 
            legionLabel.AutoSize = true;
            legionLabel.Location = new System.Drawing.Point(63, 171);
            legionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            legionLabel.Name = "legionLabel";
            legionLabel.Size = new System.Drawing.Size(67, 21);
            legionLabel.TabIndex = 6;
            legionLabel.Text = "Legion:";
            // 
            // legionTextBox
            // 
            this.legionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.legionContactsBindingSource, "Legion", true));
            this.legionTextBox.Location = new System.Drawing.Point(230, 166);
            this.legionTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.legionTextBox.Name = "legionTextBox";
            this.legionTextBox.Size = new System.Drawing.Size(331, 33);
            this.legionTextBox.TabIndex = 7;
            // 
            // voxFrequencyLabel
            // 
            voxFrequencyLabel.AutoSize = true;
            voxFrequencyLabel.Location = new System.Drawing.Point(63, 213);
            voxFrequencyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            voxFrequencyLabel.Name = "voxFrequencyLabel";
            voxFrequencyLabel.Size = new System.Drawing.Size(129, 21);
            voxFrequencyLabel.TabIndex = 8;
            voxFrequencyLabel.Text = "Vox Frequency:";
            // 
            // voxFrequencyTextBox
            // 
            this.voxFrequencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.legionContactsBindingSource, "VoxFrequency", true));
            this.voxFrequencyTextBox.Location = new System.Drawing.Point(230, 208);
            this.voxFrequencyTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.voxFrequencyTextBox.Name = "voxFrequencyTextBox";
            this.voxFrequencyTextBox.Size = new System.Drawing.Size(331, 33);
            this.voxFrequencyTextBox.TabIndex = 9;
            // 
            // isLoyalLabel
            // 
            isLoyalLabel.AutoSize = true;
            isLoyalLabel.Location = new System.Drawing.Point(63, 258);
            isLoyalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            isLoyalLabel.Name = "isLoyalLabel";
            isLoyalLabel.Size = new System.Drawing.Size(76, 21);
            isLoyalLabel.TabIndex = 10;
            isLoyalLabel.Text = "is Loyal:";
            // 
            // isLoyalCheckBox
            // 
            this.isLoyalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.legionContactsBindingSource, "isLoyal", true));
            this.isLoyalCheckBox.Location = new System.Drawing.Point(230, 250);
            this.isLoyalCheckBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.isLoyalCheckBox.Name = "isLoyalCheckBox";
            this.isLoyalCheckBox.Size = new System.Drawing.Size(333, 39);
            this.isLoyalCheckBox.TabIndex = 11;
            this.isLoyalCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastTransmissionLabel
            // 
            lastTransmissionLabel.AutoSize = true;
            lastTransmissionLabel.Location = new System.Drawing.Point(63, 305);
            lastTransmissionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lastTransmissionLabel.Name = "lastTransmissionLabel";
            lastTransmissionLabel.Size = new System.Drawing.Size(159, 21);
            lastTransmissionLabel.TabIndex = 12;
            lastTransmissionLabel.Text = "Last Transmission:";
            // 
            // lastTransmissionDateTimePicker
            // 
            this.lastTransmissionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.legionContactsBindingSource, "LastTransmission", true));
            this.lastTransmissionDateTimePicker.Location = new System.Drawing.Point(230, 299);
            this.lastTransmissionDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lastTransmissionDateTimePicker.Name = "lastTransmissionDateTimePicker";
            this.lastTransmissionDateTimePicker.Size = new System.Drawing.Size(344, 33);
            this.lastTransmissionDateTimePicker.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1327, 703);
            this.Controls.Add(contactIDLabel);
            this.Controls.Add(this.contactIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(legionLabel);
            this.Controls.Add(this.legionTextBox);
            this.Controls.Add(voxFrequencyLabel);
            this.Controls.Add(this.voxFrequencyTextBox);
            this.Controls.Add(isLoyalLabel);
            this.Controls.Add(this.isLoyalCheckBox);
            this.Controls.Add(lastTransmissionLabel);
            this.Controls.Add(this.lastTransmissionDateTimePicker);
            this.Controls.Add(this.legionContactsBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Vox Net";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legionContactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legionContactsBindingNavigator)).EndInit();
            this.legionContactsBindingNavigator.ResumeLayout(false);
            this.legionContactsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactsDBDataSet contactsDBDataSet;
        private System.Windows.Forms.BindingSource legionContactsBindingSource;
        private ContactsDBDataSetTableAdapters.LegionContactsTableAdapter legionContactsTableAdapter;
        private ContactsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator legionContactsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton legionContactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox legionTextBox;
        private System.Windows.Forms.TextBox voxFrequencyTextBox;
        private System.Windows.Forms.CheckBox isLoyalCheckBox;
        private System.Windows.Forms.DateTimePicker lastTransmissionDateTimePicker;
    }
}

