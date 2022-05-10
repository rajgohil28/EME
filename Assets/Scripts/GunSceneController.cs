using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSceneController : MonoBehaviour
{
    public Animator _gunAnimator;
    public GameObject _gunLabel;
    public GameObject _Howitzerinfo;
    public GameObject _componentsButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleInfoScreen()
    {
        if(_Howitzerinfo.activeInHierarchy == false)
        {
            _Howitzerinfo.SetActive(true);
        }
        else
        {
            _Howitzerinfo.SetActive(false);
        }
    }
    public void ToggleSplit()
    {
        _gunLabel.SetActive(false);
        if (_gunAnimator.GetBool("IsSplit"))
        {
            _gunAnimator.SetBool("IsSplit", false);
            _gunAnimator.SetBool("IsFiring",false);
            _componentsButton.SetActive(false);
        }
        else
        {
            _gunAnimator.SetBool("IsSplit", true);
            _gunAnimator.SetBool("IsFiring", false);
            _componentsButton.SetActive(true);
        }
        _gunLabel.SetActive(false);
    }
    public void ToggleFireAnimation()
    {
        _gunLabel.SetActive(false);
        if (_gunAnimator.GetBool("IsFiring"))
        {
            _gunAnimator.SetBool("IsFiring", false);
            _gunAnimator.SetBool("IsSplit", false);
        }
        else
        {
            _gunAnimator.SetBool("IsFiring", true);
            _gunAnimator.SetBool("IsSplit", false);
        }
        
    }
    public void ToggleLabel()
    {
        if(_gunLabel.activeInHierarchy == false)
        {
            _gunLabel.SetActive(true);
            _gunAnimator.SetBool("IsFiring", false);
            _gunAnimator.SetBool("IsSplit", false);
        }
        else
        {
            _gunLabel.SetActive(false);
        }
    }
}
