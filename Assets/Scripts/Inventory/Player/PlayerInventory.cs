using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : InventoryBase
{
    #region Singleton
    private static PlayerInventory _instance;


    public static PlayerInventory Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("Manager not found");

                return FindObjectOfType<PlayerInventory>();
            }

            return _instance;
        }
    }


    protected virtual void Awake()
    {
        if (_instance == null)
        {
            Debug.Log($"Instantiated Manager:{GetComponent<PlayerInventory>().name}");
            _instance = GetComponent<PlayerInventory>();

        }
        else
        {
            Debug.LogWarning($"Manager already exist: {GetComponent<PlayerInventory>().name} ");
            Destroy(gameObject);
        }
    }

    #endregion

    #region Variables
    #endregion

    #region Unity Methods
    #endregion

    #region Methods
    #endregion


}
