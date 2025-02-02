﻿using KitchenData;
using KitchenLib.Customs;
using UnityEngine;

namespace ApplianceLib.Customs.GDO
{
    public abstract class ModDish : CustomDish, IModGDO
    {
        public abstract override string UniqueNameID { get; }
        public abstract override DishType Type { get; }
        public override CardType CardType => CardType.Default;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;
        public override bool IsUnlockable => true;

        public override sealed void OnRegister(GameDataObject gdo)
        {
            if (IconPrefab != null)
            {
                SetupIconPrefab(IconPrefab);
            }

            if (DisplayPrefab != null)
            {
                SetupDisplayPrefab(DisplayPrefab);
            }

            Modify(gdo as Dish);
        }

        protected virtual void SetupIconPrefab(GameObject prefab) { }

        protected virtual void SetupDisplayPrefab(GameObject prefab) { }

        protected virtual void Modify(Dish dish) { }
    }
}
