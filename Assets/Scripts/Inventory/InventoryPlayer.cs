using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : InventoryBase
{
    #region Singleton
    private static InventoryPlayer _instance;


    public static InventoryPlayer Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("Manager not found");

                return FindObjectOfType<InventoryPlayer>();
            }

            return _instance;
        }
    }


    protected virtual void Awake()
    {
        if (_instance == null)
        {
            Debug.Log($"Instantiated Manager:{GetComponent<InventoryPlayer>().name}");
            _instance = GetComponent<InventoryPlayer>();

        }
        else
        {
            Debug.LogWarning($"Manager already exist: {GetComponent<InventoryPlayer>().name} ");
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
