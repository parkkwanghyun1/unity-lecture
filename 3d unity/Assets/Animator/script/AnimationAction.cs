using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;



    public void Dancing()
    {
        // Play : �ִϸ��̼��� �����Ű�� �Լ� 
        animator.Play("Dancing");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
