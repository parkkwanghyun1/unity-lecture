using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    void Start()
    {
        // ���� ������Ʈ�� �ı��ϴ� �Լ�
        Destroy(gameObject, Random.Range(1, 5));
    }
}
