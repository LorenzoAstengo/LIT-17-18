namespace Exercise09
{
    partial class Exercise09Form
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
            this.description = new System.Windows.Forms.TextBox();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughNextDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(331, 164);
            this.description.TabIndex = 0;
            // 
            // exits
            // 
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(96, 193);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(247, 21);
            this.exits.TabIndex = 1;
            // 
            // goHere
            // 
            this.goHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHere.Location = new System.Drawing.Point(12, 193);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(78, 23);
            this.goHere.TabIndex = 2;
            this.goHere.Text = "Go here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughNextDoor
            // 
            this.goThroughNextDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goThroughNextDoor.Location = new System.Drawing.Point(12, 222);
            this.goThroughNextDoor.Name = "goThroughNextDoor";
            this.goThroughNextDoor.Size = new System.Drawing.Size(331, 22);
            this.goThroughNextDoor.TabIndex = 3;
            this.goThroughNextDoor.Text = "Go through next door";
            this.goThroughNextDoor.UseVisualStyleBackColor = true;
            // 
            // Exercise09Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 256);
            this.Controls.Add(this.goThroughNextDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.description);
            this.Name = "Exercise09Form";
            this.Text = "Exercise09Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughNextDoor;
    }
}