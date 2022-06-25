using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCar : Vehicle
{
    public int capacity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowInfo();
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        infoText.text += "\n" + nameOfVehicle + "\nCapacity: " + capacity + " boxes.";
    }
}
