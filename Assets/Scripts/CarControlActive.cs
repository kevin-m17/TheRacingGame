using UnityStandardAssets.Vehicles.Car;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject Dreamcar01;
    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
        // CarControl.GetComponent("CarController").SetActive(true);
        // CarControl.GetComponent<CarController>().SetActive(true);
        // CarControl.GetComponent(CarController).SetActive(true);
        // Dreamcar01.GetComponent(CarAIControl).SetActive(true);
        // Dreamcar01.GetComponent("CarAIControl").enabled = true;
    }
}
