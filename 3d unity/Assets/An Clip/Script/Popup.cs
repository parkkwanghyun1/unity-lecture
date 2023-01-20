using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public Animator animator;
    public GameObject window;


    void Update()
    {
        // �ִϸ����� ��Ʈ�ѷ����� ���� �ִϸ������� ���� �̸��� "Close" ���
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            // float ���� �ٻ簪���� �� 
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                window.SetActive(false);
            }
        }
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }

    public void PopUpOpen()
    {
        window.SetActive(true);
    }
}
