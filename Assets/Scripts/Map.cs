using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject hexPrefab;
    public GameObject mainCamera;

    public GameSettings settings;

    float offRowColumnOffset = 0.9f;
    float rowHeight = 1.6f;
    float tileWidth = 1.84f;

	void Start () {
        for (int x = 0; x < settings.mapWidth; x++) {
            for (int y = 0; y < settings.mapHeight; y++) {
                Instantiate(hexPrefab, 
                            new Vector3(x * tileWidth + PossibleXOffset(y), 
                                        0, 
                                        (y * rowHeight)), 
                            Quaternion.identity);
            }
        }
        SetInitialCameraLocation();
	}

    private void SetInitialCameraLocation() {
        mainCamera.transform.position = new Vector3(1.0f, 0.0f, 1.0f);
    }

    private float PossibleXOffset(int row) {
        return row % 2 == 0 ? 0 : offRowColumnOffset;
    }
}
