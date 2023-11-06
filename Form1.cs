namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuItem1;
        private ToolStripMenuItem menuItem2;
        private ToolStripMenuItem menuItem3;
        private ToolStripMenuItem subMenuItem1;
        private ToolStripMenuItem subMenuItem2;
        private ToolStripMenuItem menuItem4;
        private ToolStripMenuItem menuItem5;

        public Form1()
        {
            menuStrip = new MenuStrip();
            menuItem1 = new ToolStripMenuItem("Пункт 1");
            menuItem2 = new ToolStripMenuItem("Пункт 2");
            menuItem3 = new ToolStripMenuItem("Пункт 3");
            subMenuItem1 = new ToolStripMenuItem("Подпункт 1");
            subMenuItem2 = new ToolStripMenuItem("Подпункт 2");
            menuItem4 = new ToolStripMenuItem("Пункт 4");
            menuItem5 = new ToolStripMenuItem("Пункт 5");
            menuItem1.BackColor = Color.Red;
            menuItem1.ForeColor = Color.White;
            menuItem2.BackColor = Color.Green;
            menuItem2.ForeColor = Color.White;
            menuItem3.BackColor = Color.Blue;
            menuItem3.ForeColor = Color.White;
            subMenuItem1.BackColor = Color.Orange;
            subMenuItem1.ForeColor = Color.White;
            subMenuItem2.BackColor = Color.Purple;
            subMenuItem2.ForeColor = Color.White;
            menuItem4.BackColor = Color.Magenta;
            menuItem4.ForeColor = Color.White;
            menuItem5.BackColor = Color.Teal;
            menuItem5.ForeColor = Color.White;
            menuItem1.Click += MenuItem_Click;
            menuItem2.Click += MenuItem_Click;
            menuItem3.Click += MenuItem_Click;
            subMenuItem1.Click += MenuItem_Click;
            subMenuItem2.Click += MenuItem_Click;
            menuItem4.Click += MenuItem_Click;
            menuItem5.Click += MenuItem_Click;

           
            menuItem3.DropDownItems.Add(subMenuItem1);
            menuItem3.DropDownItems.Add(subMenuItem2);

            
            menuStrip.Items.Add(menuItem1);
            menuStrip.Items.Add(menuItem2);
            menuStrip.Items.Add(menuItem3);
            menuStrip.Items.Add(menuItem4);
            menuStrip.Items.Add(menuItem5);

           
            this.Controls.Add(menuStrip);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            MessageBox.Show("Выбран пункт: " + menuItem.Text);
        }

        
       
    }
}