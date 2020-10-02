using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IInventoryItem
{
  //  string Name { get; } 

string Name {get; set;}

    Sprite Image { get; }
    void OnPickup();
    void OnUse();

    void OnDrop();
}

public class InventoryEventArgs : EventArgs
{
    public InventoryEventArgs(IInventoryItem item)
    {
        Item = item;
    }
    public IInventoryItem Item;

}
