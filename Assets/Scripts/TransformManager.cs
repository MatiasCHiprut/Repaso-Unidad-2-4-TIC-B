using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour
{
    public GameObject myCube;
    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoyescalado;

    public Vector3 OriginalRotation;
    public Vector3 OriginalScale;

    public bool isRotated;
    public bool isScaled;
    public bool isBoth;

    void Start()
    {
        isRotated = false;
        isScaled = false;
        isBoth = false;
        OriginalRotation = myCube.transform.eulerAngles;
        OriginalScale = myCube.transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = OriginalRotation;
                isRotated = false;
            }
            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isScaled)
            {
                myCube.transform.localScale = OriginalScale;
                isScaled = false;
            }
            else
            {
                myCube.transform.localScale = escalado.transform.localScale;
                isScaled = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (isBoth)
            {
                myCube.transform.eulerAngles = OriginalRotation;
                myCube.transform.localScale = OriginalScale;
                isBoth = false;
            }
            else
            {
                myCube.transform.eulerAngles = rotadoyescalado.transform.eulerAngles;
                myCube.transform.localScale = rotadoyescalado.transform.localScale;
                isBoth = true;
            }
        }
    }
}
