namespace ByteBank7
{
    public class Cliente
    {
        private string _cpf;
        public string CPF 
        { 
            get
            {
                return _cpf;
            }
                set
            { 
                _cpf = value; 
            }
                }
        public string Nome { get; set; }
        public string Profissao { get; set; }
    }
}