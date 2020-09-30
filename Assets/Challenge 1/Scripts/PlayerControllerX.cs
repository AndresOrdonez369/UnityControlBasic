using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Range(0, 20), SerializeField, Tooltip("Velocidad Constante")]
    private float speed = 40f;
    private float eliceSpeed = 2300f;
    [Range(0, 90),
        SerializeField,
        Tooltip("Velocidad de giro")]
    private float rotationSpeed = 45f;
    
    private GameObject respawn;

    public float acelerationInput;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        if (respawn == null)
            respawn = GameObject.FindWithTag("Respawn");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        acelerationInput = Input.GetAxis("Jump");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed* Time.deltaTime* acelerationInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime*verticalInput);
        this.transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.up* horizontalInput);
        if (acelerationInput > 0)
        {
            respawn.transform.Rotate(Vector3.forward * eliceSpeed * Time.deltaTime);

        }
    }
}
