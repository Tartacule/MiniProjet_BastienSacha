using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu (fileName = "IItem", menuName = "ScriptableObjects/Items")]
    public class InventorySlot : ScriptableObject
    {
        [field:Header("UI Slot")]
        [field:SerializeField] public string Name { get; set; }
        [field:SerializeField, TextArea] public string Description { get; set; }
        [field:SerializeField] public Sprite Icon { get; set; }
    }
}
