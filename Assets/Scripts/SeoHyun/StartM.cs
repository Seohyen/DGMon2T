using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartM : MonoBehaviour
{
    public Text startT;

    public GameObject panel;
    void Start()
    {
        StartTAnim();

        panel.SetActive(false);
    }

    void Update()
    {

        PressButton();
        PressEsc();
    }


    public void StartTAnim()
    {
        startT.DOText("Press Any Number Button", 2);
    }

    public void PressButton()
    {
        if (Input.anyKey)
        {

            panel.SetActive(true);

        }
    }

    public void PressEsc()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            panel.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }
}
