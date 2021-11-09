using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeniVidiDidict
{
    public enum InfoCat
    {
        firstIsland,
        secondIsland
    }

    public partial class InfoView : Form
    {
        PictureBox[] images;
        public InfoView(InfoCat category)
        {
            InitializeComponent();
            randomText.Text = "To Learn Fast and Have a Guess \n Lets try to Learn Some Facts";
            addImages();
            displayImages(category);
        }

        private void addImages()
        {
            images = new PictureBox[] {image1, image2, image3, image4, image5, image6 };
        }

        private void displayImages(InfoCat category)
        {
            Bitmap[] imgNames;
            if (category == InfoCat.firstIsland)
            {
                islandTitle.Text = "Island of Bernard Bolzano";
                imgNames = new Bitmap[] { Properties.Resources.infoCat1_1,
                                      Properties.Resources.infoCat1_2,
                                      Properties.Resources.infoCat1_3,
                                      Properties.Resources.infoCat1_4,
                                      Properties.Resources.infoCat1_5,
                                      Properties.Resources.infoCat1_6
                };
                
            } else
            {
                islandTitle.Text = "island of Gottfried Wilhelm Leibniz";
                imgNames = new Bitmap[] { Properties.Resources.infoCat2_1,
                                      Properties.Resources.infoCat2_2,
                                      Properties.Resources.infoCat2_3,
                                      Properties.Resources.infoCat2_4,
                                      Properties.Resources.infoCat2_5,
                                      Properties.Resources.infoCat2_6
                };
            }

            for (int i = 0; i < images.Length; i++)
            {
                images[i].Image = imgNames[i];
            }
        }
    }
}
