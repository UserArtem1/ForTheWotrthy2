using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveScript : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    private Vector3 V3;
    public float speed = 5f;

    private void Start() 
    {
        V3 = cube1.transform.position;
    }

    public int counter = 0;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Trigger");
        counter = 1;
    }

    public void Update()
    {
        if (counter != 1)
        {
            cube1.transform.position = Vector3.MoveTowards(cube1.transform.position, cube2.transform.position, speed * Time.deltaTime);
            
        }
        else
        {
            cube1.transform.position = V3;
            counter = 0;
            
        }
    }


}


