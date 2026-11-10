namespace Heranca
{
    public interface IPagamento // Uma interface define "um contrato" que estabelece quais metodos, proriedades ou outros membros uma classe deve disponibilizar
    {
        void Pagar(decimal valor);
        // void Receber(decimal valor); // Interfaces podem contem diversos métodos
    }
}