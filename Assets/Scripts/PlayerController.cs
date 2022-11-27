using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 0;

    public bool isAccelerating = false;

    public SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isAccelerating = true;
            Debug.Log("toco");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isAccelerating = false;
            Debug.Log("solto");
        }
    }

    void FixedUpdate()
    {
        if (isAccelerating)
        {
            movementSpeed += 0.2f;
        }
        else
        {
            movementSpeed -= 0.2f;
        }
        Debug.Log(movementSpeed);
        movementSpeed = Mathf.Clamp(movementSpeed, 0, 100);

        float hMovement =
            Input.GetAxis("Horizontal") * movementSpeed / 2 * Time.deltaTime;
        float vMovement =
            Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.position =
            new Vector3(transform.position.x + hMovement,
                transform.position.y,
                transform.position.z + vMovement);
    }

    private void OnTriggerEnter(Collider collider)
    {
        spawnManager.SpwanTriggerEntered();
    }
}
