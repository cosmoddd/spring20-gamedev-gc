using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBasis : MonoBehaviour
{

    public Animator thisAnimator;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            thisAnimator.SetTrigger("grow");
        }
    }

}
