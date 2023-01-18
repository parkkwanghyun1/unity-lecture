using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;



    public void Dancing()
    {
        // Play : 애니메이션을 실행시키는 함수 
        animator.Play("Dancing");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
