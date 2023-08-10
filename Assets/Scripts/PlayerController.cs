using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;

    private CustomInput input = null;
    private Vector2 moveAxis = Vector2.zero;
    private Rigidbody2D rb = null;

    private void Awake()
    {
        input = new CustomInput();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        input.Enable();
        input.Player.Movement.performed += OnMovementPerformed;
        input.Player.Movement.canceled += OnMovementCancelled;
        input.Player.Interaction.performed += OnButtonPressed;
    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.Movement.performed -= OnMovementPerformed;
        input.Player.Movement.canceled -= OnMovementCancelled;
        input.Player.Interaction.performed -= OnButtonPressed;
    }

    private void FixedUpdate() => rb.velocity = moveAxis * moveSpeed * Time.deltaTime;

    private void OnMovementPerformed(InputAction.CallbackContext value) => moveAxis = value.ReadValue<Vector2>();

    private void OnMovementCancelled(InputAction.CallbackContext value) => moveAxis = Vector2.zero;

    private void OnButtonPressed(InputAction.CallbackContext pressed) => StartCoroutine(Fire());


    IEnumerator Fire()
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObjet();
        if (bullet != null)
        {
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.transform.parent = transform;
            bullet.SetActive(true);
        }
        yield return new WaitForSeconds(2f);
        bullet.SetActive(false);
    }
}
