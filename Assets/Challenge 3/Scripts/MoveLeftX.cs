using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    private float leftBound = -10;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            float3 moveDirection = new float3(-1, 0, 0);
            float3 movement = moveDirection * speed * Time.deltaTime;

            transform.Translate(new float3(movement.x, movement.y, movement.z), Space.World);
        }

        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
