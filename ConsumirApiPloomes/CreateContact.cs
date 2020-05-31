using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ConsumirApiPloomes
{
    public partial class CreateContact : Form
    {
        public CreateContact()
        {
            InitializeComponent();
        }

        private void criarCliente_Click(object sender, EventArgs e)
        {
          try
          {                          
            string Nome = textBox1.Text;
            int TypeId = 1; // empresa

                if (Nome.Length == 0){
                    DisplayMessageBoxText("Preencha o nome.");

                }else if ((pessoaBox.Checked && empresaBox.Checked) 
                          ||
                         (!pessoaBox.Checked && !empresaBox.Checked)){                        
                    DisplayMessageBoxText("Escolha um tipo de cliente.");
                }else {

                    if (pessoaBox.Checked) { TypeId = 2; } // Pessoa

                    // criar o novo cliente
                    Contact novoCliente = new Contact(Nome, TypeId);

                    // passando para JSON
                    var json = new JavaScriptSerializer().Serialize(novoCliente);

                    // requisição
                    var client = new RestClient("https://api2.ploomes.com/Contacts");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);

                    request.AddHeader("User-Key", "D968CE9E530A2157F3512E870F03B434E5451390F2E4B0125BE54C4428680DC9CA3138DEB9BF987E0226B38B5151395452C48BF04F611BB64F6E270596D95480");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", json, ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    if (response.IsSuccessful == true)
                    {
                        DisplayMessageBoxText("Cliente criado com sucesso!");
                        this.Close();
                    }
                    else {
                        DisplayMessageBoxText("Erro na criação do cliente.");
                    }

                }    
          }
          catch (Exception error)
          {
              throw new Exception(error.Message);
          }

        }

        private void pessoaBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void empresaBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayMessageBoxText(string text)
        {
            MessageBox.Show(text);
        }
    }
}
