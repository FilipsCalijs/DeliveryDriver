using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Объявляем переменные на уровне класса
    float steerSpeed = 1f;
    float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // Можно инициализировать переменные в Start(), но это необязательно, так как они уже инициализированы выше
    }

    // Update is called once per frame
    void Update()
    {
        // Теперь переменные доступны и здесь
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
