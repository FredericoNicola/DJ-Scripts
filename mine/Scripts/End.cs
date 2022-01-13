using UnityEngine;

public class End : MonoBehaviour
{

	public GameManager gameManager;
	public AudioSource som;

	void OnTriggerEnter()
	{
		gameManager.CompleteLevel();
		som.Play();
	}

}
