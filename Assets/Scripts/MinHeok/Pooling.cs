using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    public static Pooling Instance = null;

    public Stack<GameObject> enemyPooler = new Stack<GameObject> ();
    public GameObject Enemy;
    public Transform minPos;
    public Transform maxPos;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }
  /// <summary>
  /// 풀링
  /// </summery>
  /// <param name="obj">소환할 오브젝트</param>
  /// <param name="pooler">해당 풀러</param>
  /// <param name="trm">소환할 위치</param>
  public GameObject Spawn(GameObject obj, Stack<GameObject> pooler)
    {
        if (pooler.Count <= 0)
        {
            GameObject temp = Instantiate(obj,transform.position,Quaternion.identity);

            return temp;
        }
        else
        {
            GameObject temp = pooler.Pop();
            temp.transform.SetParent(null);
            temp.SetActive(true);

            return temp;
        }
    }

    public void DeSpawn(GameObject obj, Stack<GameObject> pooler)
    {
        pooler.Push(obj);
        obj.SetActive(false);
        obj.transform.SetParent(transform);
    }
}
