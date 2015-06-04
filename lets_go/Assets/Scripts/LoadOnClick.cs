using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;

    public void LoadScence(int level)
    {
        loadingImage.SetActive(true);
        Application.LoadLevel(level);
    }
}
