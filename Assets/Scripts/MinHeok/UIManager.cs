using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject optionMenu;
    Sequence sequence;
    float textDuration = 1.5f;
    float iconScalelDuration = 0.5f;
    Vector3 bigScale = new Vector3(1.0f, 1.0f, 1.0f);
    Vector3 smallScale = new Vector3(0f, 0f, 0f);

    private void Start()
    {
       
    }
    public void OnOptionMenu()
    {
        DOTween.Sequence()
        .Append(optionMenu.transform.DOScale(bigScale, iconScalelDuration).SetEase(Ease.OutExpo));
        optionMenu.SetActive(true);
        
    }
    public void ExitOptionMenu()
    {
        DOTween.Sequence()
            .Append(optionMenu.transform.DOScale(smallScale, iconScalelDuration).SetEase(Ease.OutElastic));
        optionMenu.SetActive(false);
    }
}
