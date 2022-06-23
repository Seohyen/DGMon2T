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
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void Stage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void Stage4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void manyStage()
    {
        SceneManager.LoadScene("MinHeok");
    }
}
