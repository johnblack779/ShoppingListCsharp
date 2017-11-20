namespace ShoppingListCsharp
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
            this.btn_saveNewItem = new System.Windows.Forms.Button();
            this.btn_readShoppingList = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_saveNewItem
            // 
            this.btn_saveNewItem.Location = new System.Drawing.Point(224, 30);
            this.btn_saveNewItem.Name = "btn_saveNewItem";
            this.btn_saveNewItem.Size = new System.Drawing.Size(114, 23);
            this.btn_saveNewItem.TabIndex = 0;
            this.btn_saveNewItem.Text = "Save new item";
            this.btn_saveNewItem.UseVisualStyleBackColor = true;
            this.btn_saveNewItem.Click += new System.EventHandler(this.btn_saveNewItem_Click);
            // 
            // btn_readShoppingList
            // 
            this.btn_readShoppingList.Location = new System.Drawing.Point(224, 59);
            this.btn_readShoppingList.Name = "btn_readShoppingList";
            this.btn_readShoppingList.Size = new System.Drawing.Size(114, 46);
            this.btn_readShoppingList.TabIndex = 0;
            this.btn_readShoppingList.Text = "Update/Read the shopping list";
            this.btn_readShoppingList.UseVisualStyleBackColor = true;
            this.btn_readShoppingList.Click += new System.EventHandler(this.btn_readShoppingList_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(15, 32);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(199, 20);
            this.tb_input.TabIndex = 1;
            // 
            // tb_output
            // 
            this.tb_output.BackColor = System.Drawing.SystemColors.Window;
            this.tb_output.Location = new System.Drawing.Point(344, 32);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(189, 197);
            this.tb_output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shopping List Display:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New item to be added to the shopping list:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.btn_readShoppingList);
            this.Controls.Add(this.btn_saveNewItem);
            this.Name = "Form1";
            this.Text = "Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveNewItem;
        private System.Windows.Forms.Button btn_readShoppingList;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

