using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject prefab; // ������ ���� ������Ʈ
    public Transform[] randomPostion;

    public void GenericCreate()
    {
        Delay.action();

        Instantiate // ���� ������Ʈ�� �����ϴ� �Լ�
            (
            prefab,  // �����ؾ��ϴ� ���� ������Ʈ
            randomPostion[Random.Range(0, 4)].position,  // �����Ǵ� ������Ʈ�� ��ġ
                                                         // 0 ~ 3 ������ ���� 
            Quaternion.identity // �����Ǵ� ���� ������Ʈ�� ȸ�� 
            );
    }


}
