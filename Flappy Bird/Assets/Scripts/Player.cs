using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidBody; // обьявляем локальную переменную чтобы в юнити засунуть в нее компонент
    public float force; //Переменная нужна для изменения переменной в юнити
    //float чаще всего используеться в юнити
    public int points;
    public GameObject RestartButton; //Ссылкан а кнопку
    void Start()
    {
        Time.timeScale = 1; //Задаем начальное время
    }
    void Update() 
    {
        if (Input.GetMouseButtonDown(0)) //Когда нажимаем левую кнопку мыши. Если убрать Down и зажать кнопку птица будет бесконецно подпрыгивать
        //(Input.GetMouseButtonUp(0)// Реагирует на отпуск мыши можно использовать чтобы бахать спринт
            {
            rigidBody.AddForce(Vector2.up*force,ForceMode2D.Impulse); //чтобы преодолеть гравитацию  вообще неплохобы домножать на публичную переменную
           //ForceMode2D.Impulse тип прикладывемой силы обычная или импульс если толкаем прикладываем сили если бьем то это импульс
        
        }
    }
    //private void OnCollisionEnter2D(Collision2D other) // обработка столкновения ваще с любым обьектом. Если он не триггер
    //{
    //    Debug.Log("Вы проиграли!");
    //    Destroy(gameObject);
    //}
    private void OnTriggerEnter2D(Collider2D other) // Обрабатываем столновение с невидиым боксом что считает очки. Нужно только включить параметр тригер иначе при столновении смерть. Ибо вверху обрабатываеться что столкновение уничтожает.
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            Time.timeScale = 0; // останавливаем время 
            Debug.Log("Вы проиграли!");
            Destroy(gameObject);
            RestartButton.SetActive(true); // При включении кнопка есть
        }
        if (other.gameObject.CompareTag("Score"))
        {
            points++;
            Debug.Log(points);

        }
        
    }
}
