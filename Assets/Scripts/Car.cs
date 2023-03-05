using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 0f;
    [SerializeField] float speedIncrementPerSecond = 0f;
    [SerializeField] float turnSpeed = 200f;
    int steerValue = 0 ;
    // Update is called once per frame
    void Update()
    {
        speed += speedIncrementPerSecond*Time.deltaTime;
        transform.Rotate(0f, steerValue*turnSpeed*Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed* Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
            
        }


    }
    public void Steer(int value)
    {
        steerValue = value;

    }
}
