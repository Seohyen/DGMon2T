using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float nextMove;
    Rigidbody2D rigid;
    private RaycastHit2D hitinfo;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        Invoke("Think", 5);
    }

    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y);
        Vector2 frontVec = new Vector2(rigid.position.x + nextMove, rigid.position.y);
        //Debug.DrawRay(frontVec, Vector3.down, new Color(0, 1, 0));
        //RaycastHit2D raycast = Physics2D.Raycast(frontVec, Vector3.down, 1f, LayerMask.GetMask("Ground"));
        //    if (raycast.transform.CompareTag("Enemy"))
        //    {
        //        Debug.Log("qweqwe");
        //    }

        Debug.DrawRay(transform.position, Vector2.left * 1f, Color.magenta);
        Debug.DrawRay(transform.position, Vector2.right * 1f, Color.magenta);


        var ray1 = Physics2D.Raycast(transform.position, Vector2.left * 1f, LayerMask.GetMask("Wall"));
        var ray2 = Physics2D.Raycast(transform.position, Vector2.right * 1f, LayerMask.GetMask("Wall"));

        if (ray1.collider != null && ray2.collider != null)
            Debug.Log("qwe");
    }
    void Think()
    {
        nextMove = Random.Range(-1f, 2f);
        Invoke(nameof(Think), 5);
    }
}
