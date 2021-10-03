using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpav : MonoBehaviour
{
    public float period = 1f;
    private float pretime = 0f;
    [SerializeField] GameObject wavepref;

    void Start()
    {
        pretime = Time.time - period * 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - pretime >= period)
        {
            GameObject wp = Instantiate(wavepref, transform);
            
            pretime = Time.time;
        }

    }
}
