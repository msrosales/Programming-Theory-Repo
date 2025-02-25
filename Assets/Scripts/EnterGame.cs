using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGame : MonoBehaviour
{
	public void GoIntoGame(){
		SceneManager.LoadScene(0);
	}
}
