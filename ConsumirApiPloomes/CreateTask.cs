using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ConsumirApiPloomes
{
    public partial class CreateTask : Form
    {
        public CreateTask()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (idNegocioBox.TextLength == 0)
                {
                    DisplayMessageBoxText("informe o cliente para atribuir a tarefa");
                }
                else
                {
                    Task novaTarefa = new Task();
                    // preenchendo o obejto criado com os dados do form
                    novaTarefa.Description = descricaoTarefaBox.Text;
                    novaTarefa.Title = tituloTarefaBox.Text;
                    novaTarefa.DateTime = dateTimeBox.Value;
                    novaTarefa.ContactId = idNegocioBox.Text;

                    var json = new JavaScriptSerializer().Serialize(novaTarefa);

                    var client = new RestClient("https://api2.ploomes.com/Tasks");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("User-Key", "D968CE9E530A2157F3512E870F03B434E5451390F2E4B0125BE54C4428680DC9CA3138DEB9BF987E0226B38B5151395452C48BF04F611BB64F6E270596D95480");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", json, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        DisplayMessageBoxText("Tarefa Criada");
                        this.Close();
                    }
                    else {
                        DisplayMessageBoxText("Erro na criação da tarefa, verifique os dados informados e tente novamente.");
                    }                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void DisplayMessageBoxText(string text)
        {
            MessageBox.Show(text);
        }

        private void dateTimeBox_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }       
    }
}
