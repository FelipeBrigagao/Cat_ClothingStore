using System;
using System.Collections.Generic;


[Serializable]
public class ShopSetup
{
    public string shopName;
    public int shopMaxItens;
    public List<Item> initialShopItens;

    public ShopSetup()
    {
        shopName = "Shop";
        shopMaxItens = 16;
        initialShopItens = new List<Item>();
    }

    public ShopSetup(string shopName, int shopMaxItens, List<Item> shopItens)
    {
        this.shopName = shopName;
        this.shopMaxItens = shopMaxItens;
        this.initialShopItens = shopItens;
    }

}
