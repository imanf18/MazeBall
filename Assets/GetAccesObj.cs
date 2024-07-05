using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAccesObj : MonoBehaviour
{
    [SerializeField]
    private Transform _squareTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Mendapatkan posisi object square
    Debug.Log(_squareTransform.position);

// Mendapatkan rotasi object square
    Debug.Log(_squareTransform.rotation);

// Mendapatkan rotasi object square
    Debug.Log(_squareTransform.localScale);


    // Menentukan posisi baru dari object square di titik (x: 5, y: 0, z: 0)
    //Vector3 newPosition = new Vector3(5, 0, 0);

// Merubah posisi object square ke posisi baru (newPosition)
    //_squareTransform.position = newPosition;
     // Mendapatkan posisi object square
    Debug.Log(_squareTransform.position);

// Mendapatkan rotasi object square
    Debug.Log(_squareTransform.rotation);

// Mendapatkan rotasi object square
    Debug.Log(_squareTransform.localScale);


    // Menentukan sudut rotasi baru dari object square (x: 0, y: 0, z: 45)
    Quaternion newRotation = Quaternion.Euler(0, 0, 45);

    // Merubah rotasi object square ke sudut rotasi baru (newRotation)
    _squareTransform.rotation = newRotation;

    // Menentukan skala baru dari object square (x: 2, y: 2, z: 2)
    Vector3 newScale = new Vector3(2, 2, 2);

    // Merubah skala object square menjadi skala baru (newScale)
    _squareTransform.localScale = newScale;

    // Mendapatkan posisi object square
    Debug.Log(_squareTransform.position);

    // Mendapatkan rotasi object square
    Debug.Log(_squareTransform.rotation);

    // Mendapatkan rotasi object square
    Debug.Log(_squareTransform.localScale);



    // Cara lain menggeser transform object
    _squareTransform.Translate(0, 0, 0);

    // Cara lain merotasi transform object
    _squareTransform.Rotate(0, 0, 45);
    // Mendapatkan posisi object square
    Debug.Log(_squareTransform.position);

    // Mendapatkan rotasi object square
    Debug.Log(_squareTransform.rotation);

    // Mendapatkan rotasi object square
    Debug.Log(_squareTransform.localScale);

    // Cara lain menggeser transform object
    _squareTransform.Translate(0, 0, 0);
    // Mendapatkan posisi object square
    Debug.Log(_squareTransform.position);





    }

    // Update is called once per frame
    void Update()
    {
    // Cara lain merotasi transform object
    _squareTransform.Rotate(0, 0, -30*Time.deltaTime);
    // Mendapatkan rotasi object square
    Debug.Log(_squareTransform.rotation);

    }
}
