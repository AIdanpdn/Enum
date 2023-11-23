using ScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Shape : MonoBehaviour
{
    [SerializeField] private ShapeSO shapeSO;
    [SerializeField] private Material material;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            shapeSO.EColour = EshapeColour.Red;
        if (Input.GetKeyDown(KeyCode.B))
            shapeSO.EColour = EshapeColour.Blue;
        if (Input.GetKeyDown(KeyCode.G))
            shapeSO.EColour = EshapeColour.Green;

        if (shapeSO.EColour == EshapeColour.Blue)
            material.color = Color.blue;
        if(shapeSO.EColour == EshapeColour.Green)
            material.color = Color.green; 
        if(shapeSO.EColour == EshapeColour.Red)
            material.color = Color.red;
    }
}
