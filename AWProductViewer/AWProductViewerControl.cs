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
        Button selectedSize = new Button();
        Button selectedColor = new Button();

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

                foreach (Product p in products)
                {
                    sizes.Add(p.Size);
                    colors.Add(p.Color);
                }
                sizes = removeDuplicates(sizes);
                colors = removeDuplicates(colors);

                productNameTextBox.Text = products[0].Name;
                productIDTextBox.Text = products[0].ProductModel;

                createButtons();
                setImage();
            }
        }

        private void setImage()
        {
            ProductImage productImage = new ProductImage();
            productImage = DataAccess.GetImage(ProductModel, selectedColor.Text);
            byte[] photo = productImage.LargePhoto;
            MemoryStream ms = new MemoryStream(photo);
            Image image = Image.FromStream(ms);
            pictureBox1.Image = image;
        }

        private void refreshInfo()
        {
            foreach (Product p in products)
            {
                if ((p.Size == selectedSize.Text) && (p.Color == selectedColor.Text))
                {
                    productNameTextBox.Text = p.Name;
                    productIDTextBox.Text = p.ProductModel; 
                }
            }
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
            int x = 0;
            int y = 0;

            foreach (string s in sizes)
            {
                Button sizeButton = new Button();

                if (s == null)
                    sizeButton.Text = "NULL";
                else
                    sizeButton.Text = s;

                sizeButton.Click += buttonSize_Click;

                if (x == 0)
                {
                    sizeButton.BackColor = Color.DarkGray;
                    selectedColor = sizeButton;
                }
                x++;

                sizeFlowLayoutPanel.Controls.Add(sizeButton);
            }

            foreach (string c in colors)
            {
                Button colorButton = new Button();

                if (c == null)
                    colorButton.Text = "NULL";
                else
                    colorButton.Text = c;

                colorButton.Click += buttonColor_Click;

                if (y == 0)
                {
                    colorButton.BackColor = Color.DarkGray;
                    selectedColor = colorButton;
                }
                y++;

                colorFlowLayoutPanel.Controls.Add(colorButton);
            }
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b = (Button)sender;

            if (b.Text != selectedSize.Text)
            {
                b.BackColor = Color.DarkGray;
                selectedSize.BackColor = Color.Transparent;
                selectedSize = b;
                refreshInfo();
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b = (Button)sender;
            
            if (b.Text != selectedColor.Text)
            {
                b.BackColor = Color.DarkGray;
                selectedColor.BackColor = Color.Transparent;
                selectedColor = b;
                refreshInfo();
                setImage();
            }
        }
    }
}
