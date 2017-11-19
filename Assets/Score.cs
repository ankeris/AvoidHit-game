using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {


    public Transform player;
    public Text scoreText;

	// Update is called once per frame
	void Update () {

        float smallerNumber = player.position.z / 12;

        string calc = smallerNumber.ToString("0");
   
        scoreText.text = calc;
	}
}
