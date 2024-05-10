using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                listBox1.Items.Add(AddCar());
            }
        }
        private bool isValid()
        {
            if(String.IsNullOrWhiteSpace(this.brandTB.Text))
            {
                brandTB.Focus();
                return false;
            }
            if(String.IsNullOrWhiteSpace(this.modelTB.Text))
            {
                modelTB.Focus();
                return false;
            }
            if(this.engineCB.Text == null)
            {
                engineCB.Focus();
                return false;
            }
            if(this.colorCB.Text == null)
            {
                colorCB.Focus();
                return false;
            }
            if(String.IsNullOrWhiteSpace(this.engineTB.Text))
            {
                engineTB.Focus();
                return false;
            }
            return true;
        }
        private Car AddCar()
        {
            Car car = new Car();
            car.Brand = this.brandTB.Text;
            car.Model = this.modelTB.Text;
            car.EngineType = this.engineCB.Text;
            car.Color = this.colorCB.Text;
            car.EngineV = this.engineTB.Text;
            return car;
        }

        private void removeB_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count != 0)
            {
                if(listBox1.SelectedItems != null)
                {
                    for(int i = 0; i < listBox1.SelectedItems.Count; i++)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItems[i]);
                    }
                }
            }
        }
    }
}
