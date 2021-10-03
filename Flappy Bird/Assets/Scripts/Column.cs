using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public float speed;
    void Update()
    {
        //transform заранее предосмотреная ссылка на компонент Transform
        transform.Translate(Vector2.left*speed*Time.deltaTime); //Time.deltaTime Домножаем на время иежду двумя кадрами чтобы скорость не была космической и не нужно было делать ее очень маленькой
        //Vector3-точка в 3х мерном пространстве
        //Vector2-точка в двумерном пространстве
    }
}
