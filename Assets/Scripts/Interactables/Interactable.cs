using UnityEngine;

[RequireComponent(typeof(AudioUser))]
public abstract class Interactable : MonoBehaviour
{
    #region Variables
    [SerializeField] protected AudioUser _audio;
    #endregion

    #region Unity Methods
    private void Awake()
    {
        _audio = GetComponent<AudioUser>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            UIManager.Instance.EnableInteractIcon();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            UIManager.Instance.DisableInteractIcon();
        }
    }
    #endregion

    #region Methods
    public abstract void Interact();
    #endregion
}
