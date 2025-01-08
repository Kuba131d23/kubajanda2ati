using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float VectorX;
    [SerializeField] float VectorY = 0;
    [SerializeField] float VectorZ;
    [SerializeField] float Basespeed = 3;
    [SerializeField] float Currentspeed;
    [SerializeField] float Sprint = 3;

    // Start is called before the first frame update
    void PrzykladMetody(int liczba)
    {
        Debug.Log("Napisana liczba to: " + liczba);

    }

    // Update is called once per frame
    void Update()
    {
        VectorX = Input.GetAxis("Horizontal");
        VectorZ = Input.GetAxis("Vertical");
        transform.Translate(VectorX * Time.deltaTime*Currentspeed, VectorY * Time.deltaTime*Currentspeed, VectorZ * Time.deltaTime*Currentspeed);
        if (Input.GetKey(KeyCode.LeftShift)) {
            Currentspeed = Basespeed + Sprint;
        }
        else
        {
            Currentspeed = Basespeed;
        }
    }
}
