﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreItemManager : MonoBehaviour
{
    public static StoreItemManager storeItemManager;
    public static List<StoreItemAttributes> itemList = new List<StoreItemAttributes>();

    private void Awake()
    {
        if (storeItemManager = null)
            storeItemManager = this;

        itemList.Add(new StoreItemAttributes(StoreItemAttributes.ItemType.hat, 500, "hat1", true));
    }
}