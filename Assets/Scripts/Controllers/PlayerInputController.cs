using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// 2. Input�� �߻����� �� ������ ó���ϴ� �Լ��� �����. Controller�� ��ӹ޴´�.
public class PlayerInputController : PlayerController
{
    // ���� ī�޶�
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main; // �±װ� ���� ī�޶��� ���� ã��.
    }

    // 3. Send Message���. ������� �� �����޴� ��
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        // ĳ���Ϳ� ���콺 �������� ��ġ�� �Ÿ� ���̰� ���Ͱ����� ���´�. �� ���Ͱ��� normalized�ϸ�, ���콺�� ��ġ�� ������ �ٶ󺸴� ����� ������ �� �ִ� ��!
        newAim = (worldPos - (Vector2)transform.position).normalized;

        // magnitude = ũ��, (normalized������ 1)
        if(newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
}
