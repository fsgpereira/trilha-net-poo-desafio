namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, int memoria) : base(numero, imei, memoria)
        {
            Modelo = this.GetType().Name;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // public override void InstalarAplicativo(string nomeApp)
        // {
        //     throw new NotImplementedException();
        // }

        /*
            Eu encontrei uma maneira que considerei mais simples para fazer esse procedimento.
            Ao invés de abstrair o método, eu escrevi ele na classe herdada apenas 1 vez
            E repliquei para as classes filhas de uma maneira dinâmica
        */
    }
}