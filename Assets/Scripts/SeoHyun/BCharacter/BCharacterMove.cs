using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BCharacterMove : MonoBehaviour
{
    private bool isMove;
    private bool isJumping;
    private Rigidbody2D rigid;
    public Animator anim;
    SpriteRenderer rend;
    

    

    

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

                GetComponent<Rigidbody2D>().AddForce(Vector3.up * GameManager.Instance.jump);

            }



        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("isMove", true);
            transform.Translate(-Vector2.right * GameManager.Instance.spd * Time.deltaTime) ;
          transform.localScale = new Vector3(-0.3f, 0.3f, 1);

        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isMove", true);
            transform.Translate(Vector2.right * GameManager.Instance.spd * Time.deltaTime);
            transform.localScale = new Vector3(0.3f, 0.3f, 1);
        }

    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            anim.SetBool("isJump", false);

        }

        if (collision.gameObject.tag == "Enemy")
        {
            GameManager.Instance.MinusBHP();
        }
        else if (collision.gameObject.tag == "Trap")
        {
            GameManager.Instance.MinusBHP();
        }


    }
}
