using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OpenPanel();
    }

    public void OpenPanel()
    {
        if(Input.GetKey(KeyCode.Escape))
        {

            panel.SetActive(true);
            Time.timeScale = 0;
          
        }
    }

    public void OnClickX()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }public void OnClickResume()
    {
        panel.SetActive(false);
        Time.timeScale = 1;

    }
    public void OnClickStage()
    {
        SceneManager.LoadScene(1);


    }
    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickMain()
    {
        SceneManager.LoadScene(0);
    }
}
