
using UnityEngine;

namespace ScriptableObjects
{
    public enum EshapeColour
    {
        Red,
        Blue,
        Green
    }

    [CreateAssetMenu(menuName = "ShapeSO", fileName = "ShapeSO", order = 1)]
    
    public class ShapeSO: ScriptableObject
    {
        [field: SerializeField] public EshapeColour EColour { get; set; }

    }
}


