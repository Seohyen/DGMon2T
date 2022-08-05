using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDownB : MonoBehaviour
{
    [SerializeField] int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            GameManager.Instance.BHp -= health;
        }
    }
}
