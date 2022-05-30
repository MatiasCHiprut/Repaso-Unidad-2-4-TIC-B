using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    public int OriginalPos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(0, OriginalPos, 0);
        }
        if (collision.gameObject.name == "DeathFloor")
        {
            transform.position = new Vector3(0, OriginalPos, 0);
        }
    }
}
