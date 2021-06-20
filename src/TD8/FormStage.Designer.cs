namespace Stage
{
    partial class FormStage
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
            System.Windows.Forms.Label numStageLabel;
            System.Windows.Forms.Label nomEntLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label sujetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStage));
            this.stageDataSet = new Stage.stageDataSet();
            this.tStagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tStagesTableAdapter = new Stage.stageDataSetTableAdapters.TStagesTableAdapter();
            this.tableAdapterManager = new Stage.stageDataSetTableAdapters.TableAdapterManager();
            this.tStagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tStagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numStageTextBox = new System.Windows.Forms.TextBox();
            this.nomEntTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.sujetLinkLabel = new System.Windows.Forms.LinkLabel();
            numStageLabel = new System.Windows.Forms.Label();
            nomEntLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            sujetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagesBindingNavigator)).BeginInit();
            this.tStagesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numStageLabel
            // 
            numStageLabel.AutoSize = true;
            numStageLabel.Location = new System.Drawing.Point(61, 82);
            numStageLabel.Name = "numStageLabel";
            numStageLabel.Size = new System.Drawing.Size(61, 13);
            numStageLabel.TabIndex = 1;
            numStageLabel.Text = "num Stage:";
            // 
            // nomEntLabel
            // 
            nomEntLabel.AutoSize = true;
            nomEntLabel.Location = new System.Drawing.Point(61, 108);
            nomEntLabel.Name = "nomEntLabel";
            nomEntLabel.Size = new System.Drawing.Size(49, 13);
            nomEntLabel.TabIndex = 3;
            nomEntLabel.Text = "nom Ent:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(61, 160);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "nombre:";
            // 
            // sujetLabel
            // 
            sujetLabel.AutoSize = true;
            sujetLabel.Location = new System.Drawing.Point(61, 131);
            sujetLabel.Name = "sujetLabel";
            sujetLabel.Size = new System.Drawing.Size(32, 13);
            sujetLabel.TabIndex = 8;
            sujetLabel.Text = "sujet:";
            // 
            // stageDataSet
            // 
            this.stageDataSet.DataSetName = "stageDataSet";
            this.stageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tStagesBindingSource
            // 
            this.tStagesBindingSource.DataMember = "TStages";
            this.tStagesBindingSource.DataSource = this.stageDataSet;
            // 
            // tStagesTableAdapter
            // 
            this.tStagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TEtudiantsTableAdapter = null;
            this.tableAdapterManager.TStagesTableAdapter = this.tStagesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Stage.stageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tStagesBindingNavigator
            // 
            this.tStagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tStagesBindingNavigator.BindingSource = this.tStagesBindingSource;
            this.tStagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tStagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tStagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tStagesBindingNavigatorSaveItem});
            this.tStagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tStagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tStagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tStagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tStagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tStagesBindingNavigator.Name = "tStagesBindingNavigator";
            this.tStagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tStagesBindingNavigator.Size = new System.Drawing.Size(390, 25);
            this.tStagesBindingNavigator.TabIndex = 0;
            this.tStagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tStagesBindingNavigatorSaveItem
            // 
            this.tStagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tStagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tStagesBindingNavigatorSaveItem.Image")));
            this.tStagesBindingNavigatorSaveItem.Name = "tStagesBindingNavigatorSaveItem";
            this.tStagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tStagesBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.tStagesBindingNavigatorSaveItem.Click += new System.EventHandler(this.tStagesBindingNavigatorSaveItem_Click_1);
            // 
            // numStageTextBox
            // 
            this.numStageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tStagesBindingSource, "numStage", true));
            this.numStageTextBox.Location = new System.Drawing.Point(128, 79);
            this.numStageTextBox.Name = "numStageTextBox";
            this.numStageTextBox.Size = new System.Drawing.Size(100, 20);
            this.numStageTextBox.TabIndex = 2;
            // 
            // nomEntTextBox
            // 
            this.nomEntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tStagesBindingSource, "nomEnt", true));
            this.nomEntTextBox.Location = new System.Drawing.Point(128, 105);
            this.nomEntTextBox.Name = "nomEntTextBox";
            this.nomEntTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomEntTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tStagesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(128, 157);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // sujetLinkLabel
            // 
            this.sujetLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tStagesBindingSource, "sujet", true));
            this.sujetLinkLabel.Location = new System.Drawing.Point(125, 131);
            this.sujetLinkLabel.Name = "sujetLinkLabel";
            this.sujetLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.sujetLinkLabel.TabIndex = 9;
            this.sujetLinkLabel.TabStop = true;
            this.sujetLinkLabel.Text = "linkLabel1";
            this.sujetLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sujetLinkLabel_LinkClicked);
            // 
            // FormStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 284);
            this.Controls.Add(sujetLabel);
            this.Controls.Add(this.sujetLinkLabel);
            this.Controls.Add(numStageLabel);
            this.Controls.Add(this.numStageTextBox);
            this.Controls.Add(nomEntLabel);
            this.Controls.Add(this.nomEntTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.tStagesBindingNavigator);
            this.Name = "FormStage";
            this.Text = "FormStage";
            this.Load += new System.EventHandler(this.FormStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStagesBindingNavigator)).EndInit();
            this.tStagesBindingNavigator.ResumeLayout(false);
            this.tStagesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stageDataSet stageDataSet;
        private System.Windows.Forms.BindingSource tStagesBindingSource;
        private Stage.stageDataSetTableAdapters.TStagesTableAdapter tStagesTableAdapter;
        private Stage.stageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tStagesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tStagesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numStageTextBox;
        private System.Windows.Forms.TextBox nomEntTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.LinkLabel sujetLinkLabel;

    }
}