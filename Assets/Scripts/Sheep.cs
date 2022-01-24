using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    bool Automatic = true;
    Vector3 destination;
    public float speed = 2;
    private Transform _myTransform;

    private void Awake()
    {
        _myTransform = transform;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        destination = GameObject.Find("sheepHouseEnd").transform.position;

        if (!gameObject.activeInHierarchy)
        {
            return;
        }

        // if (Time.time > _timer + recoveryTime)
        // {
        //     GameObject.Find("sheepPool").GetComponent<SheepPool>().Recovery(gameObject);
        // }

        // _myTransform.Translate(_myTransform.forward * speed * Time.deltaTime);

        if (Automatic)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "destination")
        {
            GameObject.Find("sheepPool").GetComponent<SheepPool>().Recovery(gameObject);
            Debug.Log("hi");
        }
    }
}
