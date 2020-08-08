namespace Cards
{
    partial class Desk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desk));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadCards = new System.Windows.Forms.ToolStripButton();
            this.StackCards = new System.Windows.Forms.ToolStripButton();
            this.DeckCards = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadCards,
            this.StackCards,
            this.DeckCards});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LoadCards
            // 
            this.LoadCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadCards.Image = ((System.Drawing.Image)(resources.GetObject("LoadCards.Image")));
            this.LoadCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadCards.Name = "LoadCards";
            this.LoadCards.Size = new System.Drawing.Size(65, 22);
            this.LoadCards.Text = "load cards";
            this.LoadCards.Click += new System.EventHandler(this.LoadCards_Click);
            // 
            // StackCards
            // 
            this.StackCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StackCards.Image = ((System.Drawing.Image)(resources.GetObject("StackCards.Image")));
            this.StackCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StackCards.Name = "StackCards";
            this.StackCards.Size = new System.Drawing.Size(38, 22);
            this.StackCards.Text = "stack";
            this.StackCards.Click += new System.EventHandler(this.StackCards_Click);
            // 
            // DeckCards
            // 
            this.DeckCards.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeckCards.Image = ((System.Drawing.Image)(resources.GetObject("DeckCards.Image")));
            this.DeckCards.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeckCards.Name = "DeckCards";
            this.DeckCards.Size = new System.Drawing.Size(36, 22);
            this.DeckCards.Text = "deck";
            this.DeckCards.Click += new System.EventHandler(this.DeckCards_Click);
            // 
            // Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Desk";
            this.Text = "playing cards";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton LoadCards;
        private System.Windows.Forms.ToolStripButton StackCards;
        private System.Windows.Forms.ToolStripButton DeckCards;
    }
}

