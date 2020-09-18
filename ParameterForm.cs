using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGA
{
    public partial class ParameterForm : Form
    {
        public ParameterForm()
        {
            InitializeComponent();
        }

        //Code for moving header around
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Header Panel
        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        //Close button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //FormLoad
        private void ParameterForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtPopulationsize.Text = "10";
                txtOrderProbability.Text = ".5";
                txtMutationProbability.Text = "0.05";
                txtCrossoverProbability.Text = "1";
                txtHoldingCost.Text = 1.ToString();
                txtCostPerOrder.Text = 100.ToString();
                txtNumofPeriods.Select();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Net Requirement defualts for the periods
        int prevNumPeriods = 0;
        int[] netReq = new int[] { 100, 60, 40, 50, 80, 70, 120, 110, 150, 90, 140, 50, 60, 80, 40, 20, 100, 70 };
        //Text box num of period text change event
        private void txtNumofPeriods_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int NumofPeriods = int.Parse(txtNumofPeriods.Text);

                if(txtNumofPeriods.Text == "" || txtNumofPeriods.Text == "1" || txtNumofPeriods.Text == null)
                {
                    //Make sure it's not blank or still typing
                    for (int i = 0; i < prevNumPeriods; i++)
                    {
                        var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lbl" + $"{i + 1}");
                        var textbox = this.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "txt" + $"{i + 1}");
                        this.Controls.Remove(label);
                        this.Controls.Remove(textbox);
                    }
                }
                else if(NumofPeriods >= 3 && NumofPeriods <= 18)
                {
                    
                    for (int i = 0; i < NumofPeriods; i++)
                    {
                        //Create label
                        Label label = new Label();
                        label.Text = String.Format("{0}",i + 1);
                        label.Name = String.Format("lbl"+"{0}", i + 1);
                        
                        //Position label on screen
                        label.Location = new Point((i + 1) * 40 + 160, 339);
                        label.Size = new Size(30,20);
                        
                        //Create textbox
                        TextBox textBox = new TextBox();
                        textBox.Name = String.Format("txt" + "{0}", i + 1);
                        textBox.Text = netReq[i].ToString();

                        //Position textbox on screen
                        textBox.Location = new Point((i + 1) * 40 + 150, 379);
                        textBox.Size = new Size(35, 10);
                        textBox.TextAlign = HorizontalAlignment.Center;
                        
                        //Add controls to form
                        this.Controls.Add(label);
                        this.Controls.Add(textBox);
                    }
                    prevNumPeriods = NumofPeriods;
                }
                else
                {
                    for (int i = 0; i < prevNumPeriods; i++)
                    {
                        var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lbl" + $"{i + 1}");
                        var textbox = this.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "txt" + $"{i + 1}");
                        this.Controls.Remove(label);
                        this.Controls.Remove(textbox);
                    }

                    MessageBox.Show("Must be >= 3 or <= 18");
                }
            }
            catch(Exception ex)
            {
                
            }
        }

        //Confirm Settings Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Establish connection to GAClass
                GAClass connection = new GAClass();

                //Store variables to GA Class
                connection.populationSize = int.Parse(txtPopulationsize.Text);
                connection.numOfPeriods = int.Parse(txtNumofPeriods.Text);
                connection.orderProbability = double.Parse(txtOrderProbability.Text);
                connection.mutationProbability = double.Parse(txtMutationProbability.Text);
                connection.crossoverProbability = double.Parse(txtCrossoverProbability.Text);
                connection.costPerUnitPerPeriod = decimal.Parse(txtHoldingCost.Text);
                connection.setUpCostPerOrder = decimal.Parse(txtCostPerOrder.Text);

                //Generate new population of chromosomes
                connection.Generate_Chromosomes();

                //Collect Net Requirements
                //Reason for seperation is the dynamically generated textboxes
                int[] tempNetReqCollect = new int[int.Parse(txtNumofPeriods.Text)];                
                for (int j = 0; j < int.Parse(txtNumofPeriods.Text); j++)
                {
                    var textbox = this.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "txt" + $"{j + 1}");
                    tempNetReqCollect[j] = int.Parse(textbox.Text);
                }              

                //transfer to the GA Class
                connection.update_net_requirements(tempNetReqCollect);

                //Generate Fitness scores
                connection.find_Fitness_Function();

                //Clean up
                this.Hide();
                PopulationForm form = new PopulationForm();
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
