using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (playerControllerScript.gameOver == false && !gameObject.CompareTag("Obstacle"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if(playerControllerScript.gameOver == false && gameObject.CompareTag("Obstacle"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

    }
}
