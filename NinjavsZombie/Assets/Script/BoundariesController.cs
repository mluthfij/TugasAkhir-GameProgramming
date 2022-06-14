using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10.37f, 10.37f), 
        Mathf.Clamp(transform.position.y, 0.12f, 2.73f), transform.position.z);
    }
}
