using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVehicle : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(0,0,0);
    public GameObject[] Vehicles;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Vehicles[index].gameObject.SetActive(true);
        //Instantiate(Vehicles[index], spawnPos, Vehicles[index].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(index);
    }

    public void GoForward(){
        if(index == Vehicles.Length - 1){
            Vehicles[index].gameObject.SetActive(false);
            index = 0;
            SpawnVehicle();
            return;
        }
        Vehicles[index].gameObject.SetActive(false);
        index += 1;
        SpawnVehicle();
    }

    public void GoBack(){
        if(index == 0){
            Vehicles[index].gameObject.SetActive(false);
            index = Vehicles.Length - 1;
            SpawnVehicle();
            return;
        }
        Vehicles[index].gameObject.SetActive(false);
        index -= 1;
        SpawnVehicle();
    }

    private void SpawnVehicle(){
        Vehicles[index].gameObject.SetActive(true);
        //Instantiate(Vehicles[index], spawnPos, Vehicles[index].transform.rotation);
    }
}
