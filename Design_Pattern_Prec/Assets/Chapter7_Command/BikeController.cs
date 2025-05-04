using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    private bool _isturboOn;
    private float _distance = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleTurbo()
    {
        _isturboOn = !_isturboOn;
        Debug.Log("Turbo Active : " + _isturboOn.ToString());
    }

    public void Turn(DIrection dIrection)
    {
        if (dIrection == DIrection.Left)
            transform.Translate(Vector3.left * _distance);

        if (dIrection == DIrection.Right)
            transform.Translate(Vector3.right * _distance);
    }

    public void ResetPosition()
    {
        transform.position = Vector3.zero;
    }
}
