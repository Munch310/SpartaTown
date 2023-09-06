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
                // PlayerManager�� �÷��̾� �̸� ����
                PlayerManager.Instance.SetPlayerName(_playerName);

                Debug.Log($"{_playerName}");
                SceneManager.LoadScene("MainScene");
            }
            else
            {
                Debug.Log("2~10���ڷ� �Է����ּ���.");
            }
        }
        else
        {
            Debug.LogError("�̸��� ������ϴ�.");
        }
    }
}
