using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MenuControl : MonoBehaviour
{
    public void NextScene()
    {

		switch(this.gameObject.name){
		case "Development":
			SceneManager.LoadScene("Scene1");
			break;
		case "Production":
			SceneManager.LoadScene("Scene2");
			break;
		}
    }
}