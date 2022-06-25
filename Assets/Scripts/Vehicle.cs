using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vehicle : MonoBehaviour
{
    public Text infoText;

    public string nameOfVehicle = "Vehicle";
    // public int year {
    //     set{
    //         if (value < 0.0f)
    //         {
    //             Debug.LogError("You can`t set negative");
    //         }
    //         else
    //         {
    //             year = value;
    //         }
    //     }
    //     get {return year;}
    // }

    public int year;

    void Start(){
        year = 1984;
    }

    private void Update(){
        ShowInfo();
    }

    public virtual void ShowInfo(){
        infoText.text = "Production year: " + year;
    }
}
