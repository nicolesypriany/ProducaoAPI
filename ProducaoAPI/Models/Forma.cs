namespace ProducaoAPI.Models
{
    public class Forma
    {
        public Forma(string nome, int produtoId, int pecasPorCiclo)
        {
            Nome = nome;
            ProdutoId = produtoId;
            PecasPorCiclo = pecasPorCiclo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int PecasPorCiclo { get; set; }
        public ICollection<Maquina> Maquinas { get; set; }
        public ICollection<ProcessoProducao> Producoes { get; set; }
    }
}
