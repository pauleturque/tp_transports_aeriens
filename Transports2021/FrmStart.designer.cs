
namespace Transports2021
{
  partial class FrmStart
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuConnexion = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDéconnexion = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDonnées = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuRecupération = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuCreationBase = new System.Windows.Forms.ToolStripMenuItem();
      this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aProposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuConfiguration = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuAdministration = new System.Windows.Forms.ToolStripMenuItem();
      this.motDePasseAdministrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuQuitAdmin = new System.Windows.Forms.ToolStripMenuItem();
      this.stsMain = new System.Windows.Forms.StatusStrip();
      this.stsConnecté = new System.Windows.Forms.ToolStripStatusLabel();
      this.stsProgress = new System.Windows.Forms.ToolStripProgressBar();
      this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDestinations = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.stsMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.mnuDonnées,
            this.gestionToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.mnuAdministration});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(904, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConnexion,
            this.mnuDéconnexion,
            this.mnuQuitter});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
      this.fichierToolStripMenuItem.Text = "Fichier";
      // 
      // mnuConnexion
      // 
      this.mnuConnexion.Name = "mnuConnexion";
      this.mnuConnexion.Size = new System.Drawing.Size(179, 26);
      this.mnuConnexion.Text = "Connexion";
      this.mnuConnexion.Click += new System.EventHandler(this.mnuConnexion_Click);
      // 
      // mnuDéconnexion
      // 
      this.mnuDéconnexion.Name = "mnuDéconnexion";
      this.mnuDéconnexion.Size = new System.Drawing.Size(179, 26);
      this.mnuDéconnexion.Text = "Déconnexion";
      this.mnuDéconnexion.Click += new System.EventHandler(this.mnuDéconnexion_Click);
      // 
      // mnuQuitter
      // 
      this.mnuQuitter.Name = "mnuQuitter";
      this.mnuQuitter.Size = new System.Drawing.Size(179, 26);
      this.mnuQuitter.Text = "Quitter";
      this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
      // 
      // mnuDonnées
      // 
      this.mnuDonnées.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecupération,
            this.mnuCreationBase});
      this.mnuDonnées.Name = "mnuDonnées";
      this.mnuDonnées.Size = new System.Drawing.Size(81, 24);
      this.mnuDonnées.Text = "Données";
      // 
      // mnuRecupération
      // 
      this.mnuRecupération.Name = "mnuRecupération";
      this.mnuRecupération.Size = new System.Drawing.Size(336, 26);
      this.mnuRecupération.Text = "Récupération des données originales";
      this.mnuRecupération.Click += new System.EventHandler(this.mnuRecupération_Click);
      // 
      // mnuCreationBase
      // 
      this.mnuCreationBase.Name = "mnuCreationBase";
      this.mnuCreationBase.Size = new System.Drawing.Size(336, 26);
      this.mnuCreationBase.Text = "Creation de la base de données";
      this.mnuCreationBase.Click += new System.EventHandler(this.mnuCreationBase_Click);
      // 
      // aProposToolStripMenuItem
      // 
      this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem1,
            this.mnuConfiguration});
      this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
      this.aProposToolStripMenuItem.Size = new System.Drawing.Size(30, 24);
      this.aProposToolStripMenuItem.Text = "?";
      // 
      // aProposToolStripMenuItem1
      // 
      this.aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
      this.aProposToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
      this.aProposToolStripMenuItem1.Text = "A propos";
      this.aProposToolStripMenuItem1.Click += new System.EventHandler(this.aProposToolStripMenuItem1_Click);
      // 
      // mnuConfiguration
      // 
      this.mnuConfiguration.Name = "mnuConfiguration";
      this.mnuConfiguration.Size = new System.Drawing.Size(183, 26);
      this.mnuConfiguration.Text = "Configuration";
      this.mnuConfiguration.Click += new System.EventHandler(this.mnuConfiguration_Click);
      // 
      // mnuAdministration
      // 
      this.mnuAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motDePasseAdministrateurToolStripMenuItem,
            this.mnuQuitAdmin});
      this.mnuAdministration.Name = "mnuAdministration";
      this.mnuAdministration.Size = new System.Drawing.Size(121, 24);
      this.mnuAdministration.Text = "Administration";
      this.mnuAdministration.Visible = false;
      // 
      // motDePasseAdministrateurToolStripMenuItem
      // 
      this.motDePasseAdministrateurToolStripMenuItem.Name = "motDePasseAdministrateurToolStripMenuItem";
      this.motDePasseAdministrateurToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
      this.motDePasseAdministrateurToolStripMenuItem.Text = "Mot de passe Administrateur";
      this.motDePasseAdministrateurToolStripMenuItem.Click += new System.EventHandler(this.motDePasseAdministrateurToolStripMenuItem_Click);
      // 
      // mnuQuitAdmin
      // 
      this.mnuQuitAdmin.Name = "mnuQuitAdmin";
      this.mnuQuitAdmin.Size = new System.Drawing.Size(297, 26);
      this.mnuQuitAdmin.Text = "Quitter le mode administrateur";
      this.mnuQuitAdmin.Click += new System.EventHandler(this.mnuQuitAdmin_Click);
      // 
      // stsMain
      // 
      this.stsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsConnecté,
            this.stsProgress});
      this.stsMain.Location = new System.Drawing.Point(0, 365);
      this.stsMain.Name = "stsMain";
      this.stsMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
      this.stsMain.Size = new System.Drawing.Size(904, 25);
      this.stsMain.SizingGrip = false;
      this.stsMain.TabIndex = 1;
      this.stsMain.Text = "statusStrip1";
      // 
      // stsConnecté
      // 
      this.stsConnecté.AutoSize = false;
      this.stsConnecté.Name = "stsConnecté";
      this.stsConnecté.Size = new System.Drawing.Size(80, 19);
      this.stsConnecté.Text = "Déconnecté";
      // 
      // stsProgress
      // 
      this.stsProgress.Name = "stsProgress";
      this.stsProgress.Size = new System.Drawing.Size(133, 17);
      // 
      // gestionToolStripMenuItem
      // 
      this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDestinations});
      this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
      this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
      this.gestionToolStripMenuItem.Text = "Gestion";
      // 
      // mnuDestinations
      // 
      this.mnuDestinations.Name = "mnuDestinations";
      this.mnuDestinations.Size = new System.Drawing.Size(224, 26);
      this.mnuDestinations.Text = "Destinations";
      this.mnuDestinations.Click += new System.EventHandler(this.mnuDestinations_Click);
      // 
      // FrmStart
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(904, 390);
      this.Controls.Add(this.stsMain);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmStart";
      this.Text = "Formulaire Initial Standard";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStart_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStart_FormClosed);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmStart_Paint);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmStart_KeyUp);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.stsMain.ResumeLayout(false);
      this.stsMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuConnexion;
    private System.Windows.Forms.ToolStripMenuItem mnuDéconnexion;
    private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
    private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuAdministration;
    private System.Windows.Forms.StatusStrip stsMain;
    private System.Windows.Forms.ToolStripStatusLabel stsConnecté;
    private System.Windows.Forms.ToolStripMenuItem motDePasseAdministrateurToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuQuitAdmin;
    private System.Windows.Forms.ToolStripProgressBar stsProgress;
    private System.Windows.Forms.ToolStripMenuItem mnuConfiguration;
    private System.Windows.Forms.ToolStripMenuItem mnuDonnées;
    private System.Windows.Forms.ToolStripMenuItem mnuRecupération;
    private System.Windows.Forms.ToolStripMenuItem mnuCreationBase;
    private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuDestinations;
  }
}

