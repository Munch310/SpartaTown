using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImage : MonoBehaviour
{
    public GameObject _playerSelect;

    public void OnButtonClick()
    {
        if(_playerSelect != null)
        {
            _playerSelect.SetActive(true);
        }
    }
}
