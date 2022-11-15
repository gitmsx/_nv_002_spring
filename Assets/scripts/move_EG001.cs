using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_EG001 : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private float _rotationSensitivity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); 
        float v = Input.GetAxisRaw("Vertical"); 
        float r = Input.GetAxisRaw("Mouse X");
        Vector3 offset = new Vector3(h, 0f, v) * Time.deltaTime * _speed; 
        transform.Translate(offset);
        transform.Rotate(0f, r * _rotationSensitivity, 0f);


    }
}




    
