namespace FoodMenu
{
    partial class ProductsListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsListsForm));
            this.checkedProductsListBox = new System.Windows.Forms.CheckedListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedProductsListBox
            // 
            this.checkedProductsListBox.FormattingEnabled = true;
            this.checkedProductsListBox.Location = new System.Drawing.Point(12, 71);
            this.checkedProductsListBox.Name = "checkedProductsListBox";
            this.checkedProductsListBox.Size = new System.Drawing.Size(385, 312);
            this.checkedProductsListBox.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.Location = new System.Drawing.Point(128, 25);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(20, 28);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "_";
            // 
            // ProductsListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 394);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.checkedProductsListBox);
            this.Name = "ProductsListsForm";
            this.Text = "ProductsListsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductsListsForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductsListsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CheckedListBox checkedProductsListBox;
        public Label lblProducts;
    }
}