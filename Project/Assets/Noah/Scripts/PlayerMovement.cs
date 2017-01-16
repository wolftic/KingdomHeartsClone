using UnityEngine;

namespace Noah.Scripts
{
    public class PlayerMovement : MonoBehaviour {

        [SerializeField]
        private Transform _target;
        [SerializeField]
        private float _dist;
        private readonly Vector3 _angle = Vector3.up;
        private Transform _thisTransform;
        [SerializeField]
        private float _movSpeed = 10.0f;
        [SerializeField]
        private float _rotSpeed;
        private float _horz;
        private float _vert;
        void Start () {
            _thisTransform = GetComponent<Transform> ();
            _rotSpeed = 20.0f;
        }
        void Update () {
            transform.LookAt (_target.position);
            _horz = Input.GetAxis ("Horizontal");
            _vert = Input.GetAxis ("Vertical");
            _thisTransform.position += transform.forward * _vert * Time.deltaTime * _movSpeed;
            transform.RotateAround (_target.position, _angle, _horz * _rotSpeed * Time.deltaTime );
        }
    }
}
