using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] GameObject output;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = new Vector3(output.transform.position.x + 1, collision.transform.localPosition.y);
    }
}
