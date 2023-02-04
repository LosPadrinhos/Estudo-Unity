using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RSG : MonoBehaviour
{
    //Random Spawn Generator 
    public GameObject Player;
    float PlaceX;
    float PlaceZ;

    void Start()
    {
        
            PlaceX = Random.Range (-15, 15);
            PlaceZ = Random.Range (-20, -29);
            Player.transform.position = new Vector3 (PlaceX, 1, PlaceZ);
        
    }
}
