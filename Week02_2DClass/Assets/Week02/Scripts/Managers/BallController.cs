using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject paddle;
    public float yOffestStart = 0.3f;

    public bool gameStarted = false;
    public Vector2 randomXVector = new Vector2(-2f, 2f);
    public Vector2 randomYVector = new Vector2(10f, 15f);
    private Vector2 velocityDirection = new Vector2(2f, 15f);

    // Start is called before the first frame update
    void Start()
    {
        float randomX = Random.Range(randomXVector.x, randomXVector.y);
        float randomY = Random.Range(randomYVector.x, randomYVector.y);
        velocityDirection = new Vector2(randomX, randomY);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted == false)
        {
            FollowPaddle();

            LaunchBallOnMouseClick();

        }
        //FollowPaddle();
    }

    private void LaunchBallOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Pressed primary button.");
            // Set the ball to go in a direction 
            GetComponent<Rigidbody2D>().velocity = velocityDirection;
            // Enables the gamestart so it can stop tracking the ball
            gameStarted = true;
        }
    }

    private void FollowPaddle()
    {
        Vector3 paddlePosition = new Vector3(paddle.transform.position.x, paddle.transform.position.y + yOffestStart, 0);
        transform.position = paddlePosition;
    }

    void FixedUpdate() 
    {
        

    }
}
