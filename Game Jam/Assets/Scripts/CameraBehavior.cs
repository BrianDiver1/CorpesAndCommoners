using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    float horizontalMovement;
    float verticalMovement;
    public float cameraSpeed;
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalMovement*cameraSpeed*Time.deltaTime);
        transform.Translate(Vector2.right * horizontalMovement*cameraSpeed*Time.deltaTime);
    }
}
