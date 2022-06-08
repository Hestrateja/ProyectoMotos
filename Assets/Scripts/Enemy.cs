using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        this.transform.position = this.transform.position + transform.forward * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "despawn")
        {
            this.gameObject.SetActive(false);
        }
    }
}
