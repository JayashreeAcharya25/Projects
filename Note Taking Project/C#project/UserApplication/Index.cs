using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Index : Form
    {
        
        public Index()
        {
            InitializeComponent();
            
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
           doubleBufferPanel3.BackColor = Color.FromArgb(125, Color.Black);
           doubleBufferPanel3.Visible = false;
        

           Image myimage = new Bitmap(@"C:\Users\PERSONAL\Desktop\c#\images\images.jpg");
           this.BackgroundImage = myimage;
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

                if (linkLabel1.Text == "Getting Started with .NET Framework 4.0")
                {               
                    ch1 f = new ch1();
                    f.Show();
                }

                else if (linkLabel1.Text == "Classes, Objects and Structures")
                {
                    ch3 f = new ch3();
                    f.Show();
                }
                else  if (linkLabel1.Text == "Delegates")
                {
                    ch10 f = new ch10();
                    f.Show();
                }
                else if (linkLabel1.Text == "Multithreaded Programming")
                {
                    ch15 f = new ch15();
                    f.Show();
                }
                else if (linkLabel1.Text == "Graphical User Interface with Windows Forms")
                {
                    ch19 f = new ch19();
                    f.Show();
                }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel2.Text == "Introducing c#")
            {               
               ch2 f = new ch2();
                f.Show();
            }
            else if (linkLabel2.Text == "Methods")
            {
                ch4 f = new ch4();
                f.Show();
            }
            else if (linkLabel2.Text == "Events")
            {
                ch11 f = new ch11();
                f.Show();
            }
            else if (linkLabel2.Text == "Working with Collections")
            {
                ch16 f = new ch16();
                f.Show();
            }
            else if (linkLabel2.Text == "Data Access with ADO.NET")
            {
                ch20 f = new ch20();
                f.Show();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel3.Text == "Properties")
            {
                ch5 f = new ch5();
                f.Show();
            }
            else if (linkLabel3.Text == "Exception Handling")
            {
                ch12 f = new ch12();
                f.Show();
            }
            else if (linkLabel3.Text == "Building Components")
            {
                ch17 f = new ch17();
                f.Show();
            }
            else if (linkLabel3.Text == "Web Development Using .Net")
            {
                ch21 f = new ch21();
                f.Show();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel4.Text == "Encapsulation")
            {
                ch6 f = new ch6();
                f.Show();
            }
            else if (linkLabel4.Text == "Namespaces, the Preprocessor and Assemblies")
            {
                ch13 f = new ch13();
                f.Show();
            }
            else if (linkLabel4.Text == "Using I/O")
            {
                ch18 f = new ch18();
                f.Show();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel5.Text == "Inheritance")
            {
                ch7 f = new ch7();
                f.Show();
            }
            else if (linkLabel5.Text == "Reflection and Attributes")
            {
                ch14 f = new ch14();
                f.Show();
            }
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel6.Text == "Polymorphism and Abstraction")
            {
                ch8 f = new ch8();
                f.Show();
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel7.Text == "Interface")
            {
                ch9 f = new ch9();
                f.Show();
            }
        }


        private void cmdUnit1_Click_1(object sender, EventArgs e)
        {
            doubleBufferPanel3.Visible = true;

            linkLabel1.Visible = true;
            linkLabel2.Visible = true;

            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;

            linkLabel1.Text = "Getting Started with .NET Framework 4.0";
            linkLabel2.Text = "Introducing c#";                   
        }

        private void cmdUnit2_Click_1(object sender, EventArgs e)
        {
            doubleBufferPanel3.Visible = true;

            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            linkLabel4.Visible = true;
            linkLabel5.Visible = true;
            linkLabel6.Visible = true;
            linkLabel7.Visible = true;

            linkLabel1.Text = "Classes, Objects and Structures";
            linkLabel2.Text = "Methods";
            linkLabel3.Text = "Properties";
            linkLabel4.Text = "Encapsulation";
            linkLabel5.Text = "Inheritance";
            linkLabel6.Text = "Polymorphism and Abstraction";
            linkLabel7.Text = "Interface";
        }

        private void cmdUnit3_Click_1(object sender, EventArgs e)
        {
            doubleBufferPanel3.Visible = true;

            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            linkLabel4.Visible = true;
            linkLabel5.Visible = true;

            linkLabel6.Visible = false;
            linkLabel7.Visible = false;

            linkLabel1.Text = "Delegates";
            linkLabel2.Text = "Events";
            linkLabel3.Text = "Exception Handling";
            linkLabel4.Text = "Namespaces, the Preprocessor and Assemblies";
            linkLabel5.Text = "Reflection and Attributes";
        }

        private void cmdUnit4_Click_1(object sender, EventArgs e)
        {
            doubleBufferPanel3.Visible = true;

            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            linkLabel4.Visible = true;

            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;

            linkLabel1.Text = "Multithreaded Programming";
            linkLabel2.Text = "Working with Collections";
            linkLabel3.Text = "Building Components";
            linkLabel4.Text = "Using I/O";
        }

        private void cmdUnit5_Click_1(object sender, EventArgs e)
        {
            doubleBufferPanel3.Visible = true;

            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;

            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;

            linkLabel1.Text = "Graphical User Interface with Windows Forms";
            linkLabel2.Text = "Data Access with ADO.NET";
            linkLabel3.Text = "Web Development Using .Net";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();           
        }

       

        

       
     }

    
       
}

