using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadoraintento3
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;
        private int operacion;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
            Size = new Size(391, 374);
            textBox1.Size = new Size(350, 60);
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            Size = new Size(493, 374);
            textBox2.Size = new Size(452, 45);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(387, 405);
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //numero 0
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //numero 1
            textBox1.Text = textBox1.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //numero 2
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //numero 3
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //numero 4
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //numero 5
            textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //numero 6
            textBox1.Text = textBox1.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //numero 7
            textBox1.Text = textBox1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
           //numero 8
            textBox1.Text = textBox1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //numero 9
            textBox1.Text = textBox1.Text + "9";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //igual
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (valor2 == 0) textBox1.Text = "infinito";
                    resultado = valor1 / valor2;
                    break;
            }      
            textBox1.Text = resultado.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //bton multipli
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //boton divi
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "A";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "B";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "C";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "D";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "E";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "F";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //bton multipli
            operacion = 3;
            valor1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //boton divi
            operacion = 4;
            valor1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //igual
            valor2 = Convert.ToDouble(textBox2.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (valor2 == 0) textBox2.Text = "infinito";
                    resultado = valor1 / valor2;
                    break;
            }
            textBox2.Text = resultado.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button24.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button25.Enabled = true;
            button22.Enabled = true;
            button32.Enabled = true;
            button28.Enabled = true;
            button27.Enabled = true;
            button29.Enabled = true;
            button31.Enabled = true;
            button30.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button25.Enabled = true;
            button22.Enabled = true;
            button32.Enabled = true;
            button28.Enabled = true;
            button27.Enabled = true;
            button29.Enabled = true;
            button31.Enabled = true;
            button30.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button25.Enabled = true;
            button22.Enabled = true;
            button32.Enabled = true;
            button28.Enabled = true;
            button27.Enabled = true;
            button29.Enabled = true;
            button31.Enabled = false;
            button30.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button25.Enabled = false;
            button22.Enabled = false;
            button32.Enabled = false;
            button28.Enabled = false;
            button27.Enabled = false;
            button29.Enabled = false;
            button31.Enabled = false;
            button30.Enabled = false;
        }

    }
}
