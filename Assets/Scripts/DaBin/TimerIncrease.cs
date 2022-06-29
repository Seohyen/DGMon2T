using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerIncrease : MonoBehaviour
{
    [SerializeField] float TimeInc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Timer.timer += TimeInc;
        }
    }
}
