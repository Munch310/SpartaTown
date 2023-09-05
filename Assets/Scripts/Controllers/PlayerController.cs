using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 1. input�� �Ͼ�� �� �߻��ϴ� event �Լ��� Controller�� ����Ѵ�.
    // event�� �ܺο��� ȣ���� �� ����.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ?. -> OnMoveEvent�� null�� �ƴ� �� ����
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction); // ?. -> OnLookEvent�� null�� �ƴ� �� ����
    }
}
