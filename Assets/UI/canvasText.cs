using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class canvasText : MonoBehaviour {
    const string br = "\r\n";
    string playerName = "p1.1";
    int health = 100;
    double speed = 10;
    int bombCapacity = 1;
    Text text;

    void Awake() {
        text = GetComponent<Text>();
    }

	// Update is called once per frame
	void Update () {
        text.text = playerName + br + br + "Health:" + br + health + br + br + "Speed:" + br + speed + br + br + "Bomb Capacity:" + br + bombCapacity;
    }
}
