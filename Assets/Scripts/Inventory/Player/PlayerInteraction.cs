using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    #region Variables
    private Vector2 _boxSize = new Vector2(0.66f, 0.43f);

    private Vector3 _interactionCheckOffset = Vector3.up * 0.2f;
    #endregion


    #region Unity Methods
    #endregion


    #region Methods

    public void EnableInteractIcon()
    {
        UIManager.Instance.EnableInteractIcon();
    }

    public void DisableInteractIcon()
    {
        UIManager.Instance.DisableInteractIcon();
    }

    public void CheckInteraction()
    {
        RaycastHit2D[] interactions = Physics2D.BoxCastAll(transform.position+_interactionCheckOffset, _boxSize, 0, Vector2.zero);

        if(interactions.Length > 0)
        {
            Interactable interactable;

            foreach(RaycastHit2D interaction in interactions)
            {
                interactable = interaction.transform.GetComponent<Interactable>();

                if (interactable)
                {
                    interactable.Interact();
                    return;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position + _interactionCheckOffset, _boxSize);
        
    }
    #endregion
}
