using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "Coin")
        {
            Score.instance.AddPoint();
            Destroy(other.gameObject);
        }

        if (other.tag == "Finish1" && Score.instance.score > 50)
        {
            Time.timeScale = 3;
            SceneManager.LoadScene(2);
        }

        if (other.tag == "Finish2" && Score.instance.score > 50)
        {
            Time.timeScale = 3;
            SceneManager.LoadScene(3);
        }
    }
}
