﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {

    public static int CarType; 
    public GameObject TrackWindow;

    public void RedCar ()
    {
        CarType = 1; //red
        TrackWindow.SetActive(true);
    }

    public void BlueCar ()
    {
        CarType = 2; //blue
        TrackWindow.SetActive(true);
    }

}