using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public Player player;
    public float multiplier = 5;

    private void Update()
    {
        player.MoveHorizontally(Mathf.Clamp(Input.acceleration.x * multiplier,-5,5));
    }
}