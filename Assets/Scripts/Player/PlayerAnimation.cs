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

    #endregion


    #region Unity Methods

    private void Start()
    {
        _anim = GetComponentInChildren<Animator>();
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



    #endregion
}
