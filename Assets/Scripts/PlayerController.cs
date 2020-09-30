using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //PROPIEDADES - modificador de acceso - tipo de variable - nombre de la variables - valor
    //[HideInInspector]
    [Range(0,20), SerializeField, Tooltip("Velocidad maxima")]
    private float speed=5f;
    [Range(0, 90), 
        SerializeField,
        Tooltip("Velocidad de giro")]
    private float turnSpeed=45f;

    private float horizontalInput;
    private float vertialInput;

    // Start is called before the first frame update
    void Start()
    {
                            
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        vertialInput = Input.GetAxis("Vertical");
        // S=s0+ V*t*(dirección)
        this.transform.Translate(speed*Time.deltaTime*Vector3.forward* vertialInput);
        this.transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up* horizontalInput);
    }
}
