using RestSharp;
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
    public partial class UpdateDeal : Form
    {
        public UpdateDeal()
        {
            InitializeComponent();
        }

        private void UpdateDeal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idNegociacaobox.TextLength == 0)
                {
                    DisplayMessageBoxText("Informe o Id da negociação que deseja atualizar ou fechar.");
                }
                else
                {
                    var obj = new { Title = "Negócio Atualizado"};
                    var json = new JavaScriptSerializer().Serialize(obj);

                    var client = new RestClient("https://api2.ploomes.com/Deals(" + idNegociacaobox.Text + ")");
                    client.Timeout = -1;

                    var request = new RestRequest(Method.PATCH);
                    request.AddHeader("User-Key", "D968CE9E530A2157F3512E870F03B434E5451390F2E4B0125BE54C4428680DC9CA3138DEB9BF987E0226B38B5151395452C48BF04F611BB64F6E270596D95480");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", "{\r\n    \"Title\": \"Negócio Atualizado\",\r\n    \"ContactId\": 8410347,\r\n    \"Amount\": 15000,\r\n    \"StageId\": 1,\r\n    \"OtherProperties\": [\r\n        {\r\n            \"FieldKey\": \"{fieldKey}\",\r\n            \"StringValue\": \"texto exemplo\"\r\n        },\r\n        {\r\n            \"FieldKey\": \"{fieldKey}\",\r\n            \"IntegerValue\": 2\r\n        }\r\n    ]\r\n}", ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);

                    if (response.IsSuccessful == true)
                    {
                        DisplayMessageBoxText("Valor da negociação atualizado para R$ 15.000,00");
                        
                    }
                    else {
                        DisplayMessageBoxText("Não foi possível atualizar a negociação. Verifique os dados e tente novamente.");
                    }
                }    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void DisplayMessageBoxText(string text)
        {
            MessageBox.Show(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (idNegociacaobox.TextLength == 0)
                {
                    DisplayMessageBoxText("Informe o Id da negociação que deseja atualizar ou fechar.");
                }
                else
                {
                   
                    var client = new RestClient("https://api2.ploomes.com/Deals(" + idNegociacaobox.Text + ")/Win");                    
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("User-Key", "D968CE9E530A2157F3512E870F03B434E5451390F2E4B0125BE54C4428680DC9CA3138DEB9BF987E0226B38B5151395452C48BF04F611BB64F6E270596D95480");
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("application/json", "{\n\t\"Finished\": true\n}", ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                   

                    if (response.IsSuccessful == true)
                    {
                        DisplayMessageBoxText("PARABÉNS! NEGÓCIO FECHADO !");
                        this.Close();
                    }
                    else
                    {
                        DisplayMessageBoxText("Erro ao fechar o negócio, verifique os dados e tente novamente");
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        
    }
    }

