using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformM : MonoBehaviour
{
    public static PlatformM Instance;


    public GameObject platform;
    public GameObject platformPosition;
    public bool isPlatform = false;

    public float platformSpd = 3;

    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Platform();

    }

    public void Platform()
    {

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.right * platformSpd * Time.deltaTime);
        }
           
        if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);
            }
}
   
    
    public void BoolPlatform()
    {
        isPlatform = true;
    }
}

