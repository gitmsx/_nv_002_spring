using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class DeformPersona : MonoBehaviour


{


    [SerializeField] private Transform _playerTransform; 
    [SerializeField] private Transform _playerBody;
    [SerializeField] private Vector3 _scaleDown = new Vector3(1.2f, 0.8f, 1.2f); 
    [SerializeField] private Vector3 _scaleUp = new Vector3(0.8f, 1.2f, 0.8f);
    [SerializeField] private float _scaleKoefficient;
    [SerializeField] private float _rotationKoefficient;


    private Text Text14;
    private GameObject Text7;




    // Start is called before the first frame update
    void Start()
    {
        Text7 = GameObject.Find("Text");
        Text14 = Text7.GetComponent<Text>();
        Text14.text = "111111111";

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePosition = _playerTransform.InverseTransformPoint(transform.position);
        float interpolant = relativePosition.y * _scaleKoefficient;
        Vector3 scale = Lerp3(_scaleDown, Vector3.one, _scaleUp, interpolant);
        _playerBody.localScale = scale;
        _playerBody.localEulerAngles = new Vector3(relativePosition.x,0,relativePosition.z)* _rotationKoefficient;
    }

    Vector3 Lerp3(Vector3 a, Vector3 b, Vector3 c, float t)
    {

        Text14.text = " a " + Math.Round(a.magnitude, digits: 3).ToString();
        Text14.text += " b " + Math.Round(b.magnitude, digits: 3).ToString();
        Text14.text += " c " + Math.Round(c.magnitude, digits: 3).ToString();
        Text14.text += " t " + Math.Round(t, digits: 3).ToString();


        if (t < 0)
            return Vector3.LerpUnclamped(a, b, t + 1f) ;
        else
            return Vector3.LerpUnclamped(b, c, t);
       

    }
}



