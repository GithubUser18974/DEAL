using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class Dealers : ScriptableObject
{
    public List<MstItemEntity> Main; // Replace 'EntityType' to an actual type that is serializable.
}
