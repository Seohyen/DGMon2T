using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    public int AHp = 100;
    public int BHp = 100;


    void Start()
    {
        Instance = this;
    }

    void Update()
    {
        
    }

    
}
