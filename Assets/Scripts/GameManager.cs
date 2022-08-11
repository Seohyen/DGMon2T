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

        StageClear();
    }

    public void MinusAHP()
    {
     AHp -= 100;
    }
        public void MinusBHP()
    {
     BHp -= 100;
    }

    public void GameOver()
    {
        if (AHp <= 0|| BHp<=0)
        {
            SceneManager.LoadScene(2);
        }
    }


    public bool isSwitch1 = false;
    public bool isSwitch2 = false;
    public bool isSwitch3 = false;
    public bool isSwitch4 = false;
    

    private bool isClear = false;
    private bool isStageClear = false;


    void StageClear()
    {

        if (isClear) return;
        if (isStageClear) return;

        if (isSwitch1 && isSwitch2)
        {
            isStageClear = true;
            SceneManager.LoadScene(4);
        }


        if (isSwitch3 && isSwitch4)
        {
            isClear = true;
            SceneManager.LoadScene(5);
        }
    }
    
}
