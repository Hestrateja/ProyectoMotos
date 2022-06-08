using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform limitNeg, limitPos;
    [SerializeField] float timeBetween,range;
    private float timer;


    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            var spawn = ObjectPooler.instance.SpawnFromPool("enemy", new Vector3(Random.Range(limitNeg.position.x, limitPos.position.x), 0, limitNeg.position.z), Quaternion.Euler(0,180,0));
            spawn.SetActive(true);
            timer = timeBetween + Random.Range(-range, range);
        }
        timer -= Time.deltaTime;
    }
}
