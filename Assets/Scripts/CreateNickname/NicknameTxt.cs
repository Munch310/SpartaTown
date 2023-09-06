using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NicknameTxt : MonoBehaviour
{
    public Text _NicknameTxt;

    void Start()
    {
        string _playerName = PlayerManager.Instance.GetPlayerName();
        if(!string.IsNullOrEmpty(_playerName))
        {
            _NicknameTxt.text = _playerName;
        }
    }
}
