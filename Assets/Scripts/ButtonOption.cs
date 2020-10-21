using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// followed along Jimmy Vegas's video and made according modifications

public class ButtonOption : MonoBehaviour {

	public void PlayGame () {
		SceneManager.LoadScene (2);
	}

	public void TrackSelect () {
		SceneManager.LoadScene (1);
	}

	public void MainMenu () {
		SceneManager.LoadScene (0);
	}


	public void Track01 () {
		SceneManager.LoadScene (2);
	}

    	public void Track02 () {
		SceneManager.LoadScene (3);
	}

}
