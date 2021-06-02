using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWProductViewer
{
    public partial class AWProductViewerControl : UserControl
    {
        List<Product> products = new List<Product>();
        List<string> sizes = new List<string>();
        List<string> colors = new List<string>();

        public AWProductViewerControl()
        {
            InitializeComponent();
        }       

        private int _productModelID;

        public int ProductModel
        {
            get { return _productModelID; }
            set 
            { 
                _productModelID = value;
                showProductModelInfo();
            }
        }
        
        private void showProductModelInfo()
        {            
            if (ProductModel != 0)
            {
                products = DataAccess.getProductModel(ProductModel);
                setImage();

                foreach (Product p in products)
                {
                    sizes.Add(p.Size);
                    colors.Add(p.Color);
                }
                sizes = removeDuplicates(sizes);
                colors = removeDuplicates(colors);
                createButtons();
            }
        }

        private void setImage()
        {
            ProductImage productImage = DataAccess.GetImage(ProductModel);
            byte[] photo = productImage.LargePhoto;
            MemoryStream ms = new MemoryStream(photo);
            Image image = Image.FromStream(ms);
            pictureBox1.Image = image;
        }

        public List<string> removeDuplicates(List<string> duplicated)
        {
            List<string> noDuplicated = new List<string>();
            foreach (var prod in duplicated)
            {
                Boolean x = true;
                foreach (var prod2 in noDuplicated)
                {
                    if (prod2 == prod)
                    {
                        x = false;
                    }
                }
                if (x == true)
                {
                    noDuplicated.Add(prod);
                }
            }
            return noDuplicated;
        }

        public void createButtons()
        {
            foreach (string s in sizes)
            {
                Button sizeButton = new Button();

                if (s == null)
                    sizeButton.Text = "NULL";
                else
                    sizeButton.Text = s;

                sizeButton.Click += selectButtonSize;
                sizeFlowLayoutPanel.Controls.Add(sizeButton);
            }

            foreach (string c in colors)
            {
                Button colorButton = new Button();

                if (c == null)
                    colorButton.Text = "NULL";
                else
                    colorButton.Text = c;

                colorButton.Click += selectButtonColor;
                colorFlowLayoutPanel.Controls.Add(colorButton);
            }
        }

        private void selectButtonSize(object sender, EventArgs e)
        {
            
        }

        private void selectButtonColor(object sender, EventArgs e)
        {
            string color = ((Button)sender).Text;
            
            
        }
    }
}
