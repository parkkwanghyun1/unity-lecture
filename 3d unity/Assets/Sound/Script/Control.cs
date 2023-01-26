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

        // 방향만 구할 때 벡터의 정규화를 사용한다.
        // normalized 백터의 크기를 1로 해준다

        Vector3 direction = new Vector3(x, 0, z).normalized;

        control.SimpleMove(direction * speed);
    }
}
