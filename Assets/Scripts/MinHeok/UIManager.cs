using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject optionMenu;
    
    private void Awake()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
    }
    public void OnOptionMenu()
    {
        optionMenu.SetActive(true);
        optionMenu.transform.DOLocalMoveX(200, 2.5f).SetEase(Ease.OutElastic); 
    }
    public void ExitOptionMenu()
    {
        optionMenu.SetActive(false);
    }
}
