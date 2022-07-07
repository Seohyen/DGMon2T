using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        GameOver();
    }

    public void MinusAHP()
    {
     AHp -= 20;
    }
        public void MinusBHP()
    {
     BHp -= 20;
    }

    public void GameOver()
    {
        if (AHp <= 0|| BHp<=0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
