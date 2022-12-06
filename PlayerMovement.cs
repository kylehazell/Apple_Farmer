using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float Boundry = 13;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.x < -Boundry)
        {
            transform.position = new Vector3(-Boundry, transform.position.y, transform.position.z);
        }
        if(transform.position.x > Boundry)
        {
            transform.position = new Vector3(Boundry, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
