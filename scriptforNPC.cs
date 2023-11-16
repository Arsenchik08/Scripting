using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptforNPC : MonoBehaviour
{
    Vector3 newPosition = 0;
    public float speed = 1.5f;
    public ushort health = 5, level = 1; // ñîçäàíèå ïåðåìåííûõ
    void Start()
    {
        health += level; //ïðèáàâëåíèå ê çäîðîâüþ óðîâíÿ èãðîêà
        print(health); //âûâîä êîëè÷åñòâà çäîðîâüÿ
    }


    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
