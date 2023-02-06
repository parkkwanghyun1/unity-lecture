using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject moon;
    public GameObject origin;
    public float speed = 1.0f;

    void Start()
    {
        StartCoroutine(RotateCoroutine());
        // Coroutine 함수는 StartCorutine 함수를 이요해 불러낸다
    }

    IEnumerator RotateCoroutine()
    {
        while (true)
        {
            transform.RotateAround
                (
                origin.transform.position,
                Vector3.down,
                speed * Time.deltaTime

                // Time.deltaTime 을 곱해주는 이유 =  기기와 상관 없이 동일한 성능을 내기위해서 
                );

            moon.transform.Rotate(0.1f, 0.1f, 0.1f);

            yield return null;
        }
    }
}

