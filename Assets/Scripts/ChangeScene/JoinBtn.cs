using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinBtn : MonoBehaviour
{
    public EnterNameTxt _enterNameTxt;

    public void OnJoinButtonClick()
    {
        if (_enterNameTxt != null)
        {
            string _playerName = _enterNameTxt.GetPlayerName();

            if (!string.IsNullOrEmpty(_playerName))
            {
                // PlayerManager에 플레이어 이름 설정
                PlayerManager.Instance.SetPlayerName(_playerName);

                Debug.Log($"{_playerName}");
                SceneManager.LoadScene("MainScene");
            }
            else
            {
                Debug.Log("2~10글자로 입력해주세요.");
            }
        }
        else
        {
            Debug.LogError("이름이 비었습니다.");
        }
    }
}
