using UnityEngine;
using System.Collections;

public class audioEnable : MonoBehaviour {

	public AudioClip[] info;
	public static bool inicioAudio;

	public DefaultTrackableEventHandler marcador;
	public DefaultTrackableEventHandler marcador2;

	private TrackableBehaviour mTrackableBehaviour;
	private TrackableBehaviour mTrackableBehaviour2;

	// Use this for initialization
	void Start () {
		mTrackableBehaviour = marcador.GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(marcador);
			//mTrackableBehaviour[1].RegisterTrackableEventHandler(marcador[1]);
		}
		mTrackableBehaviour2 = marcador2.GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour2)
		{
			mTrackableBehaviour2.RegisterTrackableEventHandler(marcador2);
			//mTrackableBehaviour[1].RegisterTrackableEventHandler(marcador[1]);
		}
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {



//						inicioAudio = true;
//
//						print ("paso nombre marcador--> " + mTrackableBehaviour.TrackableName);
//						var marcadorName = mTrackableBehaviour.TrackableName;
//						//var marcadorName2 = mTrackableBehaviour[1].TrackableName;
//			
//						print ("paso nombre marcador--> " + marcadorName);
//			
//						if (marcadorName == "Etiquetas") {
//								if (!audio.isPlaying) {
//										audio.clip = info [0];
//										audio.Play ();
//								}
//						}
//						if (marcadorName == "Etiqueta1") {
//								if (!audio.isPlaying) {
//										audio.clip = info [1];
//										audio.Play ();
//								}
//						}
//
//						print ("paso nombre marcador--> " + mTrackableBehaviour2.TrackableName);
//						var marcadorName2 = mTrackableBehaviour2.TrackableName;
//						//var marcadorName2 = mTrackableBehaviour[1].TrackableName;
//			
//						print ("paso nombre marcador--> " + marcadorName2);
//			
//						if (marcadorName2 == "Etiquetas") {
//								if (!audio.isPlaying) {
//										audio.clip = info [0];
//										audio.Play ();
//								}
//						}
//						if (marcadorName2 == "Etiqueta1") {
//								if (!audio.isPlaying) {
//										audio.clip = info [1];
//										audio.Play ();
//								}
//						}
		
				}
		
	}
}
