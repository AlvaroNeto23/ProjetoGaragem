using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using WebAppGaragem.Models;

namespace WebAppGaragem
{
    public class Serialization
    {
        /*
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\FormasPagamento.json");

        var js = new DataContractJsonSerializer(typeof(List<FormaPagamentoModel>));
        var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
        var formasPagamento = (List<FormaPagamentoModel>)js.ReadObject(ms);

        //---------------

        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Garagens.json");

        var js = new DataContractJsonSerializer(typeof(List<GaragemModel>));
        var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
        var garagens = (List<GaragemModel>)js.ReadObject(ms);

        //---------------

        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Passagens.json");

        var js = new DataContractJsonSerializer(typeof(List<PassagemModel>));
        var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
        var passagens = (List<PassgemModel>)js.ReadObject(ms);
        */
    }
}
