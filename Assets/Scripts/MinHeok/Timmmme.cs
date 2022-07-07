using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timmmme : MonoBehaviour
{
    public float seconds = 10f;

    private float speed;
    public TMP_Text timerText;

    /// <summary>
    ///  isTimer = true   ----> Timer-ing
    ///  isTImer = false -----> Timer is Stop
    /// </summary>
    private bool isTimer = true;

    private WaitForSeconds time = new WaitForSeconds(1f);
    public void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        float currentSpeed = seconds;

        while (true)
        {
            if (isTimer == false)
                yield break;
            if (seconds > 0)
            {
                seconds -= 1f;
                timerText.text = $"{(int)seconds}";
                yield return time;
            }
            else
            {
                seconds = 0; currentSpeed = 0;
                isTimer = false;
            }
        }
    }
}
