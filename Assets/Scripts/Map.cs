using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject hexPrefab;
    //public GameObject camera;

    public int numTilesX;
    public int numTilesY;

    float offRowColumnOffset = 0.9f;
    float rowOffset = 1.6f;

	void Start () {
        for (int x = 0; x < numTilesX; x++) {
            for (int y = 0; y < numTilesY; y++) {
                Instantiate(hexPrefab, new Vector3(x * 1.84f + (y%2 == 0 ? 0 : offRowColumnOffset), 0, ((y*rowOffset))), Quaternion.identity);
            }
        }
        //camera.transform.position = new Vector3(0, 10f, -3f);
        //camera.transform.rotation = Quaternion.Euler(45, 30, 0);
	}
}
