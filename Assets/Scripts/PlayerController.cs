using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    void FixedUpdate()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2 * Time.deltaTime;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        // transform
        //     .Translate(new Vector3(vMovement, 0, -1*hMovement) * Time.deltaTime);
        transform.position =
            new Vector3(transform.position.x + hMovement,
                transform.position.y,
                transform.position.z + vMovement);
    }

    private void OnTriggerEnter (Collider collider)
    {
        spawnManager.SpwanTriggerEntered();
        Debug.Log("aca");
    }
}
