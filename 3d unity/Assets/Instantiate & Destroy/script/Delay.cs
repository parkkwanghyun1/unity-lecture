
using UnityEngine;
using UnityEngine.UI;
using System;

public class Delay : MonoBehaviour
{
    private Button button;
    public static Action action;
    //static 으로 데이터 영역에 올리게 되면 모든 클래스에서 공유하여 사용 가능하다.

    private bool isDelay = true;
    private float fixedTime = 5f;
    private float currentTime = 5f;

    void Start()
    {
        action = ()=> isDelay = false;
        button = GetComponent<Button>();
        // 유니티 Component 에 있는 button 의 기능을 담아 준다. 
        // <> 형식 매개변수 
    }
 
    void Update()
    {
 
    }
}
