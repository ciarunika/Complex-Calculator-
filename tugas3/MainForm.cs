using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas3{

	public partial class MainForm : Form{
		
		public MainForm(){
			InitializeComponent();
		}
		
		void TextBox3TextChanged(object sender, EventArgs e){
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e){
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e){
		}
		void RadioButton3CheckedChanged(object sender, EventArgs e){
		}
		void RadioButton4CheckedChanged(object sender, EventArgs e){
		}
		
		void Button1Click(object sender, EventArgs e){
		
			double r1,r2,i1,i2,real,imajiner;
			
			r1 = Convert.ToDouble(textBox1.Text);
			r2 = Convert.ToDouble(textBox3.Text);
			i1 = Convert.ToDouble(textBox2.Text);
			i2 = Convert.ToDouble(textBox4.Text);
			
			if (radioButton1.Checked == true){
			
				real = (r1+r2);
				imajiner = (i1+i2);
				
				label6.Text = real.ToString();
				label7.Text = imajiner.ToString();
			}
			
			else if (radioButton2.Checked == true){
				
				real = (r1-r2);
				imajiner = (i1-i2);
				
				label6.Text = real.ToString();
				label7.Text = imajiner.ToString();
			}
			
			else if(radioButton3.Checked == true){
				
				real = (r1*r2)-(i1*i2);
				imajiner = (r1*i2 )+(i1*r2);
				
				label6.Text = real.ToString();
				label7.Text = imajiner.ToString();
			}
			
			else if (radioButton4.Checked == true){
				
				real = (r1*r2+i1*i2)/(r2*r2+i2*i2);
				imajiner = (r2*i1-r1*i2)/(r2*r2+i2*i2);
				
				label6.Text = real.ToString();
				label7.Text = imajiner.ToString();
			}
		}
		
		void Button2Click(object sender, EventArgs e){
			
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			label6.Text = String.Empty;
			label7.Text = String.Empty;
			
			radioButton1.Checked  = false ;
			radioButton2.Checked  = false ;
			radioButton3.Checked  = false ;
			radioButton4.Checked  = false ;
		}
		
		void Button3Click(object sender, EventArgs e){
			Environment.Exit(0);
		}
	}
}
