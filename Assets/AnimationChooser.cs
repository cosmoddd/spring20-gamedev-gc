using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChooser : MonoBehaviour
{
    public  Animator thisAnimator;

    void Start()
    {
        thisAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            thisAnimator.SetTrigger("Eric");
        }
    }
}
