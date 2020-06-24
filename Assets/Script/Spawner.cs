using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Bad;
    private float X;
    private int Ran;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawner()
    {
        Ran = Random.Range(0, Bad.Length);

        X = Random.Range(3f, -6f);
        this.transform.position = new Vector3(X, 0f, 8f);
        Instantiate(Bad[Ran], transform.position, transform.rotation);
    }
}
