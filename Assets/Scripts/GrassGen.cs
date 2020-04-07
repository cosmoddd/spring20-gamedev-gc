using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassGen : MonoBehaviour
{
    public GameObject grassBlade;
    public int grassCounterMax = 500;

    void Start()
    {
        int grassCounter = 0;

        while(grassCounter < grassCounterMax)
        {
            // this is where we actually instantiate the grass

            // get the spawn position
            Vector3 spawnPosition = new Vector3(
                            Random.Range(-1f, 1f),
                            0f,
                            Random.Range(-1f,1));
            Instantiate (
                            grassBlade,
                            spawnPosition,
                            Quaternion.Euler(0,Random.Range(0,360), 0)
            );

            grassCounter += 1;
        }
    }


}
