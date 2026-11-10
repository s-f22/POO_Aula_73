namespace Heranca
{
  public class PagamentoPix : IPagamento
  {
    public void Pagar(decimal valor)
    {
      //  throw new NotImplementedException(); // * Classe nativa do C# enquanto a definição do metodo não é criada pelo desenvolvedor
      Console.WriteLine($"Pagamento via Pix: {valor:C}");
    }

  }
}