using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACharacterMove : MonoBehaviour
{

    private bool isMove;
    private bool isJumping;
    private Rigidbody2D rigid;
    public Animator anim;
    SpriteRenderer rend;

    [Header("move")]
    [SerializeField]
    private float spd = 3;

    [Header("Platform")]
    [SerializeField]
    private GameObject platform;

    
    
    


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        Move();
        InstantiatePlatform();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            anim.SetBool("  ", false);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            GameManager.Instance.MinusAHP();
        }
        else if(collision.gameObject.tag == "Trap")
        {
            GameManager.Instance.MinusAHP();
        }

       

    }

    /// <summary>
    /// 이동 및 점프 구현 함수 
    /// </summary>
    private void Move()
    {

        anim.SetBool("isMove", false);
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isJumping == false)
            {

                anim.SetBool("isJump", true);
                isJumping = true;

                rigid.AddForce(Vector3.up * 300);

            }



        }


        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isMove", true);
            transform.Translate(-Vector2.right * spd * Time.deltaTime);
            rend.flipX = true;

        }


        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isMove", true);
            transform.Translate(Vector2.right * spd * Time.deltaTime);
            rend.flipX = false;
        }

    }

    void InstantiatePlatform()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            
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
