using UnityEngine;

public class SwitchGameObject : MonoBehaviour {

    [SerializeField] public GameObject gameObject;

    public void Switch() {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}