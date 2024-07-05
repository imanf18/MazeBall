using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BtnManagement : MonoBehaviour
{
    [SerializeField]
    private Transform _squareTransform;
    [SerializeField]
    private float direction;
    public void ClickKanan()
    {
        // Cara lain merotasi transform object
    _squareTransform.Rotate(0, 0, -45*Time.deltaTime);
    }

    public void ClickKiri()
    {
        _squareTransform.Rotate(0, 0, 45*Time.deltaTime);
    }

    public void RotateKanan()
    {
        direction = -1;
    }
    public void RotateKiri()
    {
        direction = 1;
    }

    public void ResetRotation()
    {
        direction = 0;
    }

    private void Update()
    {
        if (direction ==1) 
        { _squareTransform.Rotate(0, 0, 100*Time.deltaTime);}
        if (direction == -1) 
        { _squareTransform.Rotate(0, 0, -100*Time.deltaTime);}
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
}
