using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //offset from the player positition
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //late update will update after our update method is called
    {
        //offset value for the camera behid the player.
        transform.position = player.transform.position + offset;;
    }
}
