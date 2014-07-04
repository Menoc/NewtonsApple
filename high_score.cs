using UnityEngine;
using System.Collections;

public class high_score : MonoBehaviour {

	public float mainboxh;
	public float mainboxw;

	public float box_title;
	public float boxpos;


	public float boxh;
	
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
	int a=0;
	
	
	void Start () {

		mainboxh = Screen.height - Screen.height*1/3;
		mainboxw = Screen.width*2/3;
		boxpos = 0f;

		boxh = Screen.height / 8;
		
	}
	
	void OnGUI() {
		
		//GUI.Box(new Rect(Screen.width/6,boxpos,mainboxw,mainboxh),"Place for Banner\nor ads, possibly");
		GUI.Box(new Rect(Screen.width/6,boxpos,mainboxw,boxh),"High scores:");
		GUI.Box(new Rect(Screen.width/6,boxpos+boxh+2,mainboxw,boxh),"Name 1:\t"+a);
		GUI.Box(new Rect(Screen.width/6,boxpos+(boxh+2)*2,mainboxw,boxh),"Name 2:\t"+a);
		GUI.Box(new Rect(Screen.width/6,boxpos+(boxh+2)*3,mainboxw,boxh),"Name 3:\t"+a);
		GUI.Box(new Rect(Screen.width/6,boxpos+(boxh+2)*4,mainboxw,boxh),"Name 4:\t"+a);
		GUI.Box(new Rect(Screen.width/6,boxpos+(boxh+2)*5,mainboxw,boxh),"Name 5:\t"+a);
		GUI.Box(new Rect(0,boxpos+(boxh+2)*6,Screen.width,Screen.height*2/3),"one more ads block");
	}
}
