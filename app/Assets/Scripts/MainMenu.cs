using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
    public string scenename;

	public void LookAtMenu(Transform menuTransform)
	{
		Camera.main.transform.LookAt (menuTransform.position);
	}

    public void ChangeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
