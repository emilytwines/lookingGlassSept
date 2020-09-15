using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperItem: InventoryItemBase

{
//public float scale = 1f;
    public override string Name
    {
        get
        {
            return "paper";
        }
    }

    public override void OnUse()
    {
        base.OnUse();
//    this.transform.localScale = new Vector3(scale, scale, scale);
    }
    public virtual void OnPickup()
    {
      base.OnPickup();
    }

      public virtual void OnDrop()
      {
          base.OnDrop();
      }
}