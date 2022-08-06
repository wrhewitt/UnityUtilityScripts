using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Linq.Enumerable;

public class MovePlayer : MonoBehaviour
{
    public float movementSpeed = 1000.0f;
    public float rotationSpeed = 100.0f;
    void Update()
    {
        foreach (var index in Range(0, transform.childCount))
        {
            transform.GetChild(index).Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
            transform.GetChild(index).Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        }
    }
}
