namespace Logistik
{
    partial class Lager_Haus
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lager_Haus));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Keller");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Küche");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Garage");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Räume", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Werkzeuge");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Lebensmittel");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Kategorien", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nachfüllen");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ausgemustert");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Status", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDatei = new System.Windows.Forms.ToolStripButton();
            this.btnBearbeiten = new System.Windows.Forms.ToolStripButton();
            this.btnExtras = new System.Windows.Forms.ToolStripButton();
            this.btnHilfe = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnArtikel = new System.Windows.Forms.ToolStripButton();
            this.btnLagerorte = new System.Windows.Forms.ToolStripButton();
            this.btnAufgaben = new System.Windows.Forms.ToolStripButton();
            this.treeNavigation = new System.Windows.Forms.TreeView();
            this.Navigation = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabRegister = new System.Windows.Forms.TabControl();
            this.tabLagerbestand = new System.Windows.Forms.TabPage();
            this.tabAufgaben = new System.Windows.Forms.TabPage();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDatei,
            this.btnBearbeiten,
            this.btnExtras,
            this.btnHilfe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnDatei
            // 
            this.btnDatei.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDatei.Image = ((System.Drawing.Image)(resources.GetObject("btnDatei.Image")));
            this.btnDatei.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDatei.Name = "btnDatei";
            this.btnDatei.Size = new System.Drawing.Size(38, 22);
            this.btnDatei.Text = "Datei";
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBearbeiten.Image = ((System.Drawing.Image)(resources.GetObject("btnBearbeiten.Image")));
            this.btnBearbeiten.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(67, 22);
            this.btnBearbeiten.Text = "Bearbeiten";
            // 
            // btnExtras
            // 
            this.btnExtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExtras.Image = ((System.Drawing.Image)(resources.GetObject("btnExtras.Image")));
            this.btnExtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(41, 22);
            this.btnExtras.Text = "Extras";
            // 
            // btnHilfe
            // 
            this.btnHilfe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHilfe.Image = ((System.Drawing.Image)(resources.GetObject("btnHilfe.Image")));
            this.btnHilfe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHilfe.Name = "btnHilfe";
            this.btnHilfe.Size = new System.Drawing.Size(36, 22);
            this.btnHilfe.Text = "Hilfe";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArtikel,
            this.btnLagerorte,
            this.btnAufgaben});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1000, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // btnArtikel
            // 
            this.btnArtikel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnArtikel.Image = ((System.Drawing.Image)(resources.GetObject("btnArtikel.Image")));
            this.btnArtikel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArtikel.Name = "btnArtikel";
            this.btnArtikel.Size = new System.Drawing.Size(45, 22);
            this.btnArtikel.Text = "Artikel";
            // 
            // btnLagerorte
            // 
            this.btnLagerorte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLagerorte.Image = ((System.Drawing.Image)(resources.GetObject("btnLagerorte.Image")));
            this.btnLagerorte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLagerorte.Name = "btnLagerorte";
            this.btnLagerorte.Size = new System.Drawing.Size(61, 22);
            this.btnLagerorte.Text = "Lagerorte";
            // 
            // btnAufgaben
            // 
            this.btnAufgaben.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAufgaben.Image = ((System.Drawing.Image)(resources.GetObject("btnAufgaben.Image")));
            this.btnAufgaben.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAufgaben.Name = "btnAufgaben";
            this.btnAufgaben.Size = new System.Drawing.Size(63, 22);
            this.btnAufgaben.Text = "Aufgaben";
            // 
            // treeNavigation
            // 
            this.treeNavigation.Location = new System.Drawing.Point(11, 64);
            this.treeNavigation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeNavigation.Name = "treeNavigation";
            treeNode1.Name = "knotenKeller";
            treeNode1.Text = "Keller";
            treeNode2.Name = "knotenKüche";
            treeNode2.Text = "Küche";
            treeNode3.Name = "knotenGarage";
            treeNode3.Text = "Garage";
            treeNode4.Name = "knotenRäume";
            treeNode4.Text = "Räume";
            treeNode5.Name = "knotenWerkzeuge";
            treeNode5.Text = "Werkzeuge";
            treeNode6.Name = "knotenLebensmittel";
            treeNode6.Text = "Lebensmittel";
            treeNode7.Name = "knotenKategorien";
            treeNode7.Text = "Kategorien";
            treeNode8.Name = "knotenNachfüllen";
            treeNode8.Text = "Nachfüllen";
            treeNode9.Name = "knotenAusgemustert";
            treeNode9.Text = "Ausgemustert";
            treeNode10.Name = "knotenStatus";
            treeNode10.Text = "Status";
            this.treeNavigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode10});
            this.treeNavigation.Size = new System.Drawing.Size(171, 389);
            this.treeNavigation.TabIndex = 2;
            this.treeNavigation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNavigation_AfterSelect);
            // 
            // Navigation
            // 
            this.Navigation.AutoSize = true;
            this.Navigation.Location = new System.Drawing.Point(6, 50);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(61, 13);
            this.Navigation.TabIndex = 3;
            this.Navigation.Text = "Navigation:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.tabLagerbestand);
            this.tabRegister.Controls.Add(this.tabAufgaben);
            this.tabRegister.Controls.Add(this.tabDashboard);
            this.tabRegister.Location = new System.Drawing.Point(187, 50);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.SelectedIndex = 0;
            this.tabRegister.Size = new System.Drawing.Size(801, 403);
            this.tabRegister.TabIndex = 7;
            // 
            // tabLagerbestand
            // 
            this.tabLagerbestand.BackColor = System.Drawing.Color.Transparent;
            this.tabLagerbestand.Location = new System.Drawing.Point(4, 22);
            this.tabLagerbestand.Name = "tabLagerbestand";
            this.tabLagerbestand.Padding = new System.Windows.Forms.Padding(3);
            this.tabLagerbestand.Size = new System.Drawing.Size(793, 377);
            this.tabLagerbestand.TabIndex = 0;
            this.tabLagerbestand.Text = "Lagerbestand";
            // 
            // tabAufgaben
            // 
            this.tabAufgaben.Location = new System.Drawing.Point(4, 22);
            this.tabAufgaben.Name = "tabAufgaben";
            this.tabAufgaben.Padding = new System.Windows.Forms.Padding(3);
            this.tabAufgaben.Size = new System.Drawing.Size(793, 377);
            this.tabAufgaben.TabIndex = 1;
            this.tabAufgaben.Text = "Aufgaben";
            this.tabAufgaben.UseVisualStyleBackColor = true;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(793, 377);
            this.tabDashboard.TabIndex = 2;
            this.tabDashboard.Text = "Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // Lager_Haus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 478);
            this.Controls.Add(this.tabRegister);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Navigation);
            this.Controls.Add(this.treeNavigation);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lager_Haus";
            this.Text = "Logistik - Haus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDatei;
        private System.Windows.Forms.ToolStripButton btnBearbeiten;
        private System.Windows.Forms.ToolStripButton btnExtras;
        private System.Windows.Forms.ToolStripButton btnHilfe;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnArtikel;
        private System.Windows.Forms.ToolStripButton btnLagerorte;
        private System.Windows.Forms.ToolStripButton btnAufgaben;
        private System.Windows.Forms.TreeView treeNavigation;
        private System.Windows.Forms.Label Navigation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabRegister;
        private System.Windows.Forms.TabPage tabLagerbestand;
        private System.Windows.Forms.TabPage tabAufgaben;
        private System.Windows.Forms.TabPage tabDashboard;
    }
}

