using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUP : MonoBehaviour
{
    [SerializeField] int Health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA"))
        {
            GameManager.Instance.AHp += Health;
        }
        else if (collision.gameObject.CompareTag("PlayerB"))
        {
            GameManager.Instance.BHp += Health;
        }
    }
}
