using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public Animator animator;

    public ProjectileBehaviour ProjectilePrefab;
    public Transform LaunchOffset;

    int CollisionTimes = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            CollisionTimes++;
            if (CollisionTimes >= 10)
            {
                GameOver();
            } else {
                Die();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
        if (!PauseScript.isPaused)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(ProjectilePrefab,LaunchOffset.position,transform.rotation);
            }
        }
    }

    void Die()
    {
        animator.SetTrigger("Die");
        SoundManagerScript.PlaySound("playerHurt");
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
