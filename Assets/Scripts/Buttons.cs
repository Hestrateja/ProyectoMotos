using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Player player;
    [SerializeField] InteractiveElement left, right;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(left.isPressed&&!right.isPressed)
        {
            player.MoveHorizontally(-5);
        }
        else if (right.isPressed && !left.isPressed)
        {
            player.MoveHorizontally(5);
        }
        else
        {
            player.MoveHorizontally(0);
        }

    }

    void MoveLeft()
    {

    }
}
