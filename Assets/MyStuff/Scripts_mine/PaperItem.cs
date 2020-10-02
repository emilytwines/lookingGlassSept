using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperItem: InventoryItemBase
{
public static PaperItem Instance { get; private set; }

    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }

    }

//public float scale = 1f;
    public override string Name
    {
        get
        {
            return "paper";
        }
        set { var paper = "paper"; }
    }

    public override void OnUse()
    {
        base.OnUse();
//    this.transform.localScale = new Vector3(scale, scale, scale);
    }
    public override void OnPickup()
    {
      base.OnPickup();
    }

      public virtual void OnDrop()
      {
          base.OnDrop();
      }


}