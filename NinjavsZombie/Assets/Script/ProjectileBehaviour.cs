using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if (!PauseScript.isPaused)
        {
            Vector2 position = transform.position;
            position.x = position.x + speed;
            transform.position = position;

            if (position.x >= 13.82)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ScoreScript.scoreValue += 10;
            Destroy(gameObject);
        }
    }
}
