using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationComponent : MonoBehaviour
{
    public InputComponentBase InputComponent;
    [SerializeField]
    private Animator animator;

    private void Update()
    {
        if (InputComponent.GetInputDirectionNormalized().magnitude > 0f)
        {
            animator.Play("Walk");
        }
        else
        {
            animator.Play("Idle");
        }
    }
}
