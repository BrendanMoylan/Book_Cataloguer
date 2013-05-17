namespace BookCataloguer
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
            this.addBook = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBooks = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBook
            // 
            this.addBook.Location = new System.Drawing.Point(12, 138);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(100, 23);
            this.addBook.TabIndex = 0;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 29);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(12, 69);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(100, 20);
            this.authorBox.TabIndex = 4;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(12, 112);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(100, 20);
            this.genreBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genre";
            // 
            // listBooks
            // 
            this.listBooks.Location = new System.Drawing.Point(119, 138);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(100, 23);
            this.listBooks.TabIndex = 7;
            this.listBooks.Text = "List Books";
            this.listBooks.UseVisualStyleBackColor = true;
            this.listBooks.Click += new System.EventHandler(this.listBooks_Click);
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(119, 29);
            this.listBox.Multiline = true;
            this.listBox.Name = "listBox";
            this.listBox.ReadOnly = true;
            this.listBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listBox.Size = new System.Drawing.Size(206, 103);
            this.listBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(225, 138);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(225, 167);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 23);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(119, 167);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(100, 23);
            this.randomButton.TabIndex = 11;
            this.randomButton.Text = "Pick Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 222);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.addBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listBooks;
        private System.Windows.Forms.TextBox listBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button randomButton;
    }
}

