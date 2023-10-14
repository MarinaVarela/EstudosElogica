using Cadastro;

namespace Repositorio;

class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void ImprimirCliente(Cliente cliente)
    {
        Console.WriteLine("ID..............: " + cliente.Id);
        Console.WriteLine("Nome............: " + cliente.Nome);
        Console.WriteLine("Desconto........: " + cliente.Desconto.ToString("0.00"));
        Console.WriteLine("Data Nascimento.: " + cliente.DataNascimento);
        Console.WriteLine("Data Cadastrado.: " + cliente.Cadastrado);
        Console.WriteLine("--------------------------------");
    }

    public void ExibirClientes()
    {
        Console.Clear();
        foreach (var cliente in clientes)
        {
            ImprimirCliente(cliente);    
        }
    }

    
}