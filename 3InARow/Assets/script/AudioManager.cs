using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

	private static bool NotActive = true;

	public AudioMixer Main;
	public AudioMixerGroup BCmusic;
	public AudioMixerGroup SFXaudio;

	public float MusicVol;
	public float SfxVol;

	void Awake()
	{
		if(NotActive){
			DontDestroyOnLoad(this.gameObject);
			NotActive = false;
		}else{
			GameObject.Destroy(this.gameObject);
		}
	}
	void Update()
	{

		AudioLauncher AL = GameObject.Find("AudioLancher").GetComponent<AudioLauncher>();

		MusicVol = AL.MUSICvol;
		SfxVol = AL.SFXvol;

		if(MusicVol >= -35f){
			Main.SetFloat("BCmusic", MusicVol);
		}
		else if(MusicVol <= -35f){
			Main.SetFloat("BCmusic", -80);
		}
		if(SfxVol >= -35f){
			Main.SetFloat("SFXaudio", SfxVol);

		}
		else if(SfxVol <= -35f){
			Main.SetFloat("SFXaudio", -80);
		}
	}
}

