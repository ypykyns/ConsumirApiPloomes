﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ConsumirApiPloomes
{
    public partial class FinishTaks : Form
    {
        public FinishTaks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = new {
                               Finished = true,
                               Comments = richTextBox1.Text
                              };
              
                var json = new JavaScriptSerializer().Serialize(obj);

                var client = new RestClient("https://api2.ploomes.com/Tasks(" + idTaskBox.Text + ")/Finish");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("User-Key", "D968CE9E530A2157F3512E870F03B434E5451390F2E4B0125BE54C4428680DC9CA3138DEB9BF987E0226B38B5151395452C48BF04F611BB64F6E270596D95480");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    DisplayMessageBoxText("Tarefa finalizada.");
                }
                else
                {
                    DisplayMessageBoxText("Erro ao tentar finalizar a tarefa.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void DisplayMessageBoxText(string text)
        {
            MessageBox.Show(text);
        }
    }
}
