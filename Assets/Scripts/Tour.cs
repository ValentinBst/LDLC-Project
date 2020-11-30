using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tour : MonoBehaviour
{
    [SerializeField]
    Vector3 positionDeDepart;
    float Vitesse;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        float speed = 2f;
        if (currentPosition.z > 9)
        {
            //direction = new Vector3(0F, 0F, -1f);
        }
        if (currentPosition.z < -4)
        {
            //direction = new Vector3(0F, 0F, 1f);
        }

        //Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

       // rigidbody.MovePosition(newPosition);
    }
}
