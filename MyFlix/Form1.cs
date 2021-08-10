using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can choose as many downloads as you want \n by holding down the Ctrl key while making selections");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            

            //create a list of strings(these can be populated later with the Add method)
            List<string> arr = new List<string>();
            
            //iterate through all the items
            for (int x = 0; x < listBox2.Items.Count; ++x) {
                System.Diagnostics.Debug.WriteLine(x);
                //if the item is selected, add it to the list
                System.Diagnostics.Debug.WriteLine(listBox2.GetSelected(x));
                if (listBox2.GetSelected(x))
                {
                    arr.Add(listBox2.Items[x].ToString());
                    
                }
            }
           
              
            //convert the list to an array and save it
            string[] newArr = arr.ToArray(); 
            //iterate through that array
            for(int x = 0; x < newArr.Length; ++x)
            {
                if(x == newArr.Length - 1)
                {
                    
                    switch (newArr[x])
                    {
                        case "Dirk Gently's Hollistic Detective Agency":
                            this.BackgroundImage = Image.FromFile(@"C:\Users\1\OneDrive\Pictures\dirkgently.jpg");
                            break;
                        case "Parks And Recreation":
                            this.BackgroundImage = Image.FromFile(@"C:\Users\1\OneDrive\Pictures\parks.jpg");
                            break;
                        case "Living with yourself":
                            this.BackgroundImage = Image.FromFile(@"C:\Users\1\OneDrive\Pictures\living.jpg");
                            break;
                        case "The Office":
                            this.BackgroundImage = Image.FromFile(@"C:\Users\1\OneDrive\Pictures\office.png");
                            break;
                        case "Community":
                            this.BackgroundImage = Image.FromFile(@"C:\Users\1\OneDrive\Pictures\community.jpg");
                            break;
                        case "Great News":
                            this.BackgroundImage = Image.FromFile(@"C:\Users\1\OneDrive\Pictures\news.jpg");
                            break;
                        default:
                            this.BackgroundImage = Image.FromFile(@"C:\Users\1\OneDrive\Pictures\flix.jpg");
                            break;

                    }
                    
                }
            }
          

            string word = String.Join("\n", newArr);

            MyGlobals.Cost = 1.99 * listBox2.SelectedIndices.Count;
            lblSelected.Text = word;
            lblCost.Text = $"Total: N${MyGlobals.Cost.ToString()}";
        }
    }
}

public static class MyGlobals
{
    public static double Cost =  0;
}


