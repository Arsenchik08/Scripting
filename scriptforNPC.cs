using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptforNPC : MonoBehaviour
{
    Vector3 newPosition;
    public float speed = 1.5f;
    public ushort health = 5, level; // создание переменных
    void Start()
    {
        health += level; //прибавление к здоровью уровня игрока
        print(health); //вывод количества здоровья
    }


    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}