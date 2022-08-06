using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Linq.Enumerable;

public class Scorer : MonoBehaviour
{
    public static int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag != "Hit" && collision.gameObject.tag =="player")
        {
            Debug.Log(score++);
            gameObject.tag = "Hit";
            GetComponent<MeshRenderer>().material.color = Color.blue;
            foreach (var index in Range(0, transform.childCount))
            {
                transform.GetChild(index).GetComponent<MeshRenderer>().material.color = Color.blue;
                transform.GetChild(index).GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
    }
}
