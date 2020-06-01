using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using RestSharp;

namespace ConsumirApiPloomes
{
    public partial class Init : Form
    {

        Thread t1, t2, t3, t4, t5, t6;       

        public Init()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }         
               
        private void create_contact_Click(object sender, EventArgs e)
        {            
            t1 = new Thread(NovoCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void create_deal_Click(object sender, EventArgs e)
        {
            t2 = new Thread(createNewDealWindow);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void create_task_Click(object sender, EventArgs e)
        {
            t3 = new Thread(createNewTaskWindow);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void update_deal_Click(object sender, EventArgs e)
        {
            t4 = new Thread(createNewupdateDealWindow);
            t4.SetApartmentState(ApartmentState.STA);
            t4.Start();
        }

        private void create_interaction_Click(object sender, EventArgs e)
        {
            t5 = new Thread(createNewinteractRecordlWindow);
            t5.SetApartmentState(ApartmentState.STA);
            t5.Start();
        }

        private void finish_task_Click(object sender, EventArgs e)
        {
            t6 = new Thread(createNewFinishTaskWindow);
            t6.SetApartmentState(ApartmentState.STA);
            t6.Start();
        }

        private void NovoCliente(object obj)
        {
            Application.Run(new CreateContact());
        }

        private void createNewupdateDealWindow(object obj)
        {
            Application.Run(new UpdateDeal());
        }

        private void createNewinteractRecordlWindow(object obj)
        {
            Application.Run(new InteractionRecord());
        }        

        private void createNewDealWindow(object obj)
        {
            Application.Run(new CreateDeal ());
        }

        private void createNewTaskWindow(object obj)
        {
            Application.Run(new CreateTask());
        }

        private void createNewFinishTaskWindow(object obj)
        {
            Application.Run(new FinishTaks());
        }       

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }           
    }
}
