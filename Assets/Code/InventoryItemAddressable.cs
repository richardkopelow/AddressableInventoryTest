﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu]
public class InventoryItemAddressable : ScriptableObject
{
    public AssetReferenceTexture2D ItemSprite;
    public int Price;
    public float Rarity;

    string path;

    private void OnEnable()
    {
        path = Application.persistentDataPath + "/ItemAddressable.json";
    }

    public void Save()
    {
        string json = JsonUtility.ToJson(this);
        File.WriteAllText(path, json);
    }

    public void Load()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}
