using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject _ar360buttons;
    public GameObject _targetImage;
    public GameObject _howToUseImage;
    // Start is called before the first frame update
    public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
    public void ShowImageTarget()
    {
        if(_targetImage.activeInHierarchy == false)
        {
            _howToUseImage.SetActive(false);
            _targetImage.SetActive(true);
            _ar360buttons.SetActive(false);
        }
        else
        {
            _howToUseImage.SetActive(false);
            _targetImage.SetActive(false);
            _ar360buttons.SetActive(true);
        }
    }
    public void ShowHowToUseButton()
    {
        if(_howToUseImage.activeInHierarchy == false)
        {
            _howToUseImage.SetActive(true);
            _targetImage.SetActive(false);
            _ar360buttons.SetActive(false);
        }
        else
        {
            _howToUseImage.SetActive(false);
            _targetImage.SetActive(false);
            _ar360buttons.SetActive(true);
        }
    }
}
