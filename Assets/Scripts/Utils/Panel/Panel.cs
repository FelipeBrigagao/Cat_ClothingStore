using DG.Tweening;
using UnityEngine;

public class Panel : MonoBehaviour
{
    #region Variables
    [Header("Panel animation values")]

    [SerializeField]
    float _panelScaleTime = .2f;

    [SerializeField]
    Ease _panelEaseEffect = Ease.OutBack;

    #endregion


    #region Unity Methods
    private void OnEnable()
    {
        ShowPanel();
    }

    #endregion


    #region Methods

    public void ShowPanel()
    {
        this.transform.localScale = Vector3.zero;

        this.transform.DOScale(1, _panelScaleTime).SetDelay(_panelScaleTime).SetEase(_panelEaseEffect);

    }


    public void HidePanel()
    {
        this.transform.DOScale(0, _panelScaleTime).SetEase(_panelEaseEffect).OnComplete(DisablePanel);

    }

    private void DisablePanel()
    {
        this.gameObject.SetActive(false);
    }

    public float GetPanelScaleTime()
    {
        return _panelScaleTime;
    }


    #endregion

 }

