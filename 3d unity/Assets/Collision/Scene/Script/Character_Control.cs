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

        // �����̵�

        transform.Translate(direction * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    private void FixedUpdate() // fixedUpdate = update �� ����Ǳ� ���� ����Ǵ� ������
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

    // �������� �浹
    // �ΰ��� ������Ʈ �� �ϳ��� rigidBody �� ������ �־�� �Ѵ�.
    // �����̴� ��ü�� rigidBody �� �ִ°� ȿ���� �̴�.
    // trigger �� �Ѵ� �־�� �Ѵ�.
}
