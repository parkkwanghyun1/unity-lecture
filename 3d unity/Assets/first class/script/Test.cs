using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster
{
    public Monster()
    {
        Debug.Log("Monster가 태어났습니다.");
    }
}
public class Test : MonoBehaviour
{
    public int value = 100;
    void Start()
    {
        Debug.Log(value);
        Monster monster = new Monster();
        
    }

  
    void Update()
    {
        
    }
}
