using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //겁나니까 건들만한 변수 가져가라고 여기에 두고 작업할게용..  - 서현
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

    
    public void HPOver()
    {
        if (AHp <= 0)
        {
            GameOver();
        }

    }

    public IEnumerator SpeedUp(int speed, float time)
    {
        spd += speed;
        yield return new WaitForSeconds(time);
        spd -= speed;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
