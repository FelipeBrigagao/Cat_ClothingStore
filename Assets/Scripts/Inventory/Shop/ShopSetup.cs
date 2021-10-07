using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ShopSetup
{
    public string shopName;
    public int shopMaxItens;
    public List<Item> initialShopItens;

    public ShopSetup()
    {
        shopName = "Shop";
        shopMaxItens = 10;
        initialShopItens = new List<Item>();
    }

    public ShopSetup(string shopName, int shopMaxItens, List<Item> shopItens)
    {
        this.shopName = shopName;
        this.shopMaxItens = shopMaxItens;
        this.initialShopItens = shopItens;
    }

}
