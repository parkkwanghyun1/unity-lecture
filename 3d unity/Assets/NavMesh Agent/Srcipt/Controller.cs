using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{

    public float speed = 5.0f;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Move(Vector3 dir)
    {
        agent.speed = speed;
        agent.SetDestination(dir);
    }
    


    void Update()
    {
        // 마우스 왼쪽 버튼을 눌렀을 때 
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

           if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Move(hit.point);
            }
        }
    }
}
