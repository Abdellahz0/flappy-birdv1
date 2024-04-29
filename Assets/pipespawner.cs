using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    public float heightoffset =10;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime ;
        }
        else {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3 (transform.position.x ,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
