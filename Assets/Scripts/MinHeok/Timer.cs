using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] bool Playing;
    public static float timer;
    [SerializeField] int seconds;
    void Start()
    {
        
    }
    void Update()
    {
        if(Playing == true)
        {
            timer -= Time.deltaTime;
            seconds = Mathf.FloorToInt(timer +60);
            timerText.text = seconds.ToString();
        }
        else if(timer == 0)
        {
            Playing = false;
        }
    }
}
