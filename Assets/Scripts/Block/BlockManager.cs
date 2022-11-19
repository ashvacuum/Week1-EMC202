using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockManager : MonoBehaviour
{
    public Block[] Blocks;
    
    private void Start()
    {
        foreach (var block in Blocks)
        {
            block.DebugSelf();
           
        }
    }
}
