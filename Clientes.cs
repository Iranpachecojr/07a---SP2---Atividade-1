namespace Proj_Atividade
{
    class Clientes
    {
        public string nome {get; set;}
        public string end {get; set;} //endereço
        public float valor {get; protected set;}
        public float valorImposto {get; protected set;}
        public float valorTotal {get; protected set;}

        public virtual void PagarImposto(float v)
        {
            this.valor = v;
            this.valorImposto = this.valor * 10 / 100;
            this.valorTotal = this.valor + this.valorImposto;
        }
    }
}
