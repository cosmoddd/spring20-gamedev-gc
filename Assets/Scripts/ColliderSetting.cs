using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSetting : MonoBehaviour
{
    void OnCollisionEnter()
    {
        print("You've touched the collision!");
    }

    void OnTriggerEnter()
    {
        print("You've entered the trigger!");
    }
}
