using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUp : MonoBehaviour
{
    [SerializeField] int jump;
    [SerializeField] float buffTime = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerA") || collision.gameObject.CompareTag("PlayerB"))
        {
            if (GameManager.Instance.spd <= jump)
            {
                GameManager.Instance.jump += jump;
                Invoke("invisible", 0f);
                Invoke("destroyItem", buffTime);
            }
        }
    }

    void destroyItem()
    {
        GameManager.Instance.jump -= jump;
        Destroy(gameObject);
    }

    void invisible()
    {
        Color32 itemColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color32(itemColor.r, itemColor.g, itemColor.b, 0);
    }
}
