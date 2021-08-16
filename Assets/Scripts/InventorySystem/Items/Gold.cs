using RPGeeks.Inventories;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace RPGeeks.Items
{
    public class Gold : InventoryItem
    {
        [Header("Consumable Data")]
        [SerializeField] private string description = "Gold";

        void Reset()
        {
            if (icon == null)
            {

            }
        }

        public override string ShowInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"<color=yellow>{description}</color>").AppendLine();
            builder.Append("Max Stack: ").Append(MaxStack).AppendLine();
            builder.Append("Sell Price: ").Append(SellPrice).Append(" Gold");

            return builder.ToString();
        }
    }
}
