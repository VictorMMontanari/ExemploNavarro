namespace WinFormsApp1
{
    public class ContaCorrente : Conta
    {

        public ContaCorrente(Cliente cliente) : base(cliente)
        {
            
        }


        public override void Transferir(Conta contaDestino, Conta contaOrigem)
        {
            //implementar a regra para transf.

        }
    }
}