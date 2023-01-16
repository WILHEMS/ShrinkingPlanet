using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

	public Animator animator;

	public void StartGame ()
	{
		animator.SetTrigger("Start");
		AudioManager.instance.Play("Click");
		//Application.targetFrameRate = 31;
	}

	public void Quit ()
	{
		Debug.Log("QUITTING");
		AudioManager.instance.Play("Click");
		Application.Quit();
	}

	public void Hover ()
	{
		AudioManager.instance.Play("Click");
		Application.targetFrameRate = 31;
	}

	public void LoadLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
