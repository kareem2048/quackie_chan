﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarClue : MonoBehaviour {

	public Text subtitles;

	void OnTriggerEnter(Collider other) {

		if (ClueManger.count == 3) {
			ClueManger.count++;
		}
		if (ClueManger.count > 3) {

			subtitles.text = "man talk";
		}
	}
	void OnTriggerStay(Collider other)
	{
		
	}
	void OnTriggerExit(Collider other)
	{

		subtitles.text = "";

	}
}
