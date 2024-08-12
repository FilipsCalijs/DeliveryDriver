using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Объявляем переменные на уровне класса
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // Можно инициализировать переменные в Start(), но это необязательно, так как они уже инициализированы выше
    }

    // Update is called once per frame
      void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }


}
