using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public Button Jump;
    public Button Feed;

    public int Jumping = Animator.StringToHash("Jumping");
    public int Feeding = Animator.StringToHash("Feeding");

    public void Start()
    {
        animator = GetComponent<Animator>();
        Jump = GetComponent<Button>();
        Feed = GetComponent<Button>();
    }

    public void _Jump()
    {
        animator.SetTrigger(Jumping);
    }

    public void _Feed()
    {
        animator.SetTrigger(Feeding);
    }

}
