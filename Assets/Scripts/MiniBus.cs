using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBus : RedCar
{
    public int passengers;
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
        infoText.text = "Production year: " + year;
        infoText.text += "\n" + nameOfVehicle + "\nCapacity: " + capacity + " boxes.";
        infoText.text += "\n" + "Maximum passengers: " + passengers;
    }
}
