using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLogger : MonoBehaviour
{
    private void Start()
    {
        var item = GetComponent<Item>();
        if (item == null) { return; }
        item.DisplayText();
    }
}

