
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
       if(isDelay == false)
        {
            button.interactable = false; // ��ư ��Ȱ��ȭ
            currentTime -= Time.deltaTime; 
            button.image.fillAmount = currentTime / fixedTime;

            if(currentTime <= 0)
            {
                isDelay = true;
                button.interactable = true;
                button.image.fillAmount = currentTime = fixedTime;
            }
        }
    }
}
