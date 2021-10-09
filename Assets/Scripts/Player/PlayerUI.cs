using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private SpriteRenderer _headFrontSide;
    [SerializeField]
    private SpriteRenderer _headBackSide;
    [SerializeField]
    private SpriteRenderer _headLeftSide;

    [SerializeField]
    private SpriteRenderer _chestFrontSide;
    [SerializeField]
    private SpriteRenderer _chestBackSide;
    [SerializeField]
    private SpriteRenderer _chestLeftSide;

    #endregion

    #region Unity Methods
    private void Start()
    {
        PlayerEquip.Instance.SetPlayerUI(this);
    }
    #endregion

    #region Methods

    public void ChangeHeadSprites(Clothes clothing)
    {
        if(clothing != null)
        {
            _headFrontSide.sprite = clothing.frontSide;
            _headBackSide.sprite = clothing.backSide;
            _headLeftSide.sprite = clothing.leftSide;
        }
        
    }

    public void RemoveHeadSprites()
    {
        _headFrontSide.sprite = null;
        _headBackSide.sprite = null;
        _headLeftSide.sprite = null;
    }

    public void ChangeChestSprites(Clothes clothing)
    {
        if (clothing != null)
        {
            _chestFrontSide.sprite = clothing.frontSide;
            _chestBackSide.sprite = clothing.backSide;
            _chestLeftSide.sprite = clothing.leftSide;
        }
    }

    public void RemoveChestSprites()
    {
        _chestFrontSide.sprite = null;
        _chestBackSide.sprite = null;
        _chestLeftSide.sprite = null;
    }

    #endregion
}
