using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Vehicle
{
    public float weight;
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
        infoText.text += "\n" + "Can shoot." + "\nWeight: " + weight;
    }
}
