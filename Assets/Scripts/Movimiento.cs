using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject Derecha;
    public GameObject Medio;
    public GameObject Izquierda;
    private Transform pointA;
    private Transform pointB;
    private Transform pointC;
    Vector3 myVector;
    public float speed;
    // Use this for initialization
    void Start()
    {
        myVector = Medio.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == Medio.transform.position)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                //transform.position = Izquierda.transform.position;
                myVector = new Vector3(Izquierda.transform.position.x, Izquierda.transform.position.y, Izquierda.transform.position.z);

            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //transform.position = Derecha.transform.position;
                myVector = new Vector3(Derecha.transform.position.x, Derecha.transform.position.y, Derecha.transform.position.z);
            }

        }
        if (transform.position == Derecha.transform.position)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Debug.Log("Dcha a medio");
                //transform.position = Medio.transform.position;
                myVector = new Vector3(Medio.transform.position.x, Medio.transform.position.y, Medio.transform.position.z);
            }
        }
        if (transform.position == Izquierda.transform.position)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Debug.Log("Izq a medio");
                //transform.position = Medio.transform.position;
                myVector = new Vector3(Medio.transform.position.x, Medio.transform.position.y, Medio.transform.position.z);

            }

        }
        transform.position = Vector3.MoveTowards(transform.position, myVector, speed);
    }
}