using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifes, score;
    public UIManager uiManager;
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateLife(lifes);
        uiManager.UpdateScore(score);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
    public void MoveHorizontally(float amount)
    {
        speed = amount;
    }
}
