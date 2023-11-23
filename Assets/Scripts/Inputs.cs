using System.Collections;
using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    [SerializeField] GameObject Shape;
    private ShapeSO shapeSO;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
            shapeSO.EColour = EshapeColour.Red;
        if (Input.GetKeyDown(KeyCode.B))
            shapeSO.EColour = EshapeColour.Red;
        if (Input.GetKeyDown(KeyCode.G))
            shapeSO.EColour = EshapeColour.Green;
    }
}
