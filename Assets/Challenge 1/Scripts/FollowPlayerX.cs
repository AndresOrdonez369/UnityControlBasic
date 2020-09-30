using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    private float distanceA = 20f;

    public GameObject plane;

    //private Vector3 offset=new Vector3(0,4,-5);

    private Vector3 playerPreviousPosition = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = plane.transform.position - playerPreviousPosition;
        offset.Normalize();

        if (offset.magnitude < 0.5f)
        {
            return;
        }
        this.transform.position = plane.transform.position - offset * distanceA;
        transform.LookAt(plane.transform.position);
        playerPreviousPosition = plane.transform.position;
    }
}
