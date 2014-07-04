using UnityEngine;
using System.Collections;







public class main_menu : MonoBehaviour {



	public float topBannerH;
	public float topBannerW;

	public float buttonSizeH;
	public float buttonSizeW;
	public float buttonPos1;
	public float buttonPos2;
	public float buttonPos3;

	public float bottomBannerH;
	public float bottomBannerW;
	public float bottomBannerPos;
	
	

	void Start () {
		topBannerH = Screen.height/4;
		topBannerW = Screen.width;
		buttonSizeH = Screen.height/10;
		buttonSizeW = Screen.width/2;
		buttonPos1 = topBannerH;
		buttonPos2 = topBannerH+buttonSizeH+10;
		buttonPos3 = topBannerH+(buttonSizeH+10)*2;
		bottomBannerH = Screen.height/4;
		bottomBannerW =  Screen.width;
		bottomBannerPos = topBannerH+buttonSizeH*5;	
	
	}
	
	void OnGUI() {

		GUI.Box(new Rect(0,0,topBannerW,topBannerH),"Place for Banner\nor ads, possibly");
		

		if (GUI.Button(new Rect(buttonSizeW/2,buttonPos1+5,buttonSizeW,buttonSizeH),"Play")){
			Application.LoadLevel("main_scene");
		}

		if (GUI.Button(new Rect(buttonSizeW/2,buttonPos2+5,buttonSizeW,buttonSizeH),"High Score")){
		}

		if (GUI.Button(new Rect(buttonSizeW/2,buttonPos3+5,buttonSizeW,buttonSizeH),"Help")){
		}


		GUI.Box(new Rect(0,bottomBannerPos,bottomBannerW,bottomBannerH),"Moar ads!");
	}
}
