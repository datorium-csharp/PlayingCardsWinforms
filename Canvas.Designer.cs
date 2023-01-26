namespace PlayingCardsWinforms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stackCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCardsToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createCardsToolStripMenuItem
            // 
            this.createCardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCardsToolStripMenuItem});
            this.createCardsToolStripMenuItem.Name = "createCardsToolStripMenuItem";
            this.createCardsToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.createCardsToolStripMenuItem.Text = "Create cards";
            this.createCardsToolStripMenuItem.Click += new System.EventHandler(this.createCardsToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipCardsToolStripMenuItem,
            this.deckCardsToolStripMenuItem,
            this.stackCardsToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click);
            // 
            // flipCardsToolStripMenuItem
            // 
            this.flipCardsToolStripMenuItem.Name = "flipCardsToolStripMenuItem";
            this.flipCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flipCardsToolStripMenuItem.Text = "Flip cards";
            this.flipCardsToolStripMenuItem.Click += new System.EventHandler(this.flipCardsToolStripMenuItem_Click);
            // 
            // deckCardsToolStripMenuItem
            // 
            this.deckCardsToolStripMenuItem.Name = "deckCardsToolStripMenuItem";
            this.deckCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deckCardsToolStripMenuItem.Text = "Deck cards";
            this.deckCardsToolStripMenuItem.Click += new System.EventHandler(this.deckCardsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // stackCardsToolStripMenuItem
            // 
            this.stackCardsToolStripMenuItem.Name = "stackCardsToolStripMenuItem";
            this.stackCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stackCardsToolStripMenuItem.Text = "Stack cards";
            this.stackCardsToolStripMenuItem.Click += new System.EventHandler(this.stackCardsToolStripMenuItem_Click);
            // 
            // loadCardsToolStripMenuItem
            // 
            this.loadCardsToolStripMenuItem.Name = "loadCardsToolStripMenuItem";
            this.loadCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadCardsToolStripMenuItem.Text = "Load cards";
            this.loadCardsToolStripMenuItem.Click += new System.EventHandler(this.loadCardsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 467);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createCardsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deckCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCardsToolStripMenuItem;
    }
}

