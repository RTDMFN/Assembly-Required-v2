using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HotbarElement", menuName = "HotbarMenu/Element", order = 2)]
public class Hotbar : ScriptableObject
{
    public HotbarElement[] HotbarElements;
}
