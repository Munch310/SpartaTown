using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinBtn : MonoBehaviour
{
    public EnterNameTxt _enterNameTxt;
    public GameObject player1;
    public GameObject player2;

    public void OnJoinButtonClick()
    {
        if (_enterNameTxt != null)
        {
            string _playerName = _enterNameTxt.GetPlayerName();

            if (!string.IsNullOrEmpty(_playerName))
            {
                int playerIndex = -1; // �ʱ�ȭ�� �÷��̾� �ε��� ����

                // Player1�� Player2 ���� ������Ʈ�� Ȱ��ȭ ���¸� Ȯ���Ͽ� �ε��� ����
                if (player1 != null && player1.activeSelf)
                {
                    playerIndex = 0; // Player1�� Ȱ��ȭ�� ��� �ε��� 0 ����
                }
                else if (player2 != null && player2.activeSelf)
                {
                    playerIndex = 1; // Player2�� Ȱ��ȭ�� ��� �ε��� 1 ����
                }

                // PlayerManager�� �÷��̾� �̸� �� �ε��� ����
                PlayerManager.Instance.SetPlayerName(_playerName);

                // GameManager�� �÷��̾� �ε��� ����
                GameManager.Instance.SetPlayerIndex(playerIndex);

                Debug.Log($"{_playerName}");
                Debug.Log($"�÷��̾� �ε���: {playerIndex}");

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
