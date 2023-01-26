//using System.Numerics;
//using System.Threading.Tasks.Dataflow;
//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 10f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private  float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
