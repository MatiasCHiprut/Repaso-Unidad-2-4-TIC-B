using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;
    public Text txtCountDown;

    public float TimeToChange;
    public float waitTime;
    int counter;

    void Start()
    {
        counter = 3;
        txtCountDown.text = counter.ToString();
    }

    void Update()
    {
        //Acceder al tiempo transcurrido desde el inicio del juego;
        txtTime.text = Time.time.ToString();
        txtTimeFloored.text = Mathf.FloorToInt(Time.time).ToString();

        if (TimeToChange<Time.time)
        {
            counter--;
            if (counter != 0)
            {
                txtCountDown.text = counter.ToString();
                TimeToChange += waitTime;
            }
            else
            {
                txtCountDown.text = "GO!";
            }
        }
    }
}
