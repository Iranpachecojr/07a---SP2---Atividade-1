namespace Proj_Atividade
{
    class PessoaJuridica : Clientes
    {
        public string cnpj{get; set;}
        public string inscEst{get; set;} //inscrição estadual
        
         public override void PagarImposto(float v)
        {
            this.valor = v;
            this.valorImposto = this.valor * 20/100;
            this.valorTotal = this.valor + this.valorImposto;
        }
    }
}