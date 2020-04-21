﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocVaGuiXe
{
    public partial class fAddMoto : Form
    {
        public fAddMoto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto();
            int id = Convert.ToInt32(txbID.Text);

            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string phone = textBoxPhone.Text;
            int time = Convert.ToInt32(numericUpDownTime.Value);
            DateTime date = dateTimePicker1.Value;

            string type = radioButtonHour.Text;
            if (radioButtonMonth.Checked)
            {
                type = radioButtonMonth.Text;
            }
            if (radioButtonWeek.Checked)
            {
                type = radioButtonWeek.Text;
            }

            if (radioButtonDay.Checked)
            {
                type = radioButtonDay.Text;
            }

            MemoryStream pictureNumberPlate = new MemoryStream();
            MemoryStream pictureOwner = new MemoryStream();

            int born_year = dateTimePicker1.Value.Year;
            int present_year = DateTime.Now.Year;
            //if ((present_year - born_year < 10) || (present_year - born_year) > 100)
            //{
            //    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            //}
            if (verif())
            {
                pictureBoxNumberPlate.Image.Save(pictureNumberPlate, pictureBoxNumberPlate.Image.RawFormat);
                pictureBoxOwner.Image.Save(pictureOwner, pictureBoxOwner.Image.RawFormat);
                if (moto.InsertMoto(id, pictureNumberPlate, pictureOwner, name, address, phone, time, date, type))
                {
                    MessageBox.Show("New Verhicle Added", "Add Verhicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Errol", "Add Verhicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Verhicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((txbID.Text.Trim() == "")
                || (textBoxName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (pictureBoxNumberPlate.Image == null)
                || (pictureBoxOwner.Image == null)
                )
            {
                return false;
            }
            else
                return true;
        }

        private void btnUploadImageNumberPlate_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNumberPlate.Image = Image.FromFile(open.FileName);
            }
        }

        private void buttonUploadImageOwner_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxOwner.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
