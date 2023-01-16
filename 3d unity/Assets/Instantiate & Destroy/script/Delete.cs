using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    void Start()
    {
        // 게임 오브젝트를 파괴하는 함수
        Destroy(gameObject, Random.Range(1, 5));
    }
}
