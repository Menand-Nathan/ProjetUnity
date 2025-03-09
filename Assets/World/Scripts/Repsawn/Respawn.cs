using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float treshold;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y < treshold)
        {
            transform.position = new Vector3(0.41f, 2.32f, 0.005f);
        }
    }
}
