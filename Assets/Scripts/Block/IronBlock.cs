using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBlock : Block
{
    public override void DebugSelf()
    {
        base.DebugSelf();
        Debug.Log($"And I am an Iron Block");
    }
}
