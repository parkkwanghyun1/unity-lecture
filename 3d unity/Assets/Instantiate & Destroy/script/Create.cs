using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject prefab; // 생성할 게임 오브젝트
    public Transform[] randomPostion;

    public void GenericCreate()
    {
        Delay.action();

        Instantiate // 게임 오브젝트를 생성하는 함수
            (
            prefab,  // 생성해야하는 게임 오브젝트
            randomPostion[Random.Range(0, 4)].position,  // 생성되는 오브젝트의 위치
                                                         // 0 ~ 3 까지의 난수 
            Quaternion.identity // 생성되는 게임 오브젝트의 회전 
            );
    }


}
