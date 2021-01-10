using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLauncher : MonoBehaviour {

	public float MUSICvol;
	public float SFXvol;

	public void MusicSlider(float Volume){
		MUSICvol = Volume;
	}
	public void SFXSlider(float Volume){
		SFXvol = Volume;
	}
}
