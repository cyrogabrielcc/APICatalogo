namespace APICatalogo.Services
{
    public class MeuServico : IMeuServico
    {
        public MeuServico()
        {
        }

        string IMeuServico.saudacao(string nome)
        {
            return $"Olá, {nome}!";
        }
    }
}