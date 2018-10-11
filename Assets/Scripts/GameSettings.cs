using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class GameSettings : ScriptableObject {

    [Header ("Map Settings")]
    public int mapWidth;
    public int mapHeight;

    public float tileWidth = 1.84f;
    public float rowHeight = 1.6f;
}
