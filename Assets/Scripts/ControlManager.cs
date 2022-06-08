using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    public GameObject buttons, accelerometer;
    public bool current = false;
    // Start is called before the first frame update
    void Start()
    {
        buttons.SetActive(true);
        accelerometer.SetActive(false);
    }
    public void ChangeControls()
    {
        buttons.SetActive(current);
        accelerometer.SetActive(!current);
        current = !current; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
