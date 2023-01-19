using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Input.GetAxis = -1 ~ 0 ~ 1 사이의 값을 반환한다.

        float vertical = Input.GetAxis("Vertical"); // GetAxis 키입력 감지
        float horizontal = Input.GetAxis("Horizontal");

        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Horizontal", horizontal);
    }
}
