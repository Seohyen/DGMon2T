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

    public float platformspd = 3f;

    public bool isPlatfrom = false;

    [Header("Platform")]
    [SerializeField]
    private GameObject platform;
    public GameObject platformPosition;
    
    
    
    


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        Move();
        Platform();
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

                rigid.AddForce(Vector3.up * GameManager.Instance.jump);

            }



        }


        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isMove", true);
            transform.Translate(-Vector2.right * GameManager.Instance.spd * Time.deltaTime);
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);


        }


        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isMove", true);
            transform.Translate(Vector2.right * GameManager.Instance.spd * Time.deltaTime);
            transform.rotation = Quaternion.identity;
            transform.localScale = new Vector3(0.3f, 0.3f, 1);


        }

    }


    public void Platform()
    {

        if (!isPlatform)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Instantiate<GameObject>(platform, platformPosition.transform.position, platformPosition.transform.rotation);
                isPlatform = true;
            }
        }

        if(isPlatform)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                isPlatform = false;
            }
        }
    }


    public bool isPlatform = false;





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
            anim.SetBool("isJump", false);
        }

        if (collision.gameObject.tag == "Enemy"|| collision.gameObject.tag == "Trap")
        {
            GameManager.Instance.AHp -= 20;
        }

        


    }
    


}
