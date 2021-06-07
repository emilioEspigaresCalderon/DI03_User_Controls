using AWProductViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWUserInterface
{
    public partial class Form1 : Form
    {
        List<int> productModelIDs = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productModelIDs = DataAccess.getProductModelIDs();

            createProductViewers();
        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {
            createProductViewers();
        }

        private void createProductViewers()
        {
            int i = 0;
            while (i != 2)
            {
                AWProductViewerControl productViewer = new AWProductViewerControl();
                userControlsFlowLayoutPanel.Controls.Add(productViewer);

                Random r = new Random();
                int random = r.Next(productModelIDs.Count);

                if (productModelIDs.Count == 0)
                {
                    MessageBox.Show("Showing all available products");
                    i = 2;
                }
                else { 
                    productViewer.ProductModel = productModelIDs[random];
                    productModelIDs.RemoveAt(random);
                    i++;
                }
            }
        }
    }
}
