using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class GameSettings : ScriptableObject {

    [Header ("Map Settings")]
    public int mapWidth;
    public int mapHeight;

    public float tileWidth = 3.5f;
    public float rowHeight = 3.05f;
}
