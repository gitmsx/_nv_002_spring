using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Transform _target;
    [SerializeField] Transform _target2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _target.position;
        transform.LookAt(_target2.position); // смотрит на персонажа
    }
}
