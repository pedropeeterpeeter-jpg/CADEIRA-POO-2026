public abstract class Produto
{
	private int id;

	private int attribute1;

	private String nome;

	private String descricao;

	private double preco;

	private int stock;

	public double getPreco()
	{
		return 0;
	}

	public boolean temStock()
	{
		return false;
	}

	public void reduzirStock(qtd: int)()
	{

	}

	public double {abstract} calcularFrete()
	{
		return 0;
	}

}

