
using UnityEngine;
using UnityEngine.UI;
using System;

public class Delay : MonoBehaviour
{
    private Button button;
    public static Action action;
    //static ���� ������ ������ �ø��� �Ǹ� ��� Ŭ�������� �����Ͽ� ��� �����ϴ�.

    private bool isDelay = true;
    private float fixedTime = 5f;
    private float currentTime = 5f;

    void Start()
    {
        action = ()=> isDelay = false;
        button = GetComponent<Button>();
        // ����Ƽ Component �� �ִ� button �� ����� ��� �ش�. 
        // <> ���� �Ű����� 
    }
 
    void Update()
    {
 
    }
}
