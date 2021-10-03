using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float speedx = 0f;
    private float dy;
    //public float miny= -2.73f; //Не нужен
    //public float maxy= 2.73f; //Не нужен
    void Start()
    {
        dy = Random.Range(-2.73f, 2.73f); // Приходиться явно указывывать тип что ваще не круто. Нужно добавить на конец f. Это не считаеться за явное указание?
        transform.position = new Vector3(transform.position.x, transform.position.y + dy, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speedx * Time.deltaTime, transform.position.y, transform.position.z);
    }
    
}
