using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    private Transform playerTransform;

    private float yOffset = 11;

    private float zOffset = -5f;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position =
            new Vector3(playerTransform.position.x,
                playerTransform.position.y + yOffset,
                playerTransform.position.z + zOffset);
    }
}
