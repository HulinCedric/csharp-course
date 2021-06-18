namespace TD6___Reut.Compo
{
    partial class tableEtudiant
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numEtudiantLabel;
            System.Windows.Forms.Label nomEtudiantLabel;
            System.Windows.Forms.Label prenomEtudiantLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableEtudiant));
            this._TD6_ReutCompoDataSet1 = new TD6___Reut.Compo._TD6_ReutCompoDataSet();
            this.etudiantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantsTableAdapter = new TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.EtudiantsTableAdapter();
            this.etudiantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.etudiantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numEtudiantTextBox = new System.Windows.Forms.TextBox();
            this.nomEtudiantTextBox = new System.Windows.Forms.TextBox();
            this.prenomEtudiantTextBox = new System.Windows.Forms.TextBox();
            numEtudiantLabel = new System.Windows.Forms.Label();
            nomEtudiantLabel = new System.Windows.Forms.Label();
            prenomEtudiantLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._TD6_ReutCompoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingNavigator)).BeginInit();
            this.etudiantsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numEtudiantLabel
            // 
            numEtudiantLabel.AutoSize = true;
            numEtudiantLabel.Location = new System.Drawing.Point(41, 48);
            numEtudiantLabel.Name = "numEtudiantLabel";
            numEtudiantLabel.Size = new System.Drawing.Size(72, 13);
            numEtudiantLabel.TabIndex = 1;
            numEtudiantLabel.Text = "num Etudiant:";
            // 
            // nomEtudiantLabel
            // 
            nomEtudiantLabel.AutoSize = true;
            nomEtudiantLabel.Location = new System.Drawing.Point(42, 81);
            nomEtudiantLabel.Name = "nomEtudiantLabel";
            nomEtudiantLabel.Size = new System.Drawing.Size(72, 13);
            nomEtudiantLabel.TabIndex = 3;
            nomEtudiantLabel.Text = "nom Etudiant:";
            // 
            // prenomEtudiantLabel
            // 
            prenomEtudiantLabel.AutoSize = true;
            prenomEtudiantLabel.Location = new System.Drawing.Point(27, 116);
            prenomEtudiantLabel.Name = "prenomEtudiantLabel";
            prenomEtudiantLabel.Size = new System.Drawing.Size(87, 13);
            prenomEtudiantLabel.TabIndex = 5;
            prenomEtudiantLabel.Text = "prenom Etudiant:";
            // 
            // _TD6_ReutCompoDataSet1
            // 
            this._TD6_ReutCompoDataSet1.DataSetName = "_TD6_ReutCompoDataSet";
            this._TD6_ReutCompoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantsBindingSource
            // 
            this.etudiantsBindingSource.DataMember = "Etudiants";
            this.etudiantsBindingSource.DataSource = this._TD6_ReutCompoDataSet1;
            // 
            // etudiantsTableAdapter
            // 
            this.etudiantsTableAdapter.ClearBeforeFill = true;
            // 
            // etudiantsBindingNavigator
            // 
            this.etudiantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.etudiantsBindingNavigator.BindingSource = this.etudiantsBindingSource;
            this.etudiantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.etudiantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.etudiantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.etudiantsBindingNavigatorSaveItem});
            this.etudiantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.etudiantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.etudiantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.etudiantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.etudiantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.etudiantsBindingNavigator.Name = "etudiantsBindingNavigator";
            this.etudiantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.etudiantsBindingNavigator.Size = new System.Drawing.Size(299, 25);
            this.etudiantsBindingNavigator.TabIndex = 0;
            this.etudiantsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
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
            // etudiantsBindingNavigatorSaveItem
            // 
            this.etudiantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.etudiantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("etudiantsBindingNavigatorSaveItem.Image")));
            this.etudiantsBindingNavigatorSaveItem.Name = "etudiantsBindingNavigatorSaveItem";
            this.etudiantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.etudiantsBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.etudiantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.etudiantsBindingNavigatorSaveItem_Click);
            // 
            // numEtudiantTextBox
            // 
            this.numEtudiantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantsBindingSource, "numEtudiant", true));
            this.numEtudiantTextBox.Location = new System.Drawing.Point(119, 45);
            this.numEtudiantTextBox.Name = "numEtudiantTextBox";
            this.numEtudiantTextBox.Size = new System.Drawing.Size(100, 20);
            this.numEtudiantTextBox.TabIndex = 2;
            // 
            // nomEtudiantTextBox
            // 
            this.nomEtudiantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantsBindingSource, "nomEtudiant", true));
            this.nomEtudiantTextBox.Location = new System.Drawing.Point(120, 78);
            this.nomEtudiantTextBox.Name = "nomEtudiantTextBox";
            this.nomEtudiantTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomEtudiantTextBox.TabIndex = 4;
            // 
            // prenomEtudiantTextBox
            // 
            this.prenomEtudiantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantsBindingSource, "prenomEtudiant", true));
            this.prenomEtudiantTextBox.Location = new System.Drawing.Point(120, 113);
            this.prenomEtudiantTextBox.Name = "prenomEtudiantTextBox";
            this.prenomEtudiantTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomEtudiantTextBox.TabIndex = 6;
            // 
            // tableEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 146);
            this.Controls.Add(prenomEtudiantLabel);
            this.Controls.Add(this.prenomEtudiantTextBox);
            this.Controls.Add(nomEtudiantLabel);
            this.Controls.Add(this.nomEtudiantTextBox);
            this.Controls.Add(numEtudiantLabel);
            this.Controls.Add(this.numEtudiantTextBox);
            this.Controls.Add(this.etudiantsBindingNavigator);
            this.Name = "tableEtudiant";
            this.Text = "tableEtudiant";
            this.Load += new System.EventHandler(this.tableEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this._TD6_ReutCompoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingNavigator)).EndInit();
            this.etudiantsBindingNavigator.ResumeLayout(false);
            this.etudiantsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _TD6_ReutCompoDataSet _TD6_ReutCompoDataSet1;
        private System.Windows.Forms.BindingSource etudiantsBindingSource;
        private TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.EtudiantsTableAdapter etudiantsTableAdapter;
        private System.Windows.Forms.BindingNavigator etudiantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton etudiantsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numEtudiantTextBox;
        private System.Windows.Forms.TextBox nomEtudiantTextBox;
        private System.Windows.Forms.TextBox prenomEtudiantTextBox;


    }
}