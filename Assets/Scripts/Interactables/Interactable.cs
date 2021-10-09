using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    #region Variables
    #endregion

    #region Unity Methods

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerInteraction>().EnableInteractIcon();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerInteraction>().DisableInteractIcon();
        }
    }
    #endregion

    #region Methods
    public abstract void Interact();
    #endregion
}
