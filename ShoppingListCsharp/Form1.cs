using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListCsharp
{
    public partial class Form1 : Form
    {
        List<string> shoppingList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_saveNewItem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tb_input.Text)) //not empty
            {
                shoppingList.Add(tb_input.Text);
                tb_input.Clear();
            }            
        }

        private void btn_readShoppingList_Click(object sender, EventArgs e)
        {
            tb_output.Clear();

            foreach (var listItem in shoppingList)
            {
                tb_output.Text += listItem;
                tb_output.Text += Environment.NewLine;
            }
        }
    }
}
