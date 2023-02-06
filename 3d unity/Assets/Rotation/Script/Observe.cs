using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject target;

    public void EarthObservation()
    {
        StartCoroutine(LookCorutine());
    }
    public IEnumerator LookCorutine()
    {
        // 타겟을 바라보는 함수
        transform.LookAt(target.transform);

        yield return new WaitForSeconds(1f);

        // Corutine 함수는 반환이 필요하다

        transform.rotation = Quaternion.Euler(15, 90, 0);
    }
}
