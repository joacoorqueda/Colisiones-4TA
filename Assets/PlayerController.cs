using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.W))
        {
         
            transform.Translate(0, 0,MovementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            transform.Translate(0, 0, -MovementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            transform.Rotate(0, RotationSpeed,0);
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(0, -RotationSpeed, 0);
        }

    }

    void OnCollisionEnter(Collision other)
    {
      
        if(other.gameObject.name == "DeathWall")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "pareddelamuerte1")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "pareddelamuerte2")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "pareddelamuerte3")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "pareddelamuerte4")
        {
            Destroy(gameObject);
        }


    }


}
