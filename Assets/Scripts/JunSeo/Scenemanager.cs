using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class Scenemanager : MonoBehaviour
{
    [SerializeField] GameObject setTing;
    float textDuration = 1.5f;
    float iconScalelDuration = 0.5f;
    Vector3 bigScale = new Vector3(1f, 1f, 0);
    Vector3 smallScale = new Vector3(0.4f, 0.4f, 0);

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void BtnStart(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OnSetting()
    {
        DOTween.Sequence()
        .Append(setTing.transform.DOScale(smallScale, iconScalelDuration).SetEase(Ease.OutExpo));
        setTing.SetActive(true);
    }
}
