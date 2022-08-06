using UnityEngine;

public class Fall : MonoBehaviour
{
    int timer = 0;

    void Start()
    {
        timer = (int)Random.Range(5f,30f);
    }
    void Update()
    {
        if((int)Time.time > timer)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
       transform.Translate(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
        transform.Rotate(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
    }
}
