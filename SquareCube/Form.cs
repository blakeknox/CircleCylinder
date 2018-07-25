using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareCube
{
    public partial class Form : System.Windows.Forms.Form
    {
        clsCircle Circles = null;
        clsCylinder Cylinder = null;
        public Form()
        {
            InitializeComponent();
            //EnableCircle()
        }

        private void Circle_Load(object sender, EventArgs e)
        {
            DisposeForm();
        }

        //*********************************
        //Procedure: EnableCircle()
        //Sets form for circle
        //
        //*********************************
        private void EnableCircle()
        {
            txtHeight.Clear();
            txtHeight.Enabled = false;
            txtCircumference.Enabled = true;
            txtArea.Enabled = true;
            txtVolume.Clear();
            btnVolume.Enabled = false;

        }

        private void EnableCylinder()
        {
            txtHeight.Enabled = true;
            txtCircumference.Enabled = true;
            txtArea.Enabled = true;
            btnVolume.Enabled = true;
        }
        //**************************************
        //Procedure: Dispose
        //**************************************

        private void DisposeForm()
        {
            rdoCircle.Checked = true;
            txtVolume.Clear();
            txtArea.Clear();
            txtCircumference.Clear();
            txtHeight.Clear();
            txtRadius.Clear();
            btnDefinition.Enabled = false;
            btnVolume.Enabled = false;
            btnDispose.Enabled = false;
            txtError.Text = "";
            Circles = null;
            Cylinder = null;

        }
        //*****************************************
        //Procedure: Button Click Dispose 
        //*****************************************
        private void btnDispose_Click(object sender, EventArgs e)
        {
            DisposeForm();
        }

        //*****************************************
        //Procedure: Circle Checked changed Event
        //*****************************************
        private void rdoCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCircle.Checked)
            {
                EnableCircle();
            }
            else
            {
                EnableCylinder();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (rdoCircle.Checked)
            {
                if(txtRadius.Text.Trim().Length > 0)
                {
                    decimal decRad;
                    if(Circles == null)
                    {
                        try
                        {
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Circles = new clsCircle(decRad);
                        }
                        catch(Exception ex)
                        {
                            txtError.Text = "Radius must be numeric." + ex.Message;
                        }
                    }
                    else
                    {
                        txtError.Text = "Circle already exists.";
                    }
                    btnArea.Enabled = true;
                    btnCircumference.Enabled = true;
                    btnDefinition.Enabled = true;
                    btnDispose.Enabled = true;
                    txtCircumference.Text = Circles.Circumference().ToString();
                    txtArea.Text = Circles.Area().ToString();

                }
                else
                {
                    txtError.Text = "Radius must be greater then zero.";
                }
            }
            else
            {
                if (txtRadius.Text.Trim().Length > 0 && txtHeight.Text.Trim().Length > 0)
                {
                    decimal decRad;
                    decimal decHgt;

                    if (Cylinder == null)
                    {
                        try
                        {
                            decHgt = Convert.ToDecimal(txtHeight.Text);
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Cylinder = new clsCylinder(decRad, decHgt);
                        }
                        catch (Exception ex)
                        {
                            txtError.Text = "Radius and Height must be numeric." + ex.Message;
                        }
                    }
                    else
                    {
                        txtError.Text = "Cylinder already exists.";
                    }
                    btnArea.Enabled = true;
                    btnCircumference.Enabled = true;
                    btnDefinition.Enabled = true;
                    btnDispose.Enabled = true;
                    btnVolume.Enabled = true;
                    txtCircumference.Text = Cylinder.Circumference().ToString();
                    txtArea.Text = Cylinder.Area().ToString();
                    txtVolume.Text = Cylinder.Volume().ToString();
                    
                }
                else
                {
                    txtError.Text = "Radius and Height must be greater then zero.";
                }
            }
            
        }

        //**************************************************************
        //Procedure: Definition Click
        // Checks for what Class is being used and grabs the definition
        // and inputs it into a messagebox to show the user
        //**************************************************************
        private void btnDefinition_Click(object sender, EventArgs e)
        {
            txtError.Text = "";

            if(rdoCircle.Checked)
            {
                if (Circles == null)
                {
                    txtError.Text = "Circle does not exist.";
                }
                else
                {
                    MessageBox.Show(Circles.Definition().ToString(), "Circle Class definition.");
                }
            }
            else
            {
                if (Cylinder == null)
                {
                    txtError.Text = "Cylinder does not exist.";
                }
                else
                {
                    MessageBox.Show(Cylinder.Definition().ToString(), "Cylinder Class definition.");
                }
            }
        }

        //*****************************************************
        //Procudure: Volume
        // Checks for exsiting Cylinder and uses volume from that
        // otherwise it creates a new instance and show a message
        // box with the calculated Volume.
        //*****************************************************
        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (rdoCircle.Checked)
            {
                txtError.Text = "Circles do not have volume.";
            }
            else
            {
                if (txtRadius.Text.Trim().Length > 0 && txtHeight.Text.Trim().Length > 0)
                {
                    decimal decRad;
                    decimal decHgt;
                    if (Cylinder == null)
                    {
                        try
                        {
                            decHgt = Convert.ToDecimal(txtHeight.Text);
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Cylinder = new clsCylinder(decRad, decHgt);
                        }
                        catch (Exception ex)
                        {
                            txtError.Text = "Radius and Height must be numeric." + ex.Message;
                        }
                    }
                    else if(Cylinder.Height != Convert.ToDecimal(txtHeight.Text) || Cylinder.Radius != Convert.ToDecimal(txtRadius.Text))
                    {
                        try
                        {
                            decHgt = Convert.ToDecimal(txtHeight.Text);
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Cylinder = new clsCylinder(decRad, decHgt);
                        }
                        catch (Exception ex)
                        {
                            txtError.Text = "Radius and Height must be numeric." + ex.Message;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Cylinder.Volume().ToString());
                    }
                    btnArea.Enabled = true;
                    btnCircumference.Enabled = true;
                    btnDefinition.Enabled = true;
                    btnDispose.Enabled = true;
                    btnVolume.Enabled = true;
                    //MessageBox.Show(Cylinder.Volume().ToString());
                    txtVolume.Text = Cylinder.Volume().ToString();

                }
                else
                {
                    txtError.Text = "Radius and Height must be greater then zero.";
                }
            

             }
                    
           }
        //***********************************************************************
        //Procuedure: Circumference Click
        //
        //***********************************************************************
        private void btnCircumference_Click(object sender, EventArgs e)
        {
            if(rdoCircle.Checked)
            {
               if(txtRadius.Text.Trim().Length > 0)
                {
                    decimal decRad;

                    if (Circles == null)
                    {
                        try
                        {
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Circles = new clsCircle(decRad);
                           
                        }
                        catch (Exception ex)
                        {
                            txtError.Text = "Radius must be numeric." + ex.Message;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Circles.Circumference().ToString());
                    }
                    btnArea.Enabled = true;
                    btnCircumference.Enabled = true;
                    btnDefinition.Enabled = true;
                    btnDispose.Enabled = true;
                    MessageBox.Show(Circles.Circumference().ToString());

                }
                else
                {
                    txtError.Text = "Radius must have a value.";
                }
            }
            else
            {
                if (txtRadius.Text.Trim().Length > 0 && txtHeight.Text.Trim().Length > 0)
                {
                    decimal decRad;
                    decimal decHgt;
                    if (Cylinder == null)
                    {
                        try
                        {
                            decHgt = Convert.ToDecimal(txtHeight.Text);
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Cylinder = new clsCylinder(decRad, decHgt);
                        }
                        catch (Exception ex)
                        {
                            txtError.Text = "Radius and Height must be numeric." + ex.Message;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Cylinder.Circumference().ToString());
                    }
                    btnArea.Enabled = true;
                    btnCircumference.Enabled = true;
                    btnDefinition.Enabled = true;
                    btnDispose.Enabled = true;
                    btnVolume.Enabled = true;
                    MessageBox.Show(Cylinder.Circumference().ToString());
                    txtCircumference.Text = Cylinder.Circumference().ToString();
                    txtArea.Text = Cylinder.Area().ToString();
                    txtVolume.Text = Cylinder.Volume().ToString();

                }
                else
                {
                    txtError.Text = "Radius and Height must be greater then zero.";
                }
            }
        }

        //***************************************************************************
        //
        //
        //***************************************************************************
        private void btnArea_Click(object sender, EventArgs e)
        {
            if (rdoCircle.Checked)
            {
                if (txtRadius.Text.Trim().Length > 0)
                {
                    decimal decRad;

                    if (Circles == null)
                    {
                        try
                        {
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Circles = new clsCircle(decRad);

                        }
                        catch (Exception ex)
                        {
                            txtError.Text = "Radius must be numeric." + ex.Message;
                        }
                    }

                    btnArea.Enabled = true;
                    btnCircumference.Enabled = true;
                    btnDefinition.Enabled = true;
                    btnDispose.Enabled = true;
                    

                }
                else
                {
                    txtError.Text = "Radius must have a value.";
                }
            }
            else
            {
                if (txtRadius.Text.Trim().Length > 0 && txtHeight.Text.Trim().Length > 0)
                {
                    decimal decRad;
                    decimal decHgt;
                    if (Cylinder == null)
                    {
                        try
                        {
                            decHgt = Convert.ToDecimal(txtHeight.Text);
                            decRad = Convert.ToDecimal(txtRadius.Text);
                            Cylinder = new clsCylinder(decRad, decHgt);
                        }
                        catch (Exception ex)
                        {
                            txtError.Text = "Radius and Height must be numeric." + ex.Message;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Cylinder.Area().ToString());
                    }
                    btnArea.Enabled = true;
                    btnCircumference.Enabled = true;
                    btnDefinition.Enabled = true;
                    btnDispose.Enabled = true;
                    btnVolume.Enabled = true;
                    
                    txtCircumference.Text = Cylinder.Circumference().ToString();
                    txtArea.Text = Cylinder.Area().ToString();
                    txtVolume.Text = Cylinder.Volume().ToString();

                }
                else
                {
                    txtError.Text = "Radius and Height must be greater then zero.";
                }
            }
            MessageBox.Show(Circles.Area().ToString());
        }
    }
}
