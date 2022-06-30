using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] float buffTime = 3f;
    [SerializeField] GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PlayerA") || collision.gameObject.CompareTag("PlayerB"))
        {
            //gameManager.SpeedUp(speed, buffTime);
        }
    }
}
