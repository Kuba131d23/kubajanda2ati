using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1000 * Time.deltaTime, 1000 * Time.deltaTime, 0);
    }
}