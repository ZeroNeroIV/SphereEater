using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private GameObject spawn1;
    private GameObject spawn2;
    private GameObject spawn3;
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("Spawn", 1f, 2.5f);

        spawn1 = GameObject.Find($"/{gameObject.name}/Spawn 1");
        spawn2 = GameObject.Find($"/{gameObject.name}/Spawn 2");
        spawn3 = GameObject.Find($"/{gameObject.name}/Spawn 3");
    }

    // Update is called once per frame
    private void Spawn()
    {
        var num = Random.Range(1, 4);
        var spawn_point = spawn1;
        if (num == 2) spawn_point = spawn2;
        else if (num == 3) spawn_point = spawn3;

        Instantiate(ball, spawn_point.transform.position, spawn_point.transform.rotation);        
    }
}
