namespace S133193Example
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
            this.customGridControl2 = new S133193Example.CustomGridControl();
            this.customGridView1 = new S133193Example.CustomGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customGridControl2
            // 
            this.customGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGridControl2.Location = new System.Drawing.Point(0, 0);
            this.customGridControl2.MainView = this.customGridView1;
            this.customGridControl2.Name = "customGridControl2";
            this.customGridControl2.Size = new System.Drawing.Size(853, 535);
            this.customGridControl2.TabIndex = 0;
            this.customGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView1});
            // 
            // customGridView1
            // 
            this.customGridView1.GridControl = this.customGridControl2;
            this.customGridView1.Name = "customGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 535);
            this.Controls.Add(this.customGridControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGridControl customGridControl2;
        private CustomGridView customGridView1;

    }
}

