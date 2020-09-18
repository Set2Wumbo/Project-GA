using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGA
{
    public partial class PopulationForm : Form
    {
        public PopulationForm()
        {
            InitializeComponent();
        }

        //Code for moving header around
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);            
        }

        int xPos = 0;
        GAClass con = new GAClass();
        private void PopulationForm_Load(object sender, EventArgs e)
        {
            try
            {
                
                int[] fF = con.get_fitness_function_scores();
                btnConfirmChanges.Enabled = false;

                for (int i = 0; i < con.get_Pop_Size(); i++)
                {
                    //Create label
                    Label label = new Label();
                    label.Text = String.Format("Chromo {0}:", i + 1);
                    label.Name = String.Format("lblchromo" + "{0}", i + 1);

                    //Position label on screen
                    int yPos = (i + 1) * 40 + 30;
                    label.Location = new Point(20, yPos);
                    label.AutoSize = true;

                    //Add controls to form
                    this.Controls.Add(label);

                    for(int j = 0; j < con.get_num_Periods(); j++)
                    {
                        //Create textbox
                        TextBox textBox = new TextBox();
                        textBox.Name = String.Format("txtChromo{0}{1}", i + 1, j);
                        textBox.Text = con.get_chromosome(i,j).ToString();

                        //Position textbox on screen
                        //Disable textbox
                        xPos = (j + 1) * 40 + 100;
                        textBox.Location = new Point(xPos, yPos);
                        textBox.Size = new Size(35, 10);
                        textBox.TextAlign = HorizontalAlignment.Center;
                        textBox.Enabled = false;

                        //Add the Textbox
                        this.Controls.Add(textBox);
                    }

                    label = new Label();
                    label.Text = String.Format("FF {0}: {1}", i + 1 , fF[i]);
                    label.Name = String.Format("lblfF{0}", i + 1);

                    yPos = (i + 1) * 40 + 30;
                    label.Location = new Point(xPos + 50, yPos);
                    label.AutoSize = true;

                    //Add controls to form
                    this.Controls.Add(label);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Exit Button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Edit Button
        private void btnEditChromo_Click(object sender, EventArgs e)
        {
            //Change settings
            btnEditChromo.Enabled = false;
            btnConfirmChanges.Enabled = true;

            //Enable the textboxes
            for(int i = 0; i < con.get_Pop_Size(); i++)
            {
                for(int j = 0; j < con.get_num_Periods(); j++)
                {
                    var textbox = this.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == $"txtChromo{i+1}{j}");
                    textbox.Enabled = true;
                }
            }

            this.Refresh();
        }

        //Confirmation button
        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            //Change settings for buttons
            btnEditChromo.Enabled = true;
            btnConfirmChanges.Enabled = false;

            //Disable textboxes
            for (int i = 0; i < con.get_Pop_Size(); i++)
            {
                for (int j = 0; j < con.get_num_Periods(); j++)
                {
                    var textbox = this.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == $"txtChromo{i + 1}{j}");
                    textbox.Enabled = false;
                }
            }

            //Generate new Fitness functions
            int[][] tempChromoCollect = new int[con.get_Pop_Size()][];
            for (int i = 0; i < con.get_Pop_Size(); i++)
            {
                tempChromoCollect[i] = new int[con.get_num_Periods()];
                for (int j = 0; j < con.get_num_Periods(); j++)
                {
                    var textbox = this.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == $"txtChromo{i + 1}{j}");
                    tempChromoCollect[i][j] = int.Parse(textbox.Text);
                }

                
            }

            //send the new chromos
            //generate the new FF
            con.update_Chromosome_Pop(tempChromoCollect);
            con.find_Fitness_Function();
            int[] tempFf = con.get_fitness_function_scores();

            //Generate new FF Labels
            for (int i = 0; i < con.get_Pop_Size(); i++)
            {
                var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == $"lblfF{i + 1}");
                label.Text = $"FF {i+1}: {tempFf[i]}";
            }

        this.Refresh();
        }

        //Button to go back to parameters
        private void btnBack_Click(object sender, EventArgs e)
        {
            ParameterForm form = new ParameterForm();
            this.Hide();
            form.Show();
        }

        //Button to go to the dashboard overview
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
