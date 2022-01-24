using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepPool : MonoBehaviour
{
    public GameObject sheep1;
    public int initialSize = 20;

    private Queue<GameObject> sheep_pool = new Queue<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < initialSize; i++)
        {
            GameObject sheep = Instantiate(sheep1) as GameObject;
            sheep_pool.Enqueue(sheep);
            sheep.SetActive(false);
        }
    }

    public void ReUse(Vector3 position, Quaternion rotation)
    {
        if (sheep_pool.Count > 0)
        {
            GameObject reuse = sheep_pool.Dequeue();
            reuse.transform.position = position;
            reuse.transform.rotation = rotation;
            reuse.SetActive(true);
        }
        else
        {
            Debug.Log("沒有要生成羊");
        }
    }

    public void Recovery(GameObject recovery)
    {
        sheep_pool.Enqueue(recovery);
        recovery.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
