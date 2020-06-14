using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirApiPloomes
{
    
}

public class ContactReturn
{
    public string odatacontext { get; set; }
    public Value[] value { get; set; }
}

public class Value
{
    public int Id { get; set; }
    public int TypeId { get; set; }
    public string Name { get; set; }
    public object LegalName { get; set; }
    public object Register { get; set; }
    public object CNPJ { get; set; }
    public object CPF { get; set; }
    public int StatusId { get; set; }
}
