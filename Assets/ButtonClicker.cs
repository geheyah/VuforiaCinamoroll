using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicker : MonoBehaviour
{
    public Button Jump;
    public Button Feed;
    public Animator buttonanimator;

    public int ClickingJump = Animator.StringToHash("ClickingJump");
    public int ClickingFeed = Animator.StringToHash("ClickingFeed");


    public void ClickJump()
    {
        buttonanimator.Play(ClickingJump);
    }

    public void ClickFeed()
    {
        buttonanimator.Play(ClickingFeed);
    }
}
