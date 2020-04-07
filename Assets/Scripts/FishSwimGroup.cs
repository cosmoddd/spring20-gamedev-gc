using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwimGroup : MonoBehaviour
{

    public GameObject fishPrefab;
    public List<GameObject> myFishList;
    public int maxFish = 200;

    void Start()
    {

        int fishCounter = 0;
        while (fishCounter < maxFish)
        {
            // create random spawnpoint
            Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), Random.Range(-5,-5), Random.Range(-5,5));

            // spawn the fish
            GameObject myNewFish = Instantiate(fishPrefab, spawnPosition, Quaternion.Euler(0,Random.Range(0,360),0));

            myFishList.Add(myNewFish);
            fishCounter += 1;
        
        }

    }

    void Update()
    {
        
    }
}
