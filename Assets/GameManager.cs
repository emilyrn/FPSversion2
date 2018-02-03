using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static int shots = 0;
	public static int hits = 0;
	public static float availableAmmo;
	public float clipSize;

	public GameObject scoreCanvas;
	public Text scoreText;
	public Text ammoText;

	void Start () {
		availableAmmo = clipSize;
	}
	// Update is called once per frame
	void Update () {
		if (shots > 0) {
			scoreCanvas.SetActive (true);
			float hitPct = hits / (float)shots * 100;
			hitPct = Mathf.RoundToInt (hitPct);
			scoreText.text = hits + " / " + shots + " : " + hitPct + "%";
			availableAmmo = clipSize - shots;
			ammoText.text = availableAmmo + " / " + clipSize;

		} else {
			scoreCanvas.SetActive (false);
		}
		NoAmmo();

	}

	void NoAmmo () {
		if (availableAmmo < 1 ) {
			ammoText.text = "No Ammo";

		}

	}



}