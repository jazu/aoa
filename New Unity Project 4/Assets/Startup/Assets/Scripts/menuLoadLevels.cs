using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuLoadLevels : MonoBehaviour {
	
	public Button musicBtn;
	public Sprite musicOff;
	public Sprite musicOn;

    public void OnClickOptions(){
  		Application.LoadLevel("options");
 }
    public void OnClickStartMenu(){
  		Application.LoadLevel("start");
 }
	public void onClickChooseLevel() {
		Application.LoadLevel("chooseLevel");
 }
	public void musicToggle(){
		if (musicBtn.image.sprite == musicOff) {
			musicBtn.image.sprite = musicOn;
		} else {

			musicBtn.image.sprite=musicOff;		
		}
	}
}
