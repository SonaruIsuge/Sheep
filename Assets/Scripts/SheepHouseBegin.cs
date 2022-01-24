using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SheepHouseBegin : MonoBehaviour
{
    public SheepPool pool;
    public float spawnTime = 3.0f;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _timer + spawnTime)
        {
            _timer = Time.time;
            pool.ReUse(this.transform.position, this.transform.rotation);
        }
    }
}
