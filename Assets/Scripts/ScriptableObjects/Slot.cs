using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu (fileName = "IItem", menuName = "ScriptableObjects/Items")]
    public class Slot : ScriptableObject
    {
        [field:Header("UI Slot")]
        [field:SerializeField] public GameObject Prefab { get; set; }
        [field:SerializeField] public string Name { get; set; }
        [field:SerializeField, TextArea] public string Description { get; set; }
        [field:SerializeField] public Sprite Icon { get; set; }
    }
}
