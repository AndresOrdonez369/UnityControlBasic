using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer: MonoBehaviour
{
    private float distance = 20f;
    public GameObject player;
    [SerializeField]
    //private Vector3 offset=new Vector3(0,4,-5);

    private Vector3 playerPrevious = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 offset = player.transform.position - playerPrevious;
        offset.Normalize();
        if (offset.magnitude < 0.5f)
        {
            return;
        }
        this.transform.position = player.transform.position - offset*distance;
        transform.LookAt(player.transform.position);
        playerPrevious = player.transform.position;
    }
}
