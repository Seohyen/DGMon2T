using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //�̳��ϱ� �ǵ鸸�� ���� ��������� ���⿡ �ΰ� �۾��ҰԿ�..  - ����
    public int AHp = 100;
    public int BHp = 100;
    public int jump = 300;
    public int spd = 3;

    void Start()
    {
        Instance = this;
    }

    void Update()
    {
        
    }

    
}
