using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 0f;
    [SerializeField] float speedIncrementPerSecond = 0f;
    // Update is called once per frame
    void Update()
    {
        speed += speedIncrementPerSecond*Time.deltaTime;
        transform.Translate(Vector3.forward * speed* Time.deltaTime);
        
    }
}
