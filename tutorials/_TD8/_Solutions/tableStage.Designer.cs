namespace TD6___Reut.Compo
{
    partial class tableStage
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
            System.Windows.Forms.Label numeroStageLabel;
            System.Windows.Forms.Label nomEntrepriseLabel;
            System.Windows.Forms.Label sujetLabel;
            System.Windows.Forms.Label nombreStagiairesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableStage));
            this._TD6_ReutCompoDataSet = new TD6___Reut.Compo._TD6_ReutCompoDataSet();
            this.stagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stagesTableAdapter = new TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.StagesTableAdapter();
            this.stagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numeroStageTextBox = new System.Windows.Forms.TextBox();
            this.nomEntrepriseTextBox = new System.Windows.Forms.TextBox();
            this.sujetLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nombreStagiairesTextBox = new System.Windows.Forms.TextBox();
            numeroStageLabel = new System.Windows.Forms.Label();
            nomEntrepriseLabel = new System.Windows.Forms.Label();
            sujetLabel = new System.Windows.Forms.Label();
            nombreStagiairesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._TD6_ReutCompoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesBindingNavigator)).BeginInit();
            this.stagesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroStageLabel
            // 
            numeroStageLabel.AutoSize = true;
            numeroStageLabel.Location = new System.Drawing.Point(32, 43);
            numeroStageLabel.Name = "numeroStageLabel";
            numeroStageLabel.Size = new System.Drawing.Size(76, 13);
            numeroStageLabel.TabIndex = 2;
            numeroStageLabel.Text = "numero Stage:";
            // 
            // nomEntrepriseLabel
            // 
            nomEntrepriseLabel.AutoSize = true;
            nomEntrepriseLabel.Location = new System.Drawing.Point(32, 69);
            nomEntrepriseLabel.Name = "nomEntrepriseLabel";
            nomEntrepriseLabel.Size = new System.Drawing.Size(80, 13);
            nomEntrepriseLabel.TabIndex = 4;
            nomEntrepriseLabel.Text = "nom Entreprise:";
            // 
            // sujetLabel
            // 
            sujetLabel.AutoSize = true;
            sujetLabel.Location = new System.Drawing.Point(32, 89);
            sujetLabel.Name = "sujetLabel";
            sujetLabel.Size = new System.Drawing.Size(32, 13);
            sujetLabel.TabIndex = 6;
            sujetLabel.Text = "sujet:";
            // 
            // nombreStagiairesLabel
            // 
            nombreStagiairesLabel.AutoSize = true;
            nombreStagiairesLabel.Location = new System.Drawing.Point(32, 118);
            nombreStagiairesLabel.Name = "nombreStagiairesLabel";
            nombreStagiairesLabel.Size = new System.Drawing.Size(94, 13);
            nombreStagiairesLabel.TabIndex = 8;
            nombreStagiairesLabel.Text = "nombre Stagiaires:";
            // 
            // _TD6_ReutCompoDataSet
            // 
            this._TD6_ReutCompoDataSet.DataSetName = "_TD6_ReutCompoDataSet";
            this._TD6_ReutCompoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stagesBindingSource
            // 
            this.stagesBindingSource.DataMember = "Stages";
            this.stagesBindingSource.DataSource = this._TD6_ReutCompoDataSet;
            // 
            // stagesTableAdapter
            // 
            this.stagesTableAdapter.ClearBeforeFill = true;
            // 
            // stagesBindingNavigator
            // 
            this.stagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stagesBindingNavigator.BindingSource = this.stagesBindingSource;
            this.stagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stagesBindingNavigatorSaveItem});
            this.stagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stagesBindingNavigator.Name = "stagesBindingNavigator";
            this.stagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stagesBindingNavigator.Size = new System.Drawing.Size(318, 25);
            this.stagesBindingNavigator.TabIndex = 0;
            this.stagesBindingNavigator.Text = "bindingNavigator1";
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
            // stagesBindingNavigatorSaveItem
            // 
            this.stagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stagesBindingNavigatorSaveItem.Image")));
            this.stagesBindingNavigatorSaveItem.Name = "stagesBindingNavigatorSaveItem";
            this.stagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stagesBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.stagesBindingNavigatorSaveItem.Click += new System.EventHandler(this.stagesBindingNavigatorSaveItem_Click);
            // 
            // numeroStageTextBox
            // 
            this.numeroStageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stagesBindingSource, "numeroStage", true));
            this.numeroStageTextBox.Location = new System.Drawing.Point(132, 40);
            this.numeroStageTextBox.Name = "numeroStageTextBox";
            this.numeroStageTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroStageTextBox.TabIndex = 3;
            // 
            // nomEntrepriseTextBox
            // 
            this.nomEntrepriseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stagesBindingSource, "nomEntreprise", true));
            this.nomEntrepriseTextBox.Location = new System.Drawing.Point(132, 66);
            this.nomEntrepriseTextBox.Name = "nomEntrepriseTextBox";
            this.nomEntrepriseTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomEntrepriseTextBox.TabIndex = 5;
            // 
            // sujetLinkLabel
            // 
            this.sujetLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stagesBindingSource, "sujet", true));
            this.sujetLinkLabel.Location = new System.Drawing.Point(132, 89);
            this.sujetLinkLabel.Name = "sujetLinkLabel";
            this.sujetLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.sujetLinkLabel.TabIndex = 7;
            // 
            // nombreStagiairesTextBox
            // 
            this.nombreStagiairesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stagesBindingSource, "nombreStagiaires", true));
            this.nombreStagiairesTextBox.Location = new System.Drawing.Point(132, 115);
            this.nombreStagiairesTextBox.Name = "nombreStagiairesTextBox";
            this.nombreStagiairesTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreStagiairesTextBox.TabIndex = 9;
            // 
            // tableStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 152);
            this.Controls.Add(numeroStageLabel);
            this.Controls.Add(this.numeroStageTextBox);
            this.Controls.Add(nomEntrepriseLabel);
            this.Controls.Add(this.nomEntrepriseTextBox);
            this.Controls.Add(sujetLabel);
            this.Controls.Add(this.sujetLinkLabel);
            this.Controls.Add(nombreStagiairesLabel);
            this.Controls.Add(this.nombreStagiairesTextBox);
            this.Controls.Add(this.stagesBindingNavigator);
            this.Name = "tableStage";
            this.Text = "TableStage";
            this.Load += new System.EventHandler(this.TableStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this._TD6_ReutCompoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesBindingNavigator)).EndInit();
            this.stagesBindingNavigator.ResumeLayout(false);
            this.stagesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _TD6_ReutCompoDataSet _TD6_ReutCompoDataSet;
        private System.Windows.Forms.BindingSource stagesBindingSource;
        private TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.StagesTableAdapter stagesTableAdapter;
        private System.Windows.Forms.BindingNavigator stagesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stagesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numeroStageTextBox;
        private System.Windows.Forms.TextBox nomEntrepriseTextBox;
        private System.Windows.Forms.LinkLabel sujetLinkLabel;
        private System.Windows.Forms.TextBox nombreStagiairesTextBox;
    }
}