using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    #region Variables

    [Header("Player animation parameters")]
    [SerializeField]
    private string _moveHorizontalParameterName;
    
    [SerializeField]
    private string _moveVerticalParameterName;

    [SerializeField]
    private string _speedParameterName;

    private float _inputMagnitude;

    [Header("Animation references")]
    private Animator _anim;

    private int _lookDownInput = -1;
    #endregion


    #region Unity Methods

    private void Start()
    {
        _anim = GetComponentInChildren<Animator>();
    }


    private void OnEnable()
    {
        UIManager.Instance.OnInventoryOpen += PlayInventoryAnim;
    }

    private void OnDisable()
    {
        UIManager.Instance.OnInventoryOpen -= PlayInventoryAnim;        
    }
    #endregion


    #region Methods

    public void MovementAnimation(Vector2 input)
    {
        _inputMagnitude = input.magnitude;

        if(_inputMagnitude > 0)
        {
            _anim.SetFloat(_moveHorizontalParameterName, input.x);
            _anim.SetFloat(_moveVerticalParameterName, input.y);

        }

        _anim.SetFloat(_speedParameterName, _inputMagnitude);
    }

    private void PlayInventoryAnim()
    {
        _anim.SetFloat(_moveVerticalParameterName, _lookDownInput);
    }

    #endregion
}
