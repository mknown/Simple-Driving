using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 0f;
    [SerializeField] float speedIncrementPerSecond = 0f;
    [SerializeField] float turnSpeed = 200f;
    [SerializeField] int steerValue ;
    // Update is called once per frame
    void Update()
    {
        speed += speedIncrementPerSecond*Time.deltaTime;
        transform.Rotate(0f, steerValue*turnSpeed*Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed* Time.deltaTime);
        
    }
    public void Steer(int value)
    {
        steerValue = value;

    }
}
