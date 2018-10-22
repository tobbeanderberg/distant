using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public GameObject hex;
    public GameObject mainCamera;

    public GameSettings settings;

	void Start () {
        for (int x = 0; x < settings.mapWidth; x++) {
            for (int y = 0; y < settings.mapHeight; y++) {
                Instantiate(hex, 
                            new Vector3(x * settings.tileWidth + PossibleXOffset(y), 
                                        0, 
                                        (y * settings.rowHeight)), 
                            Quaternion.identity);
            }
        }
        SetInitialCameraLocation();
	}

    private void SetInitialCameraLocation() {
        mainCamera.transform.position = new Vector3(1.0f, 0.0f, 1.0f);
    }

    private float PossibleXOffset(int row) {
        return row % 2 == 0 ? 0 : settings.tileWidth/2;
    }
}
