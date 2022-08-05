using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class SceneMove : MonoBehaviour
{
    [SerializeField]
    private GameObject StageSelect;

    public void Stage1()
    {
        SceneManager.LoadScene(3);
    }
    public void Stage2()
    {
        SceneManager.LoadScene(4);
    }
    public void Stage3()
    {
        SceneManager.LoadScene(5);
    }
    public void Stage4()
    {
        SceneManager.LoadScene(6);
    }
    public void manyStage()
    {
        SceneManager.LoadScene(7);
    }
}
