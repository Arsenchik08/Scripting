using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptforNPC : MonoBehaviour
{
    Vector3 newPosition;
    public float speed = 1.5f;
    public ushort health = 5, level; // �������� ����������
    void Start()
    {
        health += level; //����������� � �������� ������ ������
        print(health); //����� ���������� ��������
    }


    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}