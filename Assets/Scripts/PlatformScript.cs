using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformScript : MonoBehaviour
{
    public float xSpeed;
    public float xLimitR;
    public float xLimitL;
    public bool toRight;

    void Start()
    {
        toRight = true;
    }

    void Update()
    {
        if (toRight) {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x>=xLimitR)
        {
            toRight = false;
        }
        else if(transform.position.x <=xLimitL)
        {
            toRight = true;
        }
    }
}
