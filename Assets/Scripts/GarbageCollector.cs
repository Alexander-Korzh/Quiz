using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    public void Collect()
    {
        System.GC.Collect();
    }
}
