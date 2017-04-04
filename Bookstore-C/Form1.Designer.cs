namespace Bookstore_C
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iBookStoreServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveBookFromCartButton = new System.Windows.Forms.Button();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.CloseApplicationButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ListOfBooksFound = new System.Windows.Forms.ListBox();
            this.CartBox = new System.Windows.Forms.ListBox();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.StatusLog = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iBookStoreServiceBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckoutButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CloseApplicationButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // iBookStoreServiceBindingSource
            // 
            this.iBookStoreServiceBindingSource.DataSource = typeof(BookStore.IBookStoreService);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RemoveBookFromCartButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CartBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(425, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(205, 470);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ClearLogButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.StatusLog, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(636, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(206, 470);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // RemoveBookFromCartButton
            // 
            this.RemoveBookFromCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveBookFromCartButton.Location = new System.Drawing.Point(3, 426);
            this.RemoveBookFromCartButton.Name = "RemoveBookFromCartButton";
            this.RemoveBookFromCartButton.Size = new System.Drawing.Size(199, 41);
            this.RemoveBookFromCartButton.TabIndex = 0;
            this.RemoveBookFromCartButton.Text = "Remove from cart";
            this.RemoveBookFromCartButton.UseVisualStyleBackColor = true;
            this.RemoveBookFromCartButton.Click += new System.EventHandler(this.RemoveBookFromCartButton_Click);
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearLogButton.Location = new System.Drawing.Point(3, 426);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(200, 41);
            this.ClearLogButton.TabIndex = 0;
            this.ClearLogButton.Text = "Clear log";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click_1);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckoutButton.Location = new System.Drawing.Point(425, 479);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(205, 47);
            this.CheckoutButton.TabIndex = 2;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseApplicationButton.Location = new System.Drawing.Point(636, 479);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(206, 47);
            this.CloseApplicationButton.TabIndex = 3;
            this.CloseApplicationButton.Text = "Close";
            this.CloseApplicationButton.UseVisualStyleBackColor = true;
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplicationButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.ListOfBooksFound, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.SearchField, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(416, 470);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.AddToCartButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 422);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(410, 45);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToCartButton.Location = new System.Drawing.Point(3, 3);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(199, 39);
            this.AddToCartButton.TabIndex = 0;
            this.AddToCartButton.Text = "Add to cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ListOfBooksFound
            // 
            this.ListOfBooksFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfBooksFound.FormattingEnabled = true;
            this.ListOfBooksFound.Location = new System.Drawing.Point(3, 27);
            this.ListOfBooksFound.Name = "ListOfBooksFound";
            this.ListOfBooksFound.Size = new System.Drawing.Size(410, 389);
            this.ListOfBooksFound.TabIndex = 1;
            // 
            // CartBox
            // 
            this.CartBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartBox.FormattingEnabled = true;
            this.CartBox.Location = new System.Drawing.Point(3, 3);
            this.CartBox.Name = "CartBox";
            this.CartBox.Size = new System.Drawing.Size(199, 417);
            this.CartBox.TabIndex = 1;
            // 
            // SearchField
            // 
            this.SearchField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchField.Location = new System.Drawing.Point(3, 3);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(410, 20);
            this.SearchField.TabIndex = 2;
            this.SearchField.Text = "Search...";
            this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
            // 
            // StatusLog
            // 
            this.StatusLog.AutoSize = true;
            this.StatusLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLog.Location = new System.Drawing.Point(3, 0);
            this.StatusLog.Name = "StatusLog";
            this.StatusLog.Size = new System.Drawing.Size(200, 423);
            this.StatusLog.TabIndex = 1;
            this.StatusLog.Text = "Log...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Bookstore";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iBookStoreServiceBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource iBookStoreServiceBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button RemoveBookFromCartButton;
        private System.Windows.Forms.ListBox CartBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Label StatusLog;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ListBox ListOfBooksFound;
        private System.Windows.Forms.TextBox SearchField;
    }
}

