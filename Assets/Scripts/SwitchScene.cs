using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

    [SerializeField] public string nameScene;

    public void Switch() {
        SceneManager.LoadScene(nameScene);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(nameScene));
    }
}