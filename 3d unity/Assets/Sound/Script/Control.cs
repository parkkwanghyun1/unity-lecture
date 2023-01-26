using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 5.0f;
    private CharacterController control;
    void Start()
    {
        control = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // ���⸸ ���� �� ������ ����ȭ�� ����Ѵ�.
        // normalized ������ ũ�⸦ 1�� ���ش�

        Vector3 direction = new Vector3(x, 0, z).normalized;

        control.SimpleMove(direction * speed);
    }
}
