using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCharacterMove : MonoBehaviour
{
    private bool isJumping;
    private Rigidbody2D rigid;
    public Animator anim;
    SpriteRenderer rend;

    [Header("move")]
    [SerializeField]
    private float spd = 3;


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        Move();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            anim.SetBool("  ", false);
        }
    }

    /// <summary>
    /// 이동 및 점프 구현 함수 
    /// </summary>
    private void Move()
    {

        anim.SetBool("isMove", false);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isJumping == false)
            {

                anim.SetBool("isJump", true);
                isJumping = true;

                GetComponent<Rigidbody2D>().AddForce(Vector3.up * 300f);

            }



        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isMove", true);
            transform.Translate(-Vector2.right * spd * Time.deltaTime);
            rend.flipX = true;

        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isMove", true);
            transform.Translate(Vector2.right * spd * Time.deltaTime);
            rend.flipX = false;
        }

    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            anim.SetBool("isJump", false);
        }
    }

}
