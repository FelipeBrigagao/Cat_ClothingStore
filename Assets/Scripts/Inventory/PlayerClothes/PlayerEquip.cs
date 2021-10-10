using System;
using UnityEngine;

public class PlayerEquip : SingletonBase<PlayerEquip>
{
    #region Variables

    public Clothes _headItem { get; private set;}

    public Clothes _chestItem { get; private set; }

    private PlayerUI _playerUI;

    #endregion

    #region Events

    public event Action OnEquipmentChange;

    public void EquipmentChanged()
    {
        OnEquipmentChange?.Invoke();
    }

    #endregion


    #region Unity Methods
    #endregion

    #region Methods

    public void AddEquipment(Item equipment)
    {
        switch (equipment.itemType)
        {
            case ItemTypes.WEAPON:
                Debug.Log("Congratulations, its a weapon");
                break;
            case ItemTypes.CLOTHING:
                Clothes c = (Clothes)equipment;
                switch (c.clothingType)
                {
                    case ClothingTypes.HEAD:
                        AddHeadItem(c);
                        break;
                    case ClothingTypes.CHEST:
                        AddChestItem(c);
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }

    private void AddHeadItem(Clothes clothing)
    {
        if (_headItem != null)
        {
            RemoveHeadItem();
        }

        _headItem = clothing;
        _playerUI.ChangeHeadSprites(clothing);
        EquipmentChanged();

    }

    private void AddChestItem(Clothes clothing)
    {
        if (_chestItem != null)
        {
            RemoveChestItem();
        }

        _chestItem = clothing;
        _playerUI.ChangeChestSprites(clothing);
        EquipmentChanged();
    }

    public void RemoveEquipment(Item equipment)
    {
        switch (equipment.itemType)
        {
            case ItemTypes.WEAPON:
                Debug.Log("You got no weapon now!");
                break;
            case ItemTypes.CLOTHING:
                Clothes c = (Clothes)equipment;
                switch (c.clothingType)
                {
                    case ClothingTypes.HEAD:
                        RemoveHeadItem();
                        break;
                    case ClothingTypes.CHEST:
                        RemoveChestItem();
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }

    private void RemoveHeadItem()
    {

        PlayerInventory.Instance.AddItem(_headItem);
        _headItem = null;
        _playerUI.RemoveHeadSprites();
        EquipmentChanged();
    }

    private void RemoveChestItem()
    {

        PlayerInventory.Instance.AddItem(_chestItem);
        _chestItem = null;
        _playerUI.RemoveChestSprites();
        EquipmentChanged();
    }



    public void SetPlayerUI(PlayerUI playerUI)
    {
        _playerUI = playerUI;
    }

    #endregion


}
