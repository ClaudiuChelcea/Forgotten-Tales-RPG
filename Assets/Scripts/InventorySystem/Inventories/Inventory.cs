using RPGeeks.Items;
using UnityEngine;

namespace RPGeeks.Inventories
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "New Inventory", menuName = "Items/Inventory")]
    public class Inventory : ScriptableObject
    {
        [SerializeField] private ItemSlot testItemSlot = new ItemSlot();
        [SerializeField] private int inventorySize = 20;
        [SerializeField] private ItemContainer itemContainer = new ItemContainer(20);

        public ItemContainer ItemContainer { get => itemContainer; private set => itemContainer = value; }
        public int Size { get => inventorySize; }

        public delegate void OnInventoryUpdated();
        public event OnInventoryUpdated onInventoryUpdated;

        private void OnValidate()
        {
            if (inventorySize != ItemContainer.Size)
            {
                ItemContainer = new ItemContainer(inventorySize);
            }
        }

        public void OnEnable()
        {
            ItemContainer.onItemsUpdated += () => onInventoryUpdated?.Invoke();
        }

        public void OnDisable()
        {
            ItemContainer.onItemsUpdated -= () => onInventoryUpdated?.Invoke();
        }

        [ContextMenu("Test Add")]
        public void TestAdd()
        {
            ItemContainer.AddItem(testItemSlot);
        }
    }
}