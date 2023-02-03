using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Slider healthGauge;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StateLayer(float health)
    {
        healthGauge.value = health;

        float temporary = 1 - healthGauge.value;

        animator.SetLayerWeight(animator.GetLayerIndex("Other Layer"), temporary);
    }
   

    }