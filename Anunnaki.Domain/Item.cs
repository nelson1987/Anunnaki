///Produto de uma compra
public class Item : Produto
{
    public int Id { get; set; }
    public int IdCompra { get; set; }
    public int Quantidade { get; set; }
}