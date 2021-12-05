using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float xMax = 200; //max horizontal
    private float yMax = 200; //max vertical
    private float yMin = 0; //min Vertocal
    private float zMax = 200; //max z

    void Update()
    {
        if (transform.position.x > xMax || transform.position.x < -xMax || transform.position.y > yMax || transform.position.y < yMin || transform.position.z > zMax || transform.position.z < -zMax)
        {
            Destroy(gameObject);
        }
    }
}
