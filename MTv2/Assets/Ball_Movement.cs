using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Ball_Movement : MonoBehaviourPun
{

    private CharacterController _controller;
    private Vector3 _playervelocity;
    private float _jumpHeight = 1.0f;
    private float _gravityValue = 10.0f;

    [SerializeField] private bool _groundedPlayer;
    [SerializeField] private float _playerSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        _controller = gameObject.GetComponent<CharacterController>();

        if (!photonView.IsMine)
        {
            Destroy(GetComponent<Ball_Movement>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        _groundedPlayer = _controller.isGrounded;
        if (_groundedPlayer && _playervelocity.y < 0)
        {
            _playervelocity.y = 0f;
        }

        Vector3 _move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(_move * Time.deltaTime * _playerSpeed);

        if (_move != Vector3.zero)
        {
            gameObject.transform.forward = _move;
        }

        _playervelocity.y += _gravityValue * Time.deltaTime;
        _controller.Move(_playervelocity * Time.deltaTime);
    }
}
