using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{


 

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if(gameObject.CompareTag("Stage1"))
        {
            if (collision.gameObject.CompareTag("PlayerA"))
            {
                GameManager.Instance.isSwitch1 = true;
            }
            if (collision.gameObject.CompareTag("PlayerB"))
            {
                GameManager.Instance.isSwitch2 = true;
            }
        }

   


    }


}
