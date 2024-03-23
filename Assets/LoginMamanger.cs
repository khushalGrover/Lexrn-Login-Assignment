// tempary logic for login 
// if not login then show logo
// if login then SuccessFull login prefab will active

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginMamanger : MonoBehaviour
{
    [SerializeField] private GameObject _logoPrefab;
    [SerializeField] private GameObject _successPrefab;
    private bool _isLogin = false;
   

    // void toggleState(bool state)
    // {
    //     _logoPrefab.SetActive(state);
    //     _successPrefab.SetActive(!state);
    // }


    // toggle function it will toggle the state of the logo and success prefab
    // it call when user click on the login button
    public void toggle()
    {
        if(_isLogin)
        {
            _logoPrefab.SetActive(_isLogin);
            _successPrefab.SetActive(!_isLogin);
            _isLogin = false;
        }
        else
        {
            _logoPrefab.SetActive(_isLogin);
            _successPrefab.SetActive(!_isLogin);
            _isLogin = true;
        }
    }
}
