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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
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

        //Create new GA Class connection
        GAClass con = new GAClass();
        int[] netRequirements;
        int[] fitnessFunction;
        int[][] chromosomes;
        int popSize;
        int periodSize;
        //start of NR Label position
        int yPos = 150;
        int xPos = 200;
        int xOffset = 100;
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                netRequirements = con.get_net_requirements();
                fitnessFunction = con.get_fitness_function_scores();
                popSize = con.get_Pop_Size();
                periodSize = con.get_num_Periods();

                //Create label
                Label label = new Label();
                Label label2 = new Label();
                Label label3 = new Label();
                Label label4 = new Label();
                Label label5 = new Label();
                label.Text = String.Format("Net Req:");
                label2.Text = String.Format("Period:");
                label3.Text = String.Format("Current Best Chromo: " + $"{con.get_Best_Chromo()}" );
                label4.Text = String.Format("Number of Generations: " + $"{con.get_generation_count()}");
                label5.Text = String.Format("Current Worst Chromo: " + $"{con.get_Worst_Chromo()}");
                //Position label on screen
                label.Location = new Point(xPos, yPos);
                label2.Location = new Point(xPos, yPos - 30);
                label3.Location = new Point(xPos, yPos + 80);
                label4.Location = new Point(xPos, yPos + 50);
                label5.Location = new Point(xPos, yPos + 150);
                label.AutoSize = true;
                label2.AutoSize = true;
                label3.AutoSize = true;
                label4.AutoSize = true;
                label5.AutoSize = true;
                //Add controls to form
                this.Controls.Add(label);
                this.Controls.Add(label2);
                this.Controls.Add(label3);
                this.Controls.Add(label4);
                this.Controls.Add(label5);

                //Add the period and Net requirement labels
                for (int i = 0; i < popSize; i++)
                {
                    for(int j=0;j<periodSize;j++)
                    {
                        //new labels
                        Label lbl = new Label();
                        Label lbl2 = new Label();

                        //assgin text
                        lbl.Text = String.Format($"{netRequirements[j]}");
                        lbl2.Text = String.Format($"{j+1}");

                        //adjust size
                        lbl.Location = new Point((j * 40 + (xPos + xOffset)), yPos);
                        lbl2.Location = new Point((j * 40 + (xPos + xOffset)), yPos - 30);
                        lbl.AutoSize = true;
                        lbl2.AutoSize = true;

                        //add controls
                        this.Controls.Add(lbl);
                        this.Controls.Add(lbl2);
                    }
                }
               

                int[] bestchromo = con.get_the_best_chromo_with_periods();
                int[] worstChromo = con.get_the_worst_chromo_with_periods();
                for (int j = 0; j < periodSize; j++)
                {
                    //new labels
                    Label lbls = new Label();
                    Label lblss = new Label();
                    //assgin text
                    lbls.Text = String.Format($"{bestchromo[j]}");
                    lblss.Text = String.Format($"{worstChromo[j]}");

                    //adjust size
                    lbls.Location = new Point(j * 40 + (xPos + xOffset), yPos + 110);
                    lblss.Location = new Point(j * 40 + (xPos + xOffset), yPos + 180);
                    lbls.AutoSize = true;
                    lblss.AutoSize = true;

                    //add controls
                    this.Controls.Add(lbls);
                    this.Controls.Add(lblss);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Button to exit app
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //button to go back to the population page
        private void btnBack_Click(object sender, EventArgs e)
        {
            PopulationForm form = new PopulationForm();
            this.Hide();
            form.Show();
        }

        //button for home display
        private void button3_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.DarkGreen;
            btnAnalysis.BackColor = Color.Green;
            btnAiInput.BackColor = Color.Green;
            btnNewRun.BackColor = Color.Green;

        }

        //button for anaylsis display
        private void btnAnaylsis_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Green;
            btnAnalysis.BackColor = Color.DarkGreen;
            btnAiInput.BackColor = Color.Green;
            btnNewRun.BackColor = Color.Green;
        }

        //button for AI suggested display
        //WORK IN PROGRESS....
        private void btnAiInput_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Green;
            btnAnalysis.BackColor = Color.Green;
            btnAiInput.BackColor = Color.DarkGreen;
            btnNewRun.BackColor = Color.Green;
        }

        //New run button
        private void button2_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.Green;
            btnAnalysis.BackColor = Color.Green;
            btnAiInput.BackColor = Color.Green;
            btnNewRun.BackColor = Color.DarkGreen;

            
        }
    }
}
