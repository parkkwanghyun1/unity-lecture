using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Control : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // p = p0 + vt
       // transform.position = direction;

        // 평행이동

        transform.Translate(direction * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    private void FixedUpdate() // fixedUpdate = update 가 실행되기 전에 실행되는 연산자
    {
        rigid.MovePosition
            (
            rigid.position + direction * speed * Time.deltaTime
            );
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void OnCollisionStay(Collision collision)
    {
        condition = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    // 물리적인 충돌
    // 두개의 오브젝트 중 하나라도 rigidBody 를 가지고 있어야 한다.
    // 움직이는 물체에 rigidBody 를 넣는게 효율적 이다.
    // trigger 는 둘다 있어야 한다.
}
