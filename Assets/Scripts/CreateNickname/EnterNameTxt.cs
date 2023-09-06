using UnityEngine;
using UnityEngine.UI;

public class EnterNameTxt : MonoBehaviour
{
    public InputField _playerNameInput;
    private string _playerName = null;

    private void Awake()
    {
        if (_playerNameInput != null )
        {
            _playerName = _playerNameInput.GetComponent<InputField>().text;

            // InputField�� "Submit" �̺�Ʈ�� �̺�Ʈ �ڵ鷯�� �߰�
            _playerNameInput.onEndEdit.AddListener(OnSubmit);
        }
        else
        {
            Debug.LogError("�÷��̾� �̸��� �ùٸ��� �Է��ϼ���.");
        }
    }

    // "Submit" �̺�Ʈ �ڵ鷯
    private void OnSubmit(string value)
    {
        // �÷��̾ ���� Ű�� �����ų� �Է��� �Ϸ����� �� ȣ���
        // value �Ű��������� InputField�� ���� �ؽ�Ʈ�� ���޵�
        _playerName = value;

        // �ʿ��� �߰� ������ ���� (��: �̸� �Է� �� ���� �ܰ�� �̵�)
        Debug.Log($"�÷��̾� �̸� �Է� �Ϸ�: {_playerName}");
    }

    public string GetPlayerName()
    {
        if (_playerName.Length >= 2 && _playerName.Length <= 10)
        {
            return _playerName;
        }
        else
        {
            return "";
        }
    }
}
