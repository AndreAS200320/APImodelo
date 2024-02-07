namespace APImodelo.Model
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string NumeroDeCelular { get; set; }

        public DateOnly DataNascimento { get; set; }

        //metodo contendo os dados

        public List<Pessoa> Dados()
        {
            var ListaPessoas = new List<Pessoa>();

            var VPessoa = new Pessoa();

            VPessoa.Id = 1;
            VPessoa.Nome = "Muriel";
            VPessoa.NumeroDeCelular = "(18)999999999";

            var VPessoa2 = new Pessoa();

            VPessoa2.Id = 2;
            VPessoa2.Nome = "Muller";
            VPessoa2.NumeroDeCelular = "(18)999999999";

            var VPessoa3 = new Pessoa();

            VPessoa3.Id = 3;
            VPessoa3.Nome = "Atasaki";
            VPessoa3.NumeroDeCelular = "(18)999999999";

            ListaPessoas.Add(VPessoa); ListaPessoas.Add(VPessoa2); ListaPessoas.Add(VPessoa3);

            return ListaPessoas;
        }
    }
}
