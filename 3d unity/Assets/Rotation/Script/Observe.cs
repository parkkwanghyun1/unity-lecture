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
        // Ÿ���� �ٶ󺸴� �Լ�
        transform.LookAt(target.transform);

        yield return new WaitForSeconds(1f);

        // Corutine �Լ��� ��ȯ�� �ʿ��ϴ�

        transform.rotation = Quaternion.Euler(15, 90, 0);
    }
}
