using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public float speed;

    private void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("You Lose");
        } else 
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseScript.isPaused)
        {
            Vector2 position = transform.position;
            position.x = position.x + -speed;
            transform.position = position;

            if (position.x <= -13.82)
            {
                Destroy(gameObject);
            }
        }
    }
}
