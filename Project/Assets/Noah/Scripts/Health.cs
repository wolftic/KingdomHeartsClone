using UnityEngine;

namespace Noah.Scripts
{
    public class Health : MonoBehaviour {

        [SerializeField]
        private float _health = 100.0f;



        public float PlayerHealth{
            get {
                return _health;
            }
            set	{
                _health = value;
            }



        }



        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
		
        }
    }
}
