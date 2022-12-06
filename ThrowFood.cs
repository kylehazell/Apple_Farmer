using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour
{
    public GameObject _foodToThrow;
    public bool canPressSpace =true;
    public float delay = 0.5f;
    // Start is called before the first frame update
    void KeyReset()
    {
        canPressSpace=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("SpaceBar") && canPressSpace)
        {
            canPressSpace =false;
            Instantiate(_foodToThrow, new Vector3(transform.position.x,transform.position.y, transform.position.z), Quaternion.identity);
            //makes apples move forward
            Invoke("KeyReset", delay);
        }
    }
}
