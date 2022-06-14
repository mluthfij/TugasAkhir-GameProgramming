using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        healthBarScript.health -= 9f;
    }
}
