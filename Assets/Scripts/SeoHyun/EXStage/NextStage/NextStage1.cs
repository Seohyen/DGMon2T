using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            if (collision.gameObject.CompareTag("PlayerA"))
            {
                GameManager.Instance.isSwitch3 = true;
            }
            if (collision.gameObject.CompareTag("PlayerB"))
            {
                GameManager.Instance.isSwitch4 = true;
            }
        
        
    }
}
