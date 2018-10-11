using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class GameSettings : ScriptableObject {

    [Header ("Map Settings")]
    public int mapWidth;
    public int mapHeight;

}
