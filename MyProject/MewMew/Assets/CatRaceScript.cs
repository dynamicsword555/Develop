using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatRaceScript : MonoBehaviour
{
    float resultRandom;
    // Update is called once per frame
    void Update()
    {
        resultRandom = UnityEngine.Random.Range(0.001f, 0.08f);
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * resultRandom;
        }
    }
}
