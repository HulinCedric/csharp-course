namespace Stage
{
    partial class FormEtud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtud));
            System.Windows.Forms.Label numEtudLabel;
            System.Windows.Forms.Label nomEtudLabel;
            System.Windows.Forms.Label prenomEtudLabel;
            this.stageDataSet = new Stage.stageDataSet();
            this.tEtudiantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEtudiantsTableAdapter = new Stage.stageDataSetTableAdapters.TEtudiantsTableAdapter();
            this.tableAdapterManager = new Stage.stageDataSetTableAdapters.TableAdapterManager();
            this.tEtudiantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tEtudiantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numEtudTextBox = new System.Windows.Forms.TextBox();
            this.nomEtudTextBox = new System.Windows.Forms.TextBox();
            this.prenomEtudTextBox = new System.Windows.Forms.TextBox();
            numEtudLabel = new System.Windows.Forms.Label();
            nomEtudLabel = new System.Windows.Forms.Label();
            prenomEtudLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEtudiantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEtudiantsBindingNavigator)).BeginInit();
            this.tEtudiantsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // stageDataSet
            // 
            this.stageDataSet.DataSetName = "stageDataSet";
            this.stageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEtudiantsBindingSource
            // 
            this.tEtudiantsBindingSource.DataMember = "TEtudiants";
            this.tEtudiantsBindingSource.DataSource = this.stageDataSet;
            // 
            // tEtudiantsTableAdapter
            // 
            this.tEtudiantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TEtudiantsTableAdapter = this.tEtudiantsTableAdapter;
            this.tableAdapterManager.TStagesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Stage.stageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tEtudiantsBindingNavigator
            // 
            this.tEtudiantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tEtudiantsBindingNavigator.BindingSource = this.tEtudiantsBindingSource;
            this.tEtudiantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tEtudiantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tEtudiantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tEtudiantsBindingNavigatorSaveItem});
            this.tEtudiantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tEtudiantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tEtudiantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tEtudiantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tEtudiantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tEtudiantsBindingNavigator.Name = "tEtudiantsBindingNavigator";
            this.tEtudiantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tEtudiantsBindingNavigator.Size = new System.Drawing.Size(471, 25);
            this.tEtudiantsBindingNavigator.TabIndex = 0;
            this.tEtudiantsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // tEtudiantsBindingNavigatorSaveItem
            // 
            this.tEtudiantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tEtudiantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tEtudiantsBindingNavigatorSaveItem.Image")));
            this.tEtudiantsBindingNavigatorSaveItem.Name = "tEtudiantsBindingNavigatorSaveItem";
            this.tEtudiantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tEtudiantsBindingNavigatorSaveItem.Text = "Enregistrer les données";
           
            // 
            // numEtudLabel
            // 
            numEtudLabel.AutoSize = true;
            numEtudLabel.Location = new System.Drawing.Point(77, 58);
            numEtudLabel.Name = "numEtudLabel";
            numEtudLabel.Size = new System.Drawing.Size(55, 13);
            numEtudLabel.TabIndex = 1;
            numEtudLabel.Text = "num Etud:";
            // 
            // numEtudTextBox
            // 
            this.numEtudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEtudiantsBindingSource, "numEtud", true));
            this.numEtudTextBox.Location = new System.Drawing.Point(138, 55);
            this.numEtudTextBox.Name = "numEtudTextBox";
            this.numEtudTextBox.Size = new System.Drawing.Size(100, 20);
            this.numEtudTextBox.TabIndex = 2;
            // 
            // nomEtudLabel
            // 
            nomEtudLabel.AutoSize = true;
            nomEtudLabel.Location = new System.Drawing.Point(77, 125);
            nomEtudLabel.Name = "nomEtudLabel";
            nomEtudLabel.Size = new System.Drawing.Size(55, 13);
            nomEtudLabel.TabIndex = 3;
            nomEtudLabel.Text = "nom Etud:";
            // 
            // nomEtudTextBox
            // 
            this.nomEtudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEtudiantsBindingSource, "nomEtud", true));
            this.nomEtudTextBox.Location = new System.Drawing.Point(138, 122);
            this.nomEtudTextBox.Name = "nomEtudTextBox";
            this.nomEtudTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomEtudTextBox.TabIndex = 4;
            // 
            // prenomEtudLabel
            // 
            prenomEtudLabel.AutoSize = true;
            prenomEtudLabel.Location = new System.Drawing.Point(62, 185);
            prenomEtudLabel.Name = "prenomEtudLabel";
            prenomEtudLabel.Size = new System.Drawing.Size(70, 13);
            prenomEtudLabel.TabIndex = 5;
            prenomEtudLabel.Text = "prenom Etud:";
            // 
            // prenomEtudTextBox
            // 
            this.prenomEtudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEtudiantsBindingSource, "prenomEtud", true));
            this.prenomEtudTextBox.Location = new System.Drawing.Point(138, 182);
            this.prenomEtudTextBox.Name = "prenomEtudTextBox";
            this.prenomEtudTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomEtudTextBox.TabIndex = 6;
            // 
            // FormEtud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 284);
            this.Controls.Add(prenomEtudLabel);
            this.Controls.Add(this.prenomEtudTextBox);
            this.Controls.Add(nomEtudLabel);
            this.Controls.Add(this.nomEtudTextBox);
            this.Controls.Add(numEtudLabel);
            this.Controls.Add(this.numEtudTextBox);
            this.Controls.Add(this.tEtudiantsBindingNavigator);
            this.Name = "FormEtud";
            this.Text = "FormEtud";
            this.Load += new System.EventHandler(this.FormEtud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEtudiantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEtudiantsBindingNavigator)).EndInit();
            this.tEtudiantsBindingNavigator.ResumeLayout(false);
            this.tEtudiantsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private stageDataSet stageDataSet;
        private System.Windows.Forms.BindingSource tEtudiantsBindingSource;
        private Stage.stageDataSetTableAdapters.TEtudiantsTableAdapter tEtudiantsTableAdapter;
        private Stage.stageDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tEtudiantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tEtudiantsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numEtudTextBox;
        private System.Windows.Forms.TextBox nomEtudTextBox;
        private System.Windows.Forms.TextBox prenomEtudTextBox;


    }
}