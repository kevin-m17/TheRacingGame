using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    public GameObject TheCar;
    public float CarX;
    public float CarY;
    public float CarZ;

    // Update is called once per frame
    void Update()
    {
        // get x y z rotation of the car
        CarX = TheCar.transform.eulerAngles.x;
        CarY = TheCar.transform.eulerAngles.y;
        CarZ = TheCar.transform.eulerAngles.z;

        // want cube to be opposite rotation of the car
        transform.eulerAngles = new Vector3 (CarX - CarX, CarY, CarZ - CarZ);
    }
}
