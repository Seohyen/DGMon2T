using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerIncrease : MonoBehaviour
{
    [SerializeField] float TimeInc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA") || collision.gameObject.CompareTag("PlayerB"))
        {
            Timmmme.seconds += TimeInc;
            Destroy(gameObject);
        }
    }
}
