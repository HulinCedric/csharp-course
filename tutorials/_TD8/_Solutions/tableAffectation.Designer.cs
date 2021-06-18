namespace TD6___Reut.Compo
{
    partial class tableAffectation
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
            System.Windows.Forms.Label nomEtudiantLabel1;
            System.Windows.Forms.Label prenomEtudiantLabel;
            System.Windows.Forms.Label nomEntrepriseLabel;
            this._TD6_ReutCompoDataSet = new TD6___Reut.Compo._TD6_ReutCompoDataSet();
            this.etudiantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantsTableAdapter = new TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.EtudiantsTableAdapter();
            this.nomsEtudiantsListBox = new System.Windows.Forms.ListBox();
            this.stagesListBox = new System.Windows.Forms.ListBox();
            this.stagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stagesTableAdapter = new TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.StagesTableAdapter();
            this.prenomEtudiantTB = new System.Windows.Forms.TextBox();
            this.entrepriseTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nomEtudiantLabel1 = new System.Windows.Forms.Label();
            prenomEtudiantLabel = new System.Windows.Forms.Label();
            nomEntrepriseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._TD6_ReutCompoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomEtudiantLabel1
            // 
            nomEtudiantLabel1.AutoSize = true;
            nomEtudiantLabel1.Location = new System.Drawing.Point(30, 55);
            nomEtudiantLabel1.Name = "nomEtudiantLabel1";
            nomEtudiantLabel1.Size = new System.Drawing.Size(77, 13);
            nomEtudiantLabel1.TabIndex = 3;
            nomEtudiantLabel1.Text = "Nom Etudiant :";
            // 
            // prenomEtudiantLabel
            // 
            prenomEtudiantLabel.AutoSize = true;
            prenomEtudiantLabel.Location = new System.Drawing.Point(15, 236);
            prenomEtudiantLabel.Name = "prenomEtudiantLabel";
            prenomEtudiantLabel.Size = new System.Drawing.Size(91, 13);
            prenomEtudiantLabel.TabIndex = 5;
            prenomEtudiantLabel.Text = "Prenom Etudiant :";
            // 
            // nomEntrepriseLabel
            // 
            nomEntrepriseLabel.AutoSize = true;
            nomEntrepriseLabel.Location = new System.Drawing.Point(398, 236);
            nomEntrepriseLabel.Name = "nomEntrepriseLabel";
            nomEntrepriseLabel.Size = new System.Drawing.Size(60, 13);
            nomEntrepriseLabel.TabIndex = 7;
            nomEntrepriseLabel.Text = "Entreprise :";
            // 
            // _TD6_ReutCompoDataSet
            // 
            this._TD6_ReutCompoDataSet.DataSetName = "_TD6_ReutCompoDataSet";
            this._TD6_ReutCompoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantsBindingSource
            // 
            this.etudiantsBindingSource.DataMember = "Etudiants";
            this.etudiantsBindingSource.DataSource = this._TD6_ReutCompoDataSet;
            // 
            // etudiantsTableAdapter
            // 
            this.etudiantsTableAdapter.ClearBeforeFill = true;
            // 
            // nomsEtudiantsListBox
            // 
            this.nomsEtudiantsListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.etudiantsBindingSource, "nomEtudiant", true));
            this.nomsEtudiantsListBox.FormattingEnabled = true;
            this.nomsEtudiantsListBox.Location = new System.Drawing.Point(108, 55);
            this.nomsEtudiantsListBox.Name = "nomsEtudiantsListBox";
            this.nomsEtudiantsListBox.Size = new System.Drawing.Size(195, 121);
            this.nomsEtudiantsListBox.TabIndex = 4;
            this.nomsEtudiantsListBox.SelectedIndexChanged += new System.EventHandler(this.nomsEtudiantsListBox_SelectedIndexChanged);
            // 
            // stagesListBox
            // 
            this.stagesListBox.FormattingEnabled = true;
            this.stagesListBox.Location = new System.Drawing.Point(423, 55);
            this.stagesListBox.Name = "stagesListBox";
            this.stagesListBox.Size = new System.Drawing.Size(194, 121);
            this.stagesListBox.TabIndex = 5;
            this.stagesListBox.SelectedIndexChanged += new System.EventHandler(this.stagesListBox_SelectedIndexChanged);
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
            // prenomEtudiantTB
            // 
            this.prenomEtudiantTB.Location = new System.Drawing.Point(108, 236);
            this.prenomEtudiantTB.Name = "prenomEtudiantTB";
            this.prenomEtudiantTB.Size = new System.Drawing.Size(100, 20);
            this.prenomEtudiantTB.TabIndex = 9;
            // 
            // entrepriseTB
            // 
            this.entrepriseTB.Location = new System.Drawing.Point(464, 236);
            this.entrepriseTB.Name = "entrepriseTB";
            this.entrepriseTB.Size = new System.Drawing.Size(100, 20);
            this.entrepriseTB.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Attribuer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAffectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entrepriseTB);
            this.Controls.Add(this.prenomEtudiantTB);
            this.Controls.Add(nomEntrepriseLabel);
            this.Controls.Add(prenomEtudiantLabel);
            this.Controls.Add(this.stagesListBox);
            this.Controls.Add(nomEtudiantLabel1);
            this.Controls.Add(this.nomsEtudiantsListBox);
            this.Name = "tableAffectation";
            this.Text = "tableAffectation";
            this.Load += new System.EventHandler(this.tableAffectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this._TD6_ReutCompoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _TD6_ReutCompoDataSet _TD6_ReutCompoDataSet;
        private System.Windows.Forms.BindingSource etudiantsBindingSource;
        private TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.EtudiantsTableAdapter etudiantsTableAdapter;
        private System.Windows.Forms.ListBox nomsEtudiantsListBox;
        private System.Windows.Forms.ListBox stagesListBox;
        private System.Windows.Forms.BindingSource stagesBindingSource;
        private TD6___Reut.Compo._TD6_ReutCompoDataSetTableAdapters.StagesTableAdapter stagesTableAdapter;
        private System.Windows.Forms.TextBox prenomEtudiantTB;
        private System.Windows.Forms.TextBox entrepriseTB;
        private System.Windows.Forms.Button button1;
    }
}